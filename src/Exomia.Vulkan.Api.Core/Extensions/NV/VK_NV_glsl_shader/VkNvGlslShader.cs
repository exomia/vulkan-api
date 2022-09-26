#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvGlslShader;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_glsl_shader - device extension (nr. 13) - author 'NV' [platform '' | contact 'Piers Daniell @pdaniell-nv']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_glsl_shader.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_glsl_shader.html </a>
/// </summary>
[Obsolete("deprecated by ", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_glsl_shader.html#_deprecation_state")]
public static class VkNvGlslShader
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_GLSL_SHADER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_GLSL_SHADER_EXTENSION_NAME = "VK_NV_glsl_shader";

    /// <summary> An UTF8 null terminated version of <see cref="VK_NV_GLSL_SHADER_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_GLSL_SHADER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_NV_GLSL_SHADER_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4c47\u4c53\u535f\u4148\u4544\u5f52\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}