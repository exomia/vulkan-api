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
///     VkPushDescriptorSetInfoKHR - Structure specifying a descriptor set push operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPushDescriptorSetInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPushDescriptorSetInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPushDescriptorSetInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stageFlags is a bitmask of VkShaderStageFlagBits specifying the shader stages that will use the descriptors.</summary>
    public VkShaderStageFlags stageFlags;

    /// <summary>
    ///     layout is a VkPipelineLayout object used to program the bindings. If the dynamicPipelineLayoutfeature is
    ///     enabled, layout can be VK_NULL_HANDLE and the layout must be specified by chaining
    ///     VkPipelineLayoutCreateInfostructure off the pNext
    /// </summary>
    public VkPipelineLayout layout;

    /// <summary>set is the set number of the descriptor set in the pipeline layout that will be updated.</summary>
    public uint set;

    /// <summary>descriptorWriteCount is the number of elements in the pDescriptorWrites array.</summary>
    public uint descriptorWriteCount;

    /// <summary>
    ///     pDescriptorWrites is a pointer to an array of VkWriteDescriptorSet structures describing the descriptors to be
    ///     updated.
    /// </summary>
    public VkWriteDescriptorSet* pDescriptorWrites;
}