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
///     VkShaderCodeTypeEXT - Indicate a shader code type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderCodeTypeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderCodeTypeEXT.html</a>
/// </summary>
public enum VkShaderCodeTypeEXT
{
    /// <summary>
    ///     VK_SHADER_CODE_TYPE_BINARY_EXT specifies shader code in an opaque, implementation-defined binary format
    ///     specific to the physical device.
    /// </summary>
    VK_SHADER_CODE_TYPE_BINARY_EXT = 0,

    /// <summary>VK_SHADER_CODE_TYPE_SPIRV_EXT specifies shader code in SPIR-V format.</summary>
    VK_SHADER_CODE_TYPE_SPIRV_EXT = 1
}