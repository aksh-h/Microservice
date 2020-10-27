using Microsoft.Extensions.Configuration;
using Serbilis.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using Unisys.Cryptography;

namespace Serbilis.DataAccess
{
    public static class DBSettings
    {
        private static AppSettingsSection appSettings;

        public static string APPSettingsConfigPath()
        {
            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            appSettings = appConfig.GetSection("appSettings") as AppSettingsSection;
            if (appSettings.Settings.Count == 0)
            {
                string dllPath = new Uri(Assembly.GetExecutingAssembly().GetName().CodeBase).LocalPath;
                Configuration dllConfig = ConfigurationManager.OpenExeConfiguration(dllPath);
                appSettings = (AppSettingsSection)dllConfig.GetSection("appSettings");
                if (appSettings.Settings.Count == 0)
                    return "Invalid FilePath";
            }

            return appSettings.Settings["FilePath"].Value;
        }

        public static string GetDBConnectionString(ConnectionType connectionType)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(projectPath)
                .AddJsonFile("appsettings.json")
                .Build();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            var passwordKey = configuration.GetSection("PasswordKey").Value;

            return DBSettings.getEncryptedValue(connectionString, passwordKey);
        }

        public static string getEncryptedValue(string connString, string passwordKey)
        {
            string result;
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connString);
            CryptographyHelper cryptographyHelper = new CryptographyHelper();
            string pwd = cryptographyHelper.DecryptUsingKey(sb.Password, passwordKey);
            if (!string.IsNullOrEmpty(pwd))
                sb.Password = pwd;
            result = sb.ToString().Replace("\"", "");
            return result;
        }

        public static string CreateConnection(IEnumerable<KeyValueConfigurationElement> settings, string key)
        {
            foreach (KeyValueConfigurationElement setting in settings)
                if (setting.Key.ToUpper().Contains(key.ToUpper()))
                    return setting.Value;
            return "Invalid Connection";
        }
    }
}