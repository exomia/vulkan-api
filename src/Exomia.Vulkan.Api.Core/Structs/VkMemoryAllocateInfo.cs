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
///     VkMemoryAllocateInfo - Structure containing parameters of a memory allocation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryAllocateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryAllocateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryAllocateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>allocationSize is the size of the allocation in bytes.</summary>
    public VkDeviceSize allocationSize;

    /// <summary>
    ///     memoryTypeIndex is an index identifying a memory type from the memoryTypes array of the
    ///     VkPhysicalDeviceMemoryPropertiesstructure.
    /// </summary>
    public uint memoryTypeIndex;
}