#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkAmdShaderExplicitVertexParameter;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_shader_explicit_vertex_parameter - device extension (nr. 22) - author 'AMD' [platform '' | contact 'Qun Lin
///     @linqun']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_shader_explicit_vertex_parameter.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_shader_explicit_vertex_parameter.html
///     </a>
/// </summary>
[VkDeviceExt]
public static class VkAmdShaderExplicitVertexParameter
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME = "VK_AMD_shader_explicit_vertex_parameter";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u444d\u535f\u4148\u4544\u5f52\u5845\u4c50\u4349\u5449\u565f\u5245\u4554\u5f58\u4150\u4152\u454d\u4554\u5f52\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}