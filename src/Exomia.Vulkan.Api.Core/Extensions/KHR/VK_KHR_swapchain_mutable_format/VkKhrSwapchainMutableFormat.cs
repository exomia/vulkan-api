#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrSwapchainMutableFormat;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_swapchain_mutable_format - device extension (nr. 201) - author 'KHR' [platform '' | contact 'Daniel Rakos
///     @drakos-amd']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_swapchain_mutable_format.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_swapchain_mutable_format.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_swapchain+(VK_KHR_maintenance2,VK_VERSION_1_1)+(VK_KHR_image_format_list,VK_VERSION_1_2)")]
[VkDeviceExt]
public static class VkKhrSwapchainMutableFormat
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME = "VK_KHR_swapchain_mutable_format";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u535f\u4157\u4350\u4148\u4e49\u4d5f\u5455\u4241\u454c\u465f\u524f\u414d\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}