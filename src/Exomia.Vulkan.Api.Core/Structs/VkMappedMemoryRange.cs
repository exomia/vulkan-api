#region License

// Copyright (c) 2018-2022, exomia
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
///     VkMappedMemoryRange - Structure specifying a mapped memory range -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMappedMemoryRange.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMappedMemoryRange.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMappedMemoryRange
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>memory is the memory object to which this range belongs.</summary>
    public VkDeviceMemory memory;

    /// <summary>offset is the zero-based byte offset from the beginning of the memory object.</summary>
    public VkDeviceSize offset;

    /// <summary>
    ///     size is either the size of range, or VK_WHOLE_SIZE to affect the range from offset to the end of the current
    ///     mapping of the allocation.
    /// </summary>
    public VkDeviceSize size;
}