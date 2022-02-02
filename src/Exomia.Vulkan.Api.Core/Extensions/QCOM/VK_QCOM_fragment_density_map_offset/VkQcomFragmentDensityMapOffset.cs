#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkQcomFragmentDensityMapOffset;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_QCOM_fragment_density_map_offset - device extension (nr. 426) - author 'QCOM' [platform '' | contact 'Matthew
///     Netsch @mnetsch']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_fragment_density_map_offset.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_fragment_density_map_offset.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2,VK_EXT_fragment_density_map")]
public static class VkQcomFragmentDensityMapOffset
{
    /// <summary> The spec version. </summary>
    public const uint VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME = "VK_QCOM_fragment_density_map_offset";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u515f\u4f43\u5f4d\u5246\u4741\u454d\u544e\u445f\u4e45\u4953\u5954\u4d5f\u5041\u4f5f\u4646\u4553\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}