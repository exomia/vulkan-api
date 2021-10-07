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
    /// <summary> Attribute for vk extension generation. This class cannot be inherited. </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class VkExtGeneratorAttribute : Attribute { }
}

