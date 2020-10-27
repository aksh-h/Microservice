using Dapper;
using Microsoft.Extensions.Configuration;
using Serbilis.Core.Helpers;
using Serbilis.Core.Models;
using Serbilis.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Unisys.ExceptionHandling;
using Unisys.Localization.Helpers;

namespace Serbilis.DataAccess
{
    [Exception(Policies.DataAccessPolicy, Unisys.Logging.LoggerType.FileLogger)]
    public sealed class Repository<T> : IRepository<T>, IDisposable where T : EntityBase

    {
        private readonly ConnectionType _connectionType;
        private bool _disposed;

        public Repository(T entity, ConnectionType connectionType)
        {
            _connectionType = connectionType;
        }

        private string GetConnection(ConnectionType connectionType)
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

        private void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                {
                }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Add(T entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity), new ResourceHelper().ReadResources("AddError"));
                Conn.Insert(entity, transaction, commandTimeout);
            }
        }

        public void Update(T entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity), new ResourceHelper().ReadResources("UpdateError"));
                Conn.Update(entity, commandTimeout);
            }
        }

        public void Remove(T entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity), new ResourceHelper().ReadResources("DeleteError"));
                Conn.Open();
                Conn.Delete(entity, transaction, commandTimeout);
            }
        }

        public T GetByKey(object id, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                if (id == null)
                    throw new ArgumentNullException(nameof(id));
                Conn.Open();
                return Conn.Get<T>(id, transaction, commandTimeout);
            }
        }

        public IEnumerable<T> GetAll(IDbTransaction transaction = null, int? commandTimeout = null)
        {
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                Conn.Open();
                return Conn.GetAll<T>(transaction, commandTimeout);
            }
        }

        public SqlMapper.GridReader Querymultiple(string sql, DynamicParameters param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?))
        {
            SqlConnection Conn = new SqlConnection(GetConnection(_connectionType));
            Conn.Open();
            return Conn.QueryMultiple(sql, param, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<object> QuerymultipleRecords(List<ModelBase> modelObject, string sql,
            DynamicParameters param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?))
        {
            try
            {
                // Type desType = modelObject.GetType();

                List<object> result = new List<object>(modelObject.Count);
                for (int count = 0; count < modelObject.Count; count++)
                    result.Add(null);
                using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
                {
                    Conn.Open();
                    SqlMapper.GridReader multiResult = Conn.QueryMultiple(sql, param, commandType: CommandType.StoredProcedure);
                    for (int count = 0; count < modelObject.Count; count++)
                        result[count] = multiResult.Read(modelObject[count].GetType()); //multiResult.Read(desType);
                }

                if (modelObject.Count == 1)
                    return (result[0] as IEnumerable<object>).AsEnumerable();
                return result.AsEnumerable();
            }
            catch (Exception ex)
            {
                //It is required to display the SP raise errors. Please don't return null.
                throw ex;
            }
        }


        // This method can be used for Insert , Delete , Update(For Stored Procedure)
        // We can pass Stored procedure with/without parameter.
        public int Exec(string spName, DynamicParameters param = null, IDbTransaction transaction = null,
            int? commandTimeout = null)
        {
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                try
                {
                    Conn.Open();
                    return Conn.Execute(spName, param, commandType: CommandType.StoredProcedure,
                        transaction: transaction, commandTimeout: commandTimeout);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public List<int> ExecuteAll(string spName, List<DynamicParameters> paramList)
        {

            List<int> results = new List<int>();
            using (SqlConnection connection = new SqlConnection(GetConnection(_connectionType)))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    foreach (DynamicParameters param in paramList)
                    {
                        int result = connection.Execute(spName, param, commandType: CommandType.StoredProcedure,
                            transaction: transaction, commandTimeout: null);
                        string returnId = param.Get<string>("@ID");
                        results.Add(Convert.ToInt32(returnId));
                    }

                    transaction.Commit();
                }
            }

            return results;
        }

        public string ExecuteScalar(string spName, DynamicParameters param = null, IDbTransaction transaction = null,
            int? commandTimeout = null)
        {
            object result = null;
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                try
                {
                    Conn.Open();
                    result = Conn.ExecuteScalar(spName, param, commandType: CommandType.StoredProcedure,
                        transaction: transaction, commandTimeout: commandTimeout);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (result == null)
                    return null;
                return result.ToString();
            }
        }

        public string ExecuteScalarQuery(string spName, DynamicParameters param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null)
        {
            object result = null;
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                try
                {
                    Conn.Open();
                    result = Conn.ExecuteScalar(spName, param, commandType: CommandType.Text,
                        transaction: transaction, commandTimeout: commandTimeout);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (result == null)
                    return null;
                return result.ToString();
            }
        }

        public IEnumerable<Tsp> QueryResult<Tsp>(string storedProcedure, dynamic param = null,
            dynamic outParam = null, SqlTransaction transaction = null,
            bool buffered = true, int? commandTimeout = null
        ) where Tsp : class
        {
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                Conn.Open();
                return Conn.Query<Tsp>(storedProcedure, (object)param,
                    transaction, buffered, commandTimeout,
                    CommandType.StoredProcedure);
            }
        }

        public IEnumerable<object> Execute(string spName, DynamicParameters param = null,
            IDbTransaction transaction = null, int? commandTimeout = default(int?))
        {
            using (SqlConnection Conn = new SqlConnection(GetConnection(_connectionType)))
            {
                Conn.Open();
                return Conn.Query(spName, param,
                    transaction, commandTimeout: commandTimeout,
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}