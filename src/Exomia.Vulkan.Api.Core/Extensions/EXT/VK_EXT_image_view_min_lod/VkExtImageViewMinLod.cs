#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtImageViewMinLod;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_image_view_min_lod - device extension (nr. 392) - author 'EXT' [platform '' | contact 'Joshua Ashton
///     @Joshua-Ashton']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_view_min_lod.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_view_min_lod.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkDeviceExt]
public static class VkExtImageViewMinLod
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_IMAGE_VIEW_MIN_LOD_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_IMAGE_VIEW_MIN_LOD_EXTENSION_NAME = "VK_EXT_image_view_min_lod";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_IMAGE_VIEW_MIN_LOD_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_IMAGE_VIEW_MIN_LOD_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_IMAGE_VIEW_MIN_LOD_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u495f\u414d\u4547\u565f\u4549\u5f57\u494d\u5f4e\u4f4c\u5f44\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}