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
///     VkMemoryMapInfoKHR - Structure containing parameters of a memory map operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryMapInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryMapInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryMapInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkMemoryMapFlagBits specifying additional parameters of the memory map operation.</summary>
    public VkMemoryMapFlags flags;

    /// <summary>memory is the VkDeviceMemory object to be mapped.</summary>
    public VkDeviceMemory memory;

    /// <summary>offset is a zero-based byte offset from the beginning of the memory object.</summary>
    public VkDeviceSize offset;

    /// <summary>size is the size of the memory range to map, or VK_WHOLE_SIZE to map from offset to the end of the allocation.</summary>
    public VkDeviceSize size;
}