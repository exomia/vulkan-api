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
///     VK_KHR_driver_properties - device extension (nr. 197) - author 'KHR' [platform '' | contact 'Daniel Rakos
///     @drakos-amd']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_driver_properties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_driver_properties.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[Obsolete("promoted to VK_VERSION_1_2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_driver_properties.html#_deprecation_state")]
public static class VkKhrDriverProperties
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME = "VK_KHR_driver_properties";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u445f\u4952\u4556\u5f52\u5250\u504f\u5245\u4954\u5345\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     VK_MAX_DRIVER_NAME_SIZE - Maximum length of a physical device driver name string -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_NAME_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_NAME_SIZE.html</a>
    /// </summary>
    /// <remarks> VK_MAX_DRIVER_NAME_SIZE_KHR alias for VK_MAX_DRIVER_NAME_SIZE_KHR. </remarks>
    public const uint VK_MAX_DRIVER_NAME_SIZE_KHR = VK_MAX_DRIVER_NAME_SIZE;

    /// <summary>
    ///     VK_MAX_DRIVER_INFO_SIZE - Length of a physical device driver information string -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_INFO_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_INFO_SIZE.html</a>
    /// </summary>
    /// <remarks> VK_MAX_DRIVER_INFO_SIZE_KHR alias for VK_MAX_DRIVER_INFO_SIZE_KHR. </remarks>
    public const uint VK_MAX_DRIVER_INFO_SIZE_KHR = VK_MAX_DRIVER_INFO_SIZE;
}