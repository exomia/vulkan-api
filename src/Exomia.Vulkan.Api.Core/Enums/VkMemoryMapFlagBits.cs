#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkMemoryMapFlagBits - Bitmask specifying additional parameters of a memory map -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryMapFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryMapFlagBits.html</a>
/// </summary>
[Flags]
public enum VkMemoryMapFlagBits
{
    /// <summary>
    ///     VK_MEMORY_MAP_PLACED_BIT_EXT requests that the implementation place the memory map at the virtual address
    ///     specified by the client via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryMapPlacedInfoEXT.html">VkMemoryMapPlacedInfoEXT</a>
    ///     ::pPlacedAddress, replacing any existing mapping at that address. This flag must not be used with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMapMemory.html">vkMapMemory</a> as
    ///     there is no way to specify the placement address.
    /// </summary>
    VK_MEMORY_MAP_PLACED_BIT_EXT = 0x1
}