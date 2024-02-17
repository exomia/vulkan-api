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
///     VkMemoryUnmapFlagBitsKHR - Bitmask specifying additional parameters of a memory unmap -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryUnmapFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryUnmapFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkMemoryUnmapFlagBitsKHR
{
    /// <summary>
    ///     VK_MEMORY_UNMAP_RESERVE_BIT_EXT requests that virtual address range currently occupied by the memory map
    ///     remain reserved after the
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory2KHR.html">vkUnmapMemory2KHR</a>
    ///     call completes. Future system memory map operations or calls to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMapMemory.html">vkMapMemory</a> or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMapMemory2KHR.html">vkMapMemory2KHR</a>
    ///     will not return addresses in that range unless the range has since been unreserved by the client or the mapping is
    ///     explicitly placed in that range by calling
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMapMemory2KHR.html">vkMapMemory2KHR</a>
    ///     with VK_MEMORY_MAP_PLACED_BIT_EXT, or doing the system memory map equivalent. When VK_MEMORY_UNMAP_RESERVE_BIT_EXT
    ///     is set, the memory unmap operation may fail, in which case the memory object will remain host mapped and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory2KHR.html">vkUnmapMemory2KHR</a>
    ///     will return VK_ERROR_MEMORY_MAP_FAILED.
    /// </summary>
    VK_MEMORY_UNMAP_RESERVE_BIT_EXT = 0x1
}