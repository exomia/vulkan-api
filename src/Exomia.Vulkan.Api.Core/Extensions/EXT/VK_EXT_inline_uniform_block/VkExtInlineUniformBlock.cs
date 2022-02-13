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
///     VK_EXT_inline_uniform_block - device extension (nr. 139) - author 'EXT' [platform '' | contact 'Daniel Rakos
///     @aqnuep']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_inline_uniform_block.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_inline_uniform_block.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2,VK_KHR_maintenance1")]
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_inline_uniform_block.html#_deprecation_state")]
public static class VkExtInlineUniformBlock
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME = "VK_EXT_inline_uniform_block";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u495f\u4c4e\u4e49\u5f45\u4e55\u4649\u524f\u5f4d\u4c42\u434f\u5f4b\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}