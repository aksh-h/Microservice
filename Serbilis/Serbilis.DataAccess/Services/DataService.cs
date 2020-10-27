using Dapper;
using Serbilis.Core.Helpers;
using Serbilis.Core.Models;
using Serbilis.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Unisys.ExceptionHandling;
using Unisys.Logging;

namespace Serbilis.DataAccess.Services
{
    [Exception(Policies.DataAccessPolicy, LoggerType.FileLogger)]
    public class DataService : IDataService //where TEntity : EntityBase
    {
        public DataService()
        {
        }

        public IEnumerable<object> Execute(string spName, ConnectionType connectionType, DynamicParameters param = null)
        {
            IRepository<DapperEntity> repository = new Repository<DapperEntity>(
                new DapperEntity(DBSettings.GetDBConnectionString(connectionType)), connectionType);
            return repository.Execute(spName, param).ToList();
        }

        public int Exec(string spName, ConnectionType connectionType, DynamicParameters param = null)
        {
            IRepository<DapperEntity> repository = new Repository<DapperEntity>(
                new DapperEntity(DBSettings.GetDBConnectionString(connectionType)), connectionType);
            return repository.Exec(spName, param, null, null);
        }

        public List<int> ExecuteAll(string spName, ConnectionType connectionType, List<DynamicParameters> paramList)
        {
            IRepository<DapperEntity> repository = new Repository<DapperEntity>(
                new DapperEntity(DBSettings.GetDBConnectionString(connectionType)), connectionType);
            return repository.ExecuteAll(spName, paramList);
        }

        public IEnumerable<object> QuerymultipleRecords(List<ModelBase> modelObject, string spName,
            ConnectionType connectionType, DynamicParameters param = null)
        {
            IRepository<DapperEntity> repository = new Repository<DapperEntity>(
                new DapperEntity(DBSettings.GetDBConnectionString(connectionType)), connectionType);
            return repository.QuerymultipleRecords(modelObject, spName, param);
        }

        public string ExecuteScalar(string spName, ConnectionType connectionType, DynamicParameters param = null)
        {
            IRepository<DapperEntity> repository = new Repository<DapperEntity>(
                new DapperEntity(DBSettings.GetDBConnectionString(connectionType)), connectionType);
            return repository.ExecuteScalar(spName, param, null, null);
        }

        public string ExecuteScalarQuery(string spName, ConnectionType connectionType, DynamicParameters param = null)
        {
            IRepository<DapperEntity> repository = new Repository<DapperEntity>(
                new DapperEntity(DBSettings.GetDBConnectionString(connectionType)), connectionType);
            return repository.ExecuteScalarQuery(spName, param, null, null);
        }
    }
}
