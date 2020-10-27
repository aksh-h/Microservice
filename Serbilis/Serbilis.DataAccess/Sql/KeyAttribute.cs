#region Software and Source Code Copyright

// 
//  KeyAttribute.cs
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

using System;

namespace Serbilis.DataAccess
{
    [AttributeUsage(AttributeTargets.Property)]
    public class KeyAttribute : Attribute
    {
    }
}