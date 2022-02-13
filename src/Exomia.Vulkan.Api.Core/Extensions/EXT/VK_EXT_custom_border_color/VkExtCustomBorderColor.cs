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
///     VK_EXT_custom_border_color - device extension (nr. 288) - author 'EXT' [platform '' | contact 'Liam Middlebrook
///     @liam-middlebrook']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_custom_border_color.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_custom_border_color.html</a>
/// </summary>
/// <remarks>
///     specialuse: glemulation,d3demulation
/// </remarks>
[VkSpecialuse("glemulation,d3demulation")]
public static class VkExtCustomBorderColor
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION = 12;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME = "VK_EXT_custom_border_color";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u435f\u5355\u4f54\u5f4d\u4f42\u4452\u5245\u435f\u4c4f\u524f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}