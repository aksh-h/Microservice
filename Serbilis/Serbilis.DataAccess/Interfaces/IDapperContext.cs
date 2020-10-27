#region Software and Source Code Copyright

// 
//  IDapperContext.cs
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

using System;
using System.Data;

namespace Serbilis.DataAccess.Interfaces
{
    public interface IDapperContext : IDisposable
    {
        IDbConnection Connection { get; }
        new void Dispose();
    }
}