#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrZeroInitializeWorkgroupMemory;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_zero_initialize_workgroup_memory - device extension (nr. 326) - author 'KHR' [platform '' | contact 'Alan Baker @alan-baker']
///     <br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_zero_initialize_workgroup_memory.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_zero_initialize_workgroup_memory.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_zero_initialize_workgroup_memory.html#_deprecation_state")]
public static class VkKhrZeroInitializeWorkgroupMemory
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME = "VK_KHR_zero_initialize_workgroup_memory";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u5a5f\u5245\u5f4f\u4e49\u5449\u4149\u494c\u455a\u575f\u524f\u474b\u4f52\u5055\u4d5f\u4d45\u524f\u5f59\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}