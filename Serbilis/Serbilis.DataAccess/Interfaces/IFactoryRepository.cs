#region Software and Source Code Copyright
// 
//  IFactoryRepository.cs
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

using Serbilis.Core.Helpers;

namespace Serbilis.DataAccess.Interfaces
{
    public interface IFactoryServiceRepository<T> where T : EntityBase
    {
        IGenericRepository<T> CreateRepository(T entity);
        T GetValue(object value);
        object GetRepository(string x, T entityModel);
    }
}