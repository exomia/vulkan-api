#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvFragmentShaderBarycentric;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_fragment_shader_barycentric - device extension (nr. 204) - author 'NV' [platform '' | contact 'Pat Brown
///     @nvpbrown']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_fragment_shader_barycentric.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_fragment_shader_barycentric.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkDeviceExt]
[Obsolete(
    "promoted to VK_KHR_fragment_shader_barycentric", false,
    UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_fragment_shader_barycentric.html#_deprecation_state")]
public static class VkNvFragmentShaderBarycentric
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME = "VK_NV_fragment_shader_barycentric";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u5246\u4741\u454d\u544e\u535f\u4148\u4544\u5f52\u4142\u5952\u4543\u544e\u4952\u5f43\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}