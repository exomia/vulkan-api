#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhr16bitStorage;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_16bit_storage - device extension (nr. 84) - author 'KHR' [platform '' | contact 'Jan-Harald Fredriksen
///     @janharaldfredriksen-arm']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_16bit_storage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_16bit_storage.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2+VK_KHR_storage_buffer_storage_class")]
[VkDeviceExt]
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_16bit_storage.html#_deprecation_state")]
public static class VkKhr16bitStorage
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_16BIT_STORAGE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_16BIT_STORAGE_EXTENSION_NAME = "VK_KHR_16bit_storage";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_16BIT_STORAGE_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_16BIT_STORAGE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_16BIT_STORAGE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u315f\u4236\u5449\u535f\u4f54\u4152\u4547\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}