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
///     VkDescriptorPoolCreateInfo - Structure specifying parameters of a newly created descriptor pool -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolCreateInfo.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolCreateInfo.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorPoolCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> flags is a bitmask of VkDescriptorPoolCreateFlagBitsspecifying certain supported operations on the pool. </summary>
    public VkDescriptorPoolCreateFlags flags;

    /// <summary> maxSets is the maximum number of descriptor sets that can be allocated from the pool. </summary>
    public uint maxSets;

    /// <summary> poolSizeCount is the number of elements in pPoolSizes. </summary>
    public uint poolSizeCount;

    /// <summary> pPoolSizes is a pointer to an array of VkDescriptorPoolSizestructures, each containing a descriptor type and number of descriptors of that type to be allocated in the pool. </summary>
    public VkDescriptorPoolSize* pPoolSizes;
}