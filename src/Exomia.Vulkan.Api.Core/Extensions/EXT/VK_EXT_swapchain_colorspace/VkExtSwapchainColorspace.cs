#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtSwapchainColorspace;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_swapchain_colorspace - instance extension (nr. 105) - author 'GOOGLE' [platform '' | contact 'Courtney
///     Goeltzenleuchter @courtney-g']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_swapchain_colorspace.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_swapchain_colorspace.html</a>
/// </summary>
[VkDepends("VK_KHR_surface")]
[VkInstanceExt]
public static class VkExtSwapchainColorspace
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION = 5;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME = "VK_EXT_swapchain_colorspace";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u535f\u4157\u4350\u4148\u4e49\u435f\u4c4f\u524f\u535f\u4150\u4543\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}