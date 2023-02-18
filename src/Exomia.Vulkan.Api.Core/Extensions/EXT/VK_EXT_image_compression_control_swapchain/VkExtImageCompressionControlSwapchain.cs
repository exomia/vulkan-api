#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtImageCompressionControlSwapchain;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_image_compression_control_swapchain - device extension (nr. 438) - author 'EXT' [platform '' | contact
///     'Jan-Harald Fredriksen @janharaldfredriksen-arm']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_compression_control_swapchain.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_compression_control_swapchain.html
///     </a>
/// </summary>
[VkDepends("VK_EXT_image_compression_control")]
public static class VkExtImageCompressionControlSwapchain
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_EXTENSION_NAME = "VK_EXT_image_compression_control_swapchain";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u495f\u414d\u4547\u435f\u4d4f\u5250\u5345\u4953\u4e4f\u435f\u4e4f\u5254\u4c4f\u535f\u4157\u4350\u4148\u4e49\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}