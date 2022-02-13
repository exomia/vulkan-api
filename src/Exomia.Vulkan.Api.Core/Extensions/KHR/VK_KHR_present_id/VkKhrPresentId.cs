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
///     VK_KHR_present_id - device extension (nr. 295) - author 'KHR' [platform '' | contact 'Keith Packard @keithp']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_present_id.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_present_id.html</a>
/// </summary>
[VkRequires("VK_KHR_swapchain")]
public static class VkKhrPresentId
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_PRESENT_ID_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_PRESENT_ID_EXTENSION_NAME = "VK_KHR_present_id";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_PRESENT_ID_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_PRESENT_ID_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_PRESENT_ID_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u505f\u4552\u4553\u544e\u495f\u5f44\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}