#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvCornerSampledImage;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_corner_sampled_image - device extension (nr. 51) - author 'NV' [platform '' | contact 'Daniel Koch @dgkoch']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_corner_sampled_image.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_corner_sampled_image.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
[VkDeviceExt]
public static class VkNvCornerSampledImage
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME = "VK_NV_corner_sampled_image";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4f43\u4e52\u5245\u535f\u4d41\u4c50\u4445\u495f\u414d\u4547\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}