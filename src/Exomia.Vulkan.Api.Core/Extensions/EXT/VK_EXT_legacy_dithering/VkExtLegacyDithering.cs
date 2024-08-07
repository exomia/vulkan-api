#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtLegacyDithering;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_legacy_dithering - device extension (nr. 466) - author 'EXT' [platform '' | contact 'Shahbaz Youssefi
///     @syoussefi']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_legacy_dithering.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_legacy_dithering.html</a>
/// </summary>
/// <remarks>
///     specialuse: glemulation
/// </remarks>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkSpecialuse("glemulation")]
[VkDeviceExt]
public static class VkExtLegacyDithering
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_LEGACY_DITHERING_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_LEGACY_DITHERING_EXTENSION_NAME = "VK_EXT_legacy_dithering";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_LEGACY_DITHERING_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_LEGACY_DITHERING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_LEGACY_DITHERING_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u4c5f\u4745\u4341\u5f59\u4944\u4854\u5245\u4e49\u5f47\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}