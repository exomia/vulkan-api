#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtMapMemoryPlaced;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_map_memory_placed - device extension (nr. 273) - author 'EXT' [platform '' | contact 'Faith Ekstrand
///     @gfxstrand']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_map_memory_placed.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_map_memory_placed.html</a>
/// </summary>
[VkDepends("VK_KHR_map_memory2")]
[VkDeviceExt]
public static class VkExtMapMemoryPlaced
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_MAP_MEMORY_PLACED_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_MAP_MEMORY_PLACED_EXTENSION_NAME = "VK_EXT_map_memory_placed";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_MAP_MEMORY_PLACED_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_MAP_MEMORY_PLACED_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_MAP_MEMORY_PLACED_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u4d5f\u5041\u4d5f\u4d45\u524f\u5f59\u4c50\u4341\u4445\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}