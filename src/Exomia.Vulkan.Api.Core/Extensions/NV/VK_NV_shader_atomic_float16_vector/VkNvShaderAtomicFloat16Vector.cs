#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvShaderAtomicFloat16Vector;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_shader_atomic_float16_vector - device extension (nr. 564) - author 'NV' [platform '' | contact 'Jeff Bolz
///     @jeffbolznv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_shader_atomic_float16_vector.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_shader_atomic_float16_vector.html
///     </a>
/// </summary>
[VkDeviceExt]
public static class VkNvShaderAtomicFloat16Vector
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_EXTENSION_NAME = "VK_NV_shader_atomic_float16_vector";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4853\u4441\u5245\u415f\u4f54\u494d\u5f43\u4c46\u414f\u3154\u5f36\u4556\u5443\u524f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}