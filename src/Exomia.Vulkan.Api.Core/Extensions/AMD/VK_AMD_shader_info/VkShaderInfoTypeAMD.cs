#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkShaderInfoTypeAMD - Enum specifying which type of shader information to query -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderInfoTypeAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderInfoTypeAMD.html</a>
/// </summary>
public enum VkShaderInfoTypeAMD
{
    /// <summary>VK_SHADER_INFO_TYPE_STATISTICS_AMD specifies that device resources used by a shader will be queried.</summary>
    VK_SHADER_INFO_TYPE_STATISTICS_AMD = 0,

    /// <summary>VK_SHADER_INFO_TYPE_BINARY_AMD specifies that implementation-specific information will be queried.</summary>
    VK_SHADER_INFO_TYPE_BINARY_AMD = 1,

    /// <summary>VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD specifies that human-readable disassembly of a shader.</summary>
    VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD = 2
}