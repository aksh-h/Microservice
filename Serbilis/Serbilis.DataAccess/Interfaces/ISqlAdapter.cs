#region Software and Source Code Copyright

// 
//  ISqlAdapter.cs
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

using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Serbilis.DataAccess.Interfaces
{
    public interface ISqlAdapter
    {
        int Insert(IDbConnection connection, int? commandTimeout, string tableName,
            string columnList,
            string parameterList, IEnumerable<PropertyInfo> keyProperties, object entityToInsert);

        int Insert(IDbTransaction transaction, int? commandTimeout, string tableName,
            string columnList,
            string parameterList, IEnumerable<PropertyInfo> keyProperties, object entityToInsert);
    }
}