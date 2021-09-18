#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Exomia.Vulkan.Api.SourceGenerator.Models
{
    struct VkExtensionClass
    {
        public string                    NamespaceName;
        public string                    ClassName;
        public string                    VarExtensionName;
        public string                    ExtensionName;
        public IMethodSymbol             LoadFunction;
        public List<FunctionPointerInfo> Functions;
    }
}