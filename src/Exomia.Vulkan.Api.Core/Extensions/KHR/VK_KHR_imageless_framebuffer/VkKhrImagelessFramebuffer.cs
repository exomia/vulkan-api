#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrImagelessFramebuffer;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_imageless_framebuffer - device extension (nr. 109) - author 'KHR' [platform '' | contact 'Tobias Hector
///     @tobias']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_imageless_framebuffer.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_imageless_framebuffer.html</a>
/// </summary>
[VkRequires("VK_KHR_maintenance2,VK_KHR_image_format_list")]
[Obsolete("promoted to VK_VERSION_1_2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_imageless_framebuffer.html#_deprecation_state")]
public static class VkKhrImagelessFramebuffer
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME = "VK_KHR_imageless_framebuffer";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u495f\u414d\u4547\u454c\u5353\u465f\u4152\u454d\u5542\u4646\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}