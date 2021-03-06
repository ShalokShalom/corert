// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Internal.TypeSystem;

namespace Internal.IL.Stubs
{
    /// <summary>
    /// contains functionality related to name mangling
    /// </summary>
    public partial class DelegateMarshallingMethodThunk : IPrefixMangledType
    {
        TypeDesc IPrefixMangledType.BaseType
        {
            get
            {
                return _delegateType;
            }
        }

        string IPrefixMangledType.Prefix
        {
            get
            {
                return NamePrefix;
            }
        }
    }
}
