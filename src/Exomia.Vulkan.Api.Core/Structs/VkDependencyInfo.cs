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
///     VkDependencyInfo - Structure specifying dependency information for a synchronization command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDependencyInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDependencyInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDependencyInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEPENDENCY_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     dependencyFlags is a bitmask of VkDependencyFlagBitsspecifying how execution and memory dependencies are
    ///     formed.
    /// </summary>
    public VkDependencyFlags dependencyFlags;

    /// <summary>memoryBarrierCount is the length of the pMemoryBarriersarray.</summary>
    public uint memoryBarrierCount;

    /// <summary>
    ///     pMemoryBarriers is a pointer to an array of VkMemoryBarrier2structures defining memory dependencies between
    ///     any memory accesses.
    /// </summary>
    public VkMemoryBarrier2* pMemoryBarriers;

    /// <summary>bufferMemoryBarrierCount is the length of the pBufferMemoryBarriers array.</summary>
    public uint bufferMemoryBarrierCount;

    /// <summary>
    ///     pBufferMemoryBarriers is a pointer to an array of VkBufferMemoryBarrier2 structures defining memory
    ///     dependencies between buffer ranges.
    /// </summary>
    public VkBufferMemoryBarrier2* pBufferMemoryBarriers;

    /// <summary>imageMemoryBarrierCount is the length of the pImageMemoryBarriers array.</summary>
    public uint imageMemoryBarrierCount;

    /// <summary>
    ///     pImageMemoryBarriers is a pointer to an array of VkImageMemoryBarrier2 structures defining memory dependencies
    ///     between image subresources.
    /// </summary>
    public VkImageMemoryBarrier2* pImageMemoryBarriers;
}