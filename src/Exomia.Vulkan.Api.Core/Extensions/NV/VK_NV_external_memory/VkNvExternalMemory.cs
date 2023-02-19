#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvExternalMemory;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_external_memory - device extension (nr. 57) - author 'NV' [platform '' | contact 'James Jones @cubanismo']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory.html</a>
/// </summary>
[VkDepends("VK_NV_external_memory_capabilities")]
[Obsolete("deprecated by VK_KHR_external_memory", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory.html#_deprecation_state")]
public static class VkNvExternalMemory
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_EXTERNAL_MEMORY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME = "VK_NV_external_memory";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u5845\u4554\u4e52\u4c41\u4d5f\u4d45\u524f\u5f59\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}