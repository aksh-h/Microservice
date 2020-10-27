#region Software and Source Code Copyright

// 
//  SqlMapperExtensions.cs
// 
//  14-04-2017
// 
//  Copyright © 2017 Unisys Corporation.
// 
//  All rights reserved.
// 
//  This work contains trade secrets and confidential material of Unisys
//  Corporation, and its use or disclosure in whole or in part without
//  express written permission of Unisys Corporation is prohibited.
// 
// 

#endregion

using Dapper;
using Serbilis.DataAccess.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using Unisys.ExceptionHandling;
using Unisys.Logging;

namespace Serbilis.DataAccess
{
    [Exception(Policies.DataAccessPolicy, LoggerType.FileLogger)]
    public static class SqlMapperExtensions
    {
        private static readonly ConcurrentDictionary<RuntimeTypeHandle, IEnumerable<PropertyInfo>> KeyProperties =
            new ConcurrentDictionary<RuntimeTypeHandle, IEnumerable<PropertyInfo>>();

        private static readonly ConcurrentDictionary<RuntimeTypeHandle, IEnumerable<PropertyInfo>> TypeProperties =
            new ConcurrentDictionary<RuntimeTypeHandle, IEnumerable<PropertyInfo>>();

        private static readonly ConcurrentDictionary<RuntimeTypeHandle, string> GetQueries =
            new ConcurrentDictionary<RuntimeTypeHandle, string>();

        private static readonly ConcurrentDictionary<RuntimeTypeHandle, string> TypeTableName =
            new ConcurrentDictionary<RuntimeTypeHandle, string>();

        private static readonly ConcurrentDictionary<RuntimeTypeHandle, string> GetQueriesAll =
            new ConcurrentDictionary<RuntimeTypeHandle, string>();

        private static readonly Dictionary<string, ISqlAdapter> AdapterDictionary = new Dictionary<string, ISqlAdapter>
        {
            {"sqlconnection", new SqlServerAdapter()}
        };

        private static IEnumerable<PropertyInfo> KeyPropertiesCache(Type type)
        {
            IEnumerable<PropertyInfo> pi;
            if (KeyProperties.TryGetValue(type.TypeHandle, out pi))
                return pi;

            IEnumerable<PropertyInfo> allProperties = TypePropertiesCache(type);
            if (allProperties != null)
            {
                PropertyInfo[] propertyInfos = allProperties as PropertyInfo[] ?? allProperties.ToArray();
                List<PropertyInfo> keyProperties =
                    propertyInfos.Where(p => p.GetCustomAttributes(true).Any(a => a is KeyAttribute)).ToList();

                if (keyProperties.Count == 0)
                {
                    PropertyInfo idProp = propertyInfos.FirstOrDefault(p => p.Name.ToLower() == "id");
                    if (idProp != null)
                        keyProperties.Add(idProp);
                }

                KeyProperties[type.TypeHandle] = keyProperties;
                return keyProperties;
            }

            return null;
        }

        /// <summary>
        ///   GetAll Records based on T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="connection"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetAll<T>(this IDbConnection connection, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            Type type = typeof(T);
            string sql;
            if (!GetQueriesAll.TryGetValue(type.TypeHandle, out sql))
            {
                string name = GetTableName(type);

                // TODO: pluralizer
                // TODO: query information schema and only select fields that are both in information schema and underlying class / interface
                sql = $"select * from {name}";
                GetQueriesAll[type.TypeHandle] = sql;
            }

            IEnumerable<T> obj = null;
            obj = connection.Query<T>(sql, transaction: transaction, commandTimeout: commandTimeout);
            return obj;
        }

        private static IEnumerable<PropertyInfo> TypePropertiesCache(Type type)
        {
            IEnumerable<PropertyInfo> pis;
            if (TypeProperties.TryGetValue(type.TypeHandle, out pis))
                return pis;

            IEnumerable<PropertyInfo> properties = type.GetProperties().Where(IsWriteable);
            PropertyInfo[] typePropertiesCache = properties as PropertyInfo[] ?? properties.ToArray();
            TypeProperties[type.TypeHandle] = typePropertiesCache;
            return typePropertiesCache;
        }

        private static bool IsWriteable(PropertyInfo pi)
        {
            object[] attributes = pi.GetCustomAttributes(typeof(WriteAttribute), false);
            if (attributes.Length == 1)
            {
                WriteAttribute write = (WriteAttribute)attributes[0];
                return write.Write;
            }

            return true;
        }

        /// <summary>
        ///   Returns a single entity by a single id from table "Ts". T must be of interface type.
        ///   Id must be marked with [Key] attribute.
        ///   Created entity is tracked/intercepted for changes and used by the Update() extension.
        /// </summary>
        /// <typeparam name="T">Interface type to create and populate</typeparam>
        /// <param name="connection">Open SqlConnection</param>
        /// <param name="id">Id of the entity to get, must be marked with [Key] attribute</param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <returns>Entity of T</returns>
        public static T Get<T>(this IDbConnection connection, dynamic id, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            Type type = typeof(T);
            string sql;
            if (!GetQueries.TryGetValue(type.TypeHandle, out sql))
            {
                IEnumerable<PropertyInfo> keys = KeyPropertiesCache(type);
                PropertyInfo[] propertyInfos = keys as PropertyInfo[] ?? keys.ToArray();
                if (propertyInfos.Count() > 1)
                    throw new DataException("Get<T> only supports an entity with a single [Key] property");
                if (!propertyInfos.Any())
                    throw new DataException("Get<T> only supports en entity with a [Key] property");

                PropertyInfo onlyKey = propertyInfos.First();

                string name = GetTableName(type);

                // TODO: pluralizer
                // TODO: query information schema and only select fields that are both in information schema and underlying class / interface
                sql = "select * from " + name + " where [" + onlyKey.Name + "] = @id";
                GetQueries[type.TypeHandle] = sql;
            }

            DynamicParameters dynParms = new DynamicParameters();
            dynParms.Add("@id", id);

            T obj = null;
            obj =
                connection.Query<T>(sql, dynParms, transaction, commandTimeout: commandTimeout)
                    .FirstOrDefault();
            return obj;
        }

        private static string GetTableName(Type type)
        {
            string name;
            if (!TypeTableName.TryGetValue(type.TypeHandle, out name))
            {
                name = type.Name; // + "s";
                if (type.IsInterface && name.StartsWith("I"))
                    name = name.Substring(1);

                //NOTE: This as dynamic trick should be able to handle both our own Table-attribute as well as the one in EntityFramework
                dynamic tableattr =
                    type
                            .GetCustomAttributes(false)
                            .SingleOrDefault(attr => attr.GetType().Name == "TableAttribute") as
                        dynamic;
                if (tableattr != null)
                    name = tableattr.Name;
                TypeTableName[type.TypeHandle] = name;
            }

            return "[" + name + "]";
        }

        /// <summary>
        ///   Inserts an entity into table "Ts" and returns identity id.
        /// </summary>
        /// <param name="connection">Open SqlConnection</param>
        /// <param name="entityToInsert">Entity to insert</param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <returns>Identity of inserted entity</returns>
        public static long Insert<T>(this IDbConnection connection, T entityToInsert, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            Type type = typeof(T);
            string name = GetTableName(type);
            StringBuilder sbColumnList = new StringBuilder(null);
            IEnumerable<PropertyInfo> allProperties = TypePropertiesCache(type);
            IEnumerable<PropertyInfo> keyProperties = KeyPropertiesCache(type);
            PropertyInfo[] propertyInfos = keyProperties as PropertyInfo[] ?? keyProperties.ToArray();
            IEnumerable<PropertyInfo> allPropertiesExceptKey = allProperties.Except(propertyInfos);
            PropertyInfo[] propertiesExceptKey = allPropertiesExceptKey as PropertyInfo[] ?? allPropertiesExceptKey.ToArray();
            for (int i = 0; i < propertiesExceptKey.Count(); i++)
            {
                PropertyInfo property = propertiesExceptKey.ElementAt(i);
                sbColumnList.AppendFormat("[{0}]", property.Name);
                if (i < propertiesExceptKey.Count() - 1)
                    sbColumnList.Append(", ");
            }

            StringBuilder sbParameterList = new StringBuilder(null);
            for (int i = 0; i < propertiesExceptKey.Count(); i++)
            {
                PropertyInfo property = propertiesExceptKey.ElementAt(i);
                sbParameterList.AppendFormat("@{0}", property.Name);
                if (i < propertiesExceptKey.Count() - 1)
                    sbParameterList.Append(", ");
            }

            ISqlAdapter adapter = GetFormatter(connection);
            long id = 0;

            if (transaction == null)
                id = adapter.Insert(connection, commandTimeout, name, sbColumnList.ToString(),
                    sbParameterList.ToString(), propertyInfos, entityToInsert);
            else
                id = adapter.Insert(transaction, commandTimeout, name, sbColumnList.ToString(),
                    sbParameterList.ToString(), propertyInfos, entityToInsert);
            return id;
        }

        /// <summary>
        ///   Updates entity in table "Ts", checks if the entity is modified if the entity is tracked by the Get() extension.
        /// </summary>
        /// <typeparam name="T">Type to be updated</typeparam>
        /// <param name="connection">Open SqlConnection</param>
        /// <param name="entityToUpdate">Entity to be updated</param>
        /// <param name="commandTimeout"></param>
        /// <returns>true if updated, false if not found or not modified (tracked entities)</returns>
        public static bool Update<T>(this IDbConnection connection, T entityToUpdate, int? commandTimeout = null)
            where T : class
        {
            IProxy proxy = entityToUpdate as IProxy;
            if (proxy != null)
                if (!proxy.IsDirty)
                    return false;

            Type type = typeof(T);

            IEnumerable<PropertyInfo> keyProperties = KeyPropertiesCache(type);
            PropertyInfo[] propertyInfos = keyProperties as PropertyInfo[] ?? keyProperties.ToArray();
            if (!propertyInfos.Any())
                throw new ArgumentException("Entity must have at least one [Key] property");

            string name = GetTableName(type);

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update {0} set ", name);

            IEnumerable<PropertyInfo> allProperties = TypePropertiesCache(type);
            IEnumerable<PropertyInfo> nonIdProps = allProperties.Where(a => !propertyInfos.Contains(a));

            PropertyInfo[] idProps = nonIdProps as PropertyInfo[] ?? nonIdProps.ToArray();
            for (int i = 0; i < idProps.Count(); i++)
            {
                PropertyInfo property = idProps.ElementAt(i);
                sb.AppendFormat("[{0}] = @{1}", property.Name, property.Name);
                if (i < idProps.Count() - 1)
                    sb.AppendFormat(", ");
            }

            sb.Append(" where ");
            for (int i = 0; i < propertyInfos.Count(); i++)
            {
                PropertyInfo property = propertyInfos.ElementAt(i);
                sb.AppendFormat("[{0}] = @{1}", property.Name, property.Name);
                if (i < propertyInfos.Count() - 1)
                    sb.AppendFormat(" and ");
            }

            int updated = connection.Execute(sb.ToString(), entityToUpdate, commandTimeout: commandTimeout);
            return updated > 0;
        }

        /// <summary>
        ///   Delete entity in table "Ts".
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="connection">Open SqlConnection</param>
        /// <param name="entityToDelete">Entity to delete</param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <returns>true if deleted, false if not found</returns>
        public static bool Delete<T>(this IDbConnection connection, T entityToDelete, IDbTransaction transaction = null,
            int? commandTimeout = null) where T : class
        {
            if (entityToDelete == null)
                throw new ArgumentException(@"Cannot Delete null Object", "entityToDelete");

            Type type = typeof(T);

            IEnumerable<PropertyInfo> keyProperties = KeyPropertiesCache(type);
            PropertyInfo[] propertyInfos = keyProperties as PropertyInfo[] ?? keyProperties.ToArray();
            if (!propertyInfos.Any())
                throw new ArgumentException("Entity must have at least one [Key] property");

            string name = GetTableName(type);

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("delete from {0} where ", name);

            for (int i = 0; i < propertyInfos.Count(); i++)
            {
                PropertyInfo property = propertyInfos.ElementAt(i);
                sb.AppendFormat("[{0}] = @{1}", property.Name, property.Name);
                if (i < propertyInfos.Count() - 1)
                    sb.AppendFormat(" and ");
            }

            int deleted = connection.Execute(sb.ToString(), entityToDelete, transaction,
                commandTimeout);
            return deleted > 0;
        }

        private static ISqlAdapter GetFormatter(IDbConnection connection)
        {
            string name = connection.GetType().Name.ToLower();
            if (!AdapterDictionary.ContainsKey(name))
                return new SqlServerAdapter();
            return AdapterDictionary[name];
        }

        private interface IProxy
        {
            bool IsDirty { get; set; }
        }
    }
}