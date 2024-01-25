#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkImgRelaxedLineRasterization;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_IMG_relaxed_line_rasterization - device extension (nr. 111) - author 'IMG' [platform '' | contact 'James
///     Fitzpatrick @jamesfitzpatrick']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_IMG_relaxed_line_rasterization.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_IMG_relaxed_line_rasterization.html
///     </a>
/// </summary>
/// <remarks>
///     specialuse: glemulation
/// </remarks>
[VkDepends("(VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)")]
[VkSpecialuse("glemulation")]
[VkDeviceExt]
public static class VkImgRelaxedLineRasterization
{
    /// <summary> The spec version. </summary>
    public const uint VK_IMG_RELAXED_LINE_RASTERIZATION_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_IMG_RELAXED_LINE_RASTERIZATION_EXTENSION_NAME = "VK_IMG_relaxed_line_rasterization";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_IMG_RELAXED_LINE_RASTERIZATION_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_IMG_RELAXED_LINE_RASTERIZATION_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_IMG_RELAXED_LINE_RASTERIZATION_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u495f\u474d\u525f\u4c45\u5841\u4445\u4c5f\u4e49\u5f45\u4152\u5453\u5245\u5a49\u5441\u4f49\u5f4e\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}