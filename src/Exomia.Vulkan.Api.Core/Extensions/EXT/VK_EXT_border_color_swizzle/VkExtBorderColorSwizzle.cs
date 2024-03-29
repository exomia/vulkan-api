#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtBorderColorSwizzle;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_border_color_swizzle - device extension (nr. 412) - author 'EXT' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_border_color_swizzle.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_border_color_swizzle.html</a>
/// </summary>
/// <remarks>
///     specialuse: glemulation,d3demulation
/// </remarks>
[VkDepends("VK_EXT_custom_border_color")]
[VkSpecialuse("glemulation,d3demulation")]
[VkDeviceExt]
public static class VkExtBorderColorSwizzle
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_BORDER_COLOR_SWIZZLE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME = "VK_EXT_border_color_swizzle";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u425f\u524f\u4544\u5f52\u4f43\u4f4c\u5f52\u5753\u5a49\u4c5a\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}