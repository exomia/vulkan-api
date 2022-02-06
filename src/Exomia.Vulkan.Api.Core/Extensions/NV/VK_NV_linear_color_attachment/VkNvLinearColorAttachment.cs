﻿#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvLinearColorAttachment;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_linear_color_attachment - device extension (nr. 431) - author 'NVIDIA' [platform '' | contact 'sourav parmar
///     @souravpNV']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_linear_color_attachment.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_linear_color_attachment.html</a>
/// </summary>
public static class VkNvLinearColorAttachment
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_LINEAR_COLOR_ATTACHMENT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_LINEAR_COLOR_ATTACHMENT_EXTENSION_NAME = "VK_NV_linear_color_attachment";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_LINEAR_COLOR_ATTACHMENT_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_LINEAR_COLOR_ATTACHMENT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_LINEAR_COLOR_ATTACHMENT_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u494c\u454e\u5241\u435f\u4c4f\u524f\u415f\u5454\u4341\u4d48\u4e45\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}