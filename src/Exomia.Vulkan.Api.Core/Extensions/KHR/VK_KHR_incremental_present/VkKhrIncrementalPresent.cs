#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrIncrementalPresent;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_incremental_present - device extension (nr. 85) - author 'KHR' [platform '' | contact 'Ian Elliott
///     @ianelliottus']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_incremental_present.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_incremental_present.html</a>
/// </summary>
[VkDepends("VK_KHR_swapchain")]
[VkDeviceExt]
public static class VkKhrIncrementalPresent
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME = "VK_KHR_incremental_present";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u495f\u434e\u4552\u454d\u544e\u4c41\u505f\u4552\u4553\u544e\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}