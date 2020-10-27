using Dapper;
using Serbilis.Core.Helpers;
using Serbilis.Core.Models;
using System.Collections.Generic;

namespace Serbilis.DataAccess.Interfaces
{
    public interface IDataService
    {
        IEnumerable<object> Execute(string spName, ConnectionType connectionType, DynamicParameters param = null);
        int Exec(string spName, ConnectionType connectionType, DynamicParameters param = null);
        List<int> ExecuteAll(string spName, ConnectionType connectionType, List<DynamicParameters> paramList);

        string ExecuteScalar(string spName, ConnectionType connectionType, DynamicParameters param = null);

        string ExecuteScalarQuery(string spName, ConnectionType connectionType, DynamicParameters param = null);

        IEnumerable<object> QuerymultipleRecords(List<ModelBase> modelObject, string spName,
            ConnectionType connectionType, DynamicParameters param = null);
    }
}
