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
///     VkMemoryUnmapInfoKHR - Structure containing parameters of a memory unmap operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryUnmapInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryUnmapInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryUnmapInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkMemoryUnmapFlagBitsKHR specifying additional parameters of the memory map operation.</summary>
    public VkMemoryUnmapFlagsKHR flags;

    /// <summary>memory is the VkDeviceMemory object to be unmapped.</summary>
    public VkDeviceMemory memory;
}