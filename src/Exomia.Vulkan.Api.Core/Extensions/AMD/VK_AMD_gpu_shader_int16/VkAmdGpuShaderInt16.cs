#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_gpu_shader_int16 - device extension (nr. 133) - author 'AMD' [platform '' | contact 'Qun Lin @linqun']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_gpu_shader_int16.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_gpu_shader_int16.html</a>
/// </summary>
[Obsolete("deprecated by VK_KHR_shader_float16_int8", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_gpu_shader_int16.html#_deprecation_state")]
public static class VkAmdGpuShaderInt16
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_GPU_SHADER_INT16_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME = "VK_AMD_gpu_shader_int16";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME_UTF8_NT = "\u4b56\u415f\u444d\u475f\u5550\u535f\u4148\u4544\u5f52\u4e49\u3154\u5f36\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}