#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    /// <summary> Attribute for vk function generation. This class cannot be inherited. </summary>
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
    sealed class VkFunctionGeneratorAttribute : Attribute { }
}

