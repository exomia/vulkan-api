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
///     VkDedicatedAllocationMemoryAllocateInfoNV - Specify a dedicated memory allocation resource -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDedicatedAllocationMemoryAllocateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDedicatedAllocationMemoryAllocateInfoNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkMemoryAllocateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkMemoryAllocateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>image is VK_NULL_HANDLE or a handle of an image which this memory will be bound to.</summary>
    public VkImage image;

    /// <summary>buffer is VK_NULL_HANDLE or a handle of a buffer which this memory will be bound to.</summary>
    public VkBuffer buffer;
}