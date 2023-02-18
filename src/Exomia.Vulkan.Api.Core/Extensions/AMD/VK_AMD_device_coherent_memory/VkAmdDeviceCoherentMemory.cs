#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkAmdDeviceCoherentMemory;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_device_coherent_memory - device extension (nr. 230) - author 'AMD' [platform '' | contact 'Tobias Hector
///     @tobski']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_device_coherent_memory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_device_coherent_memory.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
public static class VkAmdDeviceCoherentMemory
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME = "VK_AMD_device_coherent_memory";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u444d\u445f\u5645\u4349\u5f45\u4f43\u4548\u4552\u544e\u4d5f\u4d45\u524f\u5f59\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}