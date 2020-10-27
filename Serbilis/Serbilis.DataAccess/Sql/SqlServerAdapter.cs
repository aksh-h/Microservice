#region Software and Source Code Copyright

// 
//  SqlServerAdapter.cs
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
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using Unisys.ExceptionHandling;
using Unisys.Logging;

namespace Serbilis.DataAccess
{
    [Exception(Policies.DataAccessPolicy, LoggerType.FileLogger)]
    internal class SqlServerAdapter : ISqlAdapter
    {
        /// <summary>
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <param name="parameterList"></param>
        /// <param name="keyProperties"></param>
        /// <param name="entityToInsert"></param>
        /// <returns></returns>
        public int Insert(IDbConnection connection, int? commandTimeout, string tableName,
            string columnList,
            string parameterList, IEnumerable<PropertyInfo> keyProperties, object entityToInsert)
        {
            string command = $"insert into {tableName} ({columnList}) values ({parameterList})";
            connection.Execute(command, entityToInsert, null, commandTimeout);
            //NOTE: would prefer to use IDENT_CURRENT('tablename') or IDENT_SCOPE but these are not available on SQLCE
            IEnumerable<dynamic> r =
                connection.Query("select @@IDENTITY id", transaction: null, commandTimeout: commandTimeout);
            int id = (int)r.First().id;
            PropertyInfo[] propertyInfos = keyProperties as PropertyInfo[] ?? keyProperties.ToArray();
            if (propertyInfos.Any())
                propertyInfos.First().SetValue(entityToInsert, id, null);
            return id;
        }

        /// <summary>
        /// </summary>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <param name="parameterList"></param>
        /// <param name="keyProperties"></param>
        /// <param name="entityToInsert"></param>
        /// <returns></returns>
        public int Insert(IDbTransaction transaction, int? commandTimeout, string tableName,
            string columnList,
            string parameterList, IEnumerable<PropertyInfo> keyProperties, object entityToInsert)
        {
            string command = $"insert into {tableName} ({columnList}) values ({parameterList})";

            transaction.Connection.Execute(command, entityToInsert, transaction, commandTimeout);

            //NOTE: would prefer to use IDENT_CURRENT('tablename') or IDENT_SCOPE but these are not available on SQLCE
            IEnumerable<dynamic> r = transaction.Connection.Query("select @@IDENTITY id", transaction: transaction,
                commandTimeout: commandTimeout);
            int id = (int)r.First().id;
            PropertyInfo[] propertyInfos = keyProperties as PropertyInfo[] ?? keyProperties.ToArray();
            if (propertyInfos.Any())
                propertyInfos.First().SetValue(entityToInsert, id, null);
            return id;
        }
    }
}