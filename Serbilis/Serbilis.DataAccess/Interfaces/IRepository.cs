#region Software and Source Code Copyright

// 
//  IRepository.cs
// 
//  13-06-2017
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
using Serbilis.Core.Helpers;
using Serbilis.Core.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static Dapper.SqlMapper;

namespace Serbilis.DataAccess.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        void Add(T entity, IDbTransaction transaction = null, int? commandTimeout = null);
        void Update(T entity, IDbTransaction transaction = null, int? commandTimeout = null);
        void Remove(T entity, IDbTransaction transaction = null, int? commandTimeout = null);

        T GetByKey(object key, IDbTransaction transaction = null, int? commandTimeout = null);

        IEnumerable<T> GetAll(IDbTransaction transaction = null, int? commandTimeout = null);

        GridReader Querymultiple(string SQL, DynamicParameters param = null, IDbTransaction transaction = null,
            int? commandTimeout = null);

        IEnumerable<object> QuerymultipleRecords(List<ModelBase> modelObject, string SQL,
            DynamicParameters param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null);

        IEnumerable<dynamic> Execute(string spName, DynamicParameters param = null, IDbTransaction transaction = null,
            int? commandTimeout = null);

        IEnumerable<Tsp> QueryResult<Tsp>(string storedProcedure, dynamic param = null,
            dynamic outParam = null, SqlTransaction transaction = null,
            bool buffered = true, int? commandTimeout = null
        ) where Tsp : class;

        int Exec(string spName, DynamicParameters param = null, IDbTransaction transaction = null,
            int? commandTimeout = null);

        List<int> ExecuteAll(string spName, List<DynamicParameters> paramList);

        string ExecuteScalar(string spName, DynamicParameters param = null, IDbTransaction transaction = null,
            int? commandTimeout = null);

        string ExecuteScalarQuery(string spName, DynamicParameters param = null, IDbTransaction transaction = null,
            int? commandTimeout = null);
    }
}