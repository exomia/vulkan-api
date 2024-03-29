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
///     VkDescriptorSetAllocateInfo - Structure specifying the allocation parameters for descriptor sets -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetAllocateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetAllocateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetAllocateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>descriptorPool is the pool which the sets will be allocated from.</summary>
    public VkDescriptorPool descriptorPool;

    /// <summary>descriptorSetCount determines the number of descriptor sets to be allocated from the pool.</summary>
    public uint descriptorSetCount;

    /// <summary>
    ///     pSetLayouts is a pointer to an array of descriptor set layouts, with each member specifying how the
    ///     corresponding descriptor set is allocated.
    /// </summary>
    public VkDescriptorSetLayout* pSetLayouts;
}