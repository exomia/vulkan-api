#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvDisplayStereo;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_display_stereo - instance extension (nr. 552) - author 'NV' [platform '' | contact 'Russell Chou
///     @russellcnv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_display_stereo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_display_stereo.html</a>
/// </summary>
[VkDepends("VK_KHR_display+VK_KHR_get_display_properties2")]
[VkInstanceExt]
public static class VkNvDisplayStereo
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_DISPLAY_STEREO_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_DISPLAY_STEREO_EXTENSION_NAME = "VK_NV_display_stereo";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_DISPLAY_STEREO_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_DISPLAY_STEREO_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_DISPLAY_STEREO_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4944\u5053\u414c\u5f59\u5453\u5245\u4f45\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}