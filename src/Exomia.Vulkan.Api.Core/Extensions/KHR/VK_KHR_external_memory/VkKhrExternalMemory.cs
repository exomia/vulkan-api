#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrExternalMemory;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_external_memory - device extension (nr. 73) - author 'KHR' [platform '' | contact 'James Jones @cubanismo']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory.html</a>
/// </summary>
[VkDepends("VK_KHR_external_memory_capabilities,VK_VERSION_1_1")]
[VkDeviceExt]
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory.html#_deprecation_state")]
public static class VkKhrExternalMemory
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME = "VK_KHR_external_memory";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u455f\u5458\u5245\u414e\u5f4c\u454d\u4f4d\u5952\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     VK_QUEUE_FAMILY_EXTERNAL - External queue family index sentinel -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_EXTERNAL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_EXTERNAL.html</a>
    /// </summary>
    /// <remarks> VK_QUEUE_FAMILY_EXTERNAL_KHR alias for VK_QUEUE_FAMILY_EXTERNAL_KHR. </remarks>
    public const uint VK_QUEUE_FAMILY_EXTERNAL_KHR = VK_QUEUE_FAMILY_EXTERNAL;
}