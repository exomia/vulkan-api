#region License

// Copyright (c) 2018-2023, exomia
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
///     VkExternalMemoryAcquireUnmodifiedEXT - Structure specifying that external memory has remained unmodified since
///     releasing ownership -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryAcquireUnmodifiedEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryAcquireUnmodifiedEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkBufferMemoryBarrier,VkBufferMemoryBarrier2,VkImageMemoryBarrier,VkImageMemoryBarrier2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBufferMemoryBarrier,VkBufferMemoryBarrier2,VkImageMemoryBarrier,VkImageMemoryBarrier2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalMemoryAcquireUnmodifiedEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     acquireUnmodifiedMemory specifies, if VK_TRUE, that no range of VkDeviceMemory bound to the resource of the
    ///     memory barrier&#8217;s subresource range was modified at any time since the resource&#8217;s most recent release of
    ///     ownership to the queue family specified by the memory barrier&#8217;s srcQueueFamilyIndex. If VK_FALSE, it
    ///     specifies nothing.
    /// </summary>
    public VkBool32 acquireUnmodifiedMemory;
}