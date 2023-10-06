#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkImgFilterCubic;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_IMG_filter_cubic - device extension (nr. 16) - author 'IMG' [platform '' | contact 'Tobias Hector @tobski']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_IMG_filter_cubic.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_IMG_filter_cubic.html</a>
/// </summary>
[VkDeviceExt]
public static class VkImgFilterCubic
{
    /// <summary> The spec version. </summary>
    public const uint VK_IMG_FILTER_CUBIC_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_IMG_FILTER_CUBIC_EXTENSION_NAME = "VK_IMG_filter_cubic";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_IMG_FILTER_CUBIC_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_IMG_FILTER_CUBIC_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_IMG_FILTER_CUBIC_EXTENSION_NAME_UTF8_NT = "\u4b56\u495f\u474d\u465f\u4c49\u4554\u5f52\u5543\u4942\u5f43\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}