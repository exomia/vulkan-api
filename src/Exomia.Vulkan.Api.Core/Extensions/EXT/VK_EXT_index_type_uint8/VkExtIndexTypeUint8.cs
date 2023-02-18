#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtIndexTypeUint8;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_index_type_uint8 - device extension (nr. 266) - author 'EXT' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_index_type_uint8.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_index_type_uint8.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
public static class VkExtIndexTypeUint8
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_INDEX_TYPE_UINT8_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME = "VK_EXT_index_type_uint8";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u495f\u444e\u5845\u545f\u5059\u5f45\u4955\u544e\u5f38\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}