﻿#region License

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
///     VK_GOOGLE_decorate_string - device extension (nr. 225) - author 'GOOGLE' [platform '' | contact 'Hai Nguyen
///     @chaoticbob']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_decorate_string.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_decorate_string.html</a>
/// </summary>
public static class VkGoogleDecorateString
{
    /// <summary> The spec version. </summary>
    public const uint VK_GOOGLE_DECORATE_STRING_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME = "VK_GOOGLE_decorate_string";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u475f\u4f4f\u4c47\u5f45\u4544\u4f43\u4152\u4554\u535f\u5254\u4e49\u5f47\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}