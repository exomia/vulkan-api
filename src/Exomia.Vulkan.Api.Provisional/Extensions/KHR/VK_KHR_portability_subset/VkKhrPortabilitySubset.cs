#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Provisional.VkKhrPortabilitySubset;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VK_KHR_portability_subset - device extension (nr. 164) - author 'KHR' [platform 'provisional' | contact 'Bill
///     Hollings @billhollings']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_portability_subset.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_portability_subset.html</a>
/// </summary>
/// <remarks>
///     provisional: true
/// </remarks>
[VkDepends("VK_KHR_get_physical_device_properties2")]
[VkProvisional("true")]
[VkDeviceExt]
public static class VkKhrPortabilitySubset
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME = "VK_KHR_portability_subset";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u505f\u524f\u4154\u4942\u494c\u5954\u535f\u4255\u4553\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}