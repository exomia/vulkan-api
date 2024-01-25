#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtLoadStoreOpNone;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_load_store_op_none - device extension (nr. 401) - author 'EXT' [platform '' | contact 'Shahbaz Youssefi
///     @syoussefi']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_load_store_op_none.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_load_store_op_none.html</a>
/// </summary>
[VkDeviceExt]
[Obsolete("promoted to VK_KHR_load_store_op_none", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_load_store_op_none.html#_deprecation_state")]
public static class VkExtLoadStoreOpNone
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_LOAD_STORE_OP_NONE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME = "VK_EXT_load_store_op_none";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u4c5f\u414f\u5f44\u5453\u524f\u5f45\u504f\u4e5f\u4e4f\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}