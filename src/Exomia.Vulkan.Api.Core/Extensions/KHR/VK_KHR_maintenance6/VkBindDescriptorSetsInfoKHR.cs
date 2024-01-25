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
///     VkBindDescriptorSetsInfoKHR - Structure specifying a descriptor set binding operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindDescriptorSetsInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindDescriptorSetsInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindDescriptorSetsInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stageFlags is a bitmask of VkShaderStageFlagBits specifying the shader stages the descriptor sets will be
    ///     bound to.
    /// </summary>
    public VkShaderStageFlags stageFlags;

    /// <summary>
    ///     layout is a VkPipelineLayout object used to program the bindings. If the dynamicPipelineLayoutfeature is
    ///     enabled, layout can be VK_NULL_HANDLE and the layout must be specified by chaining the VkPipelineLayoutCreateInfo
    ///     structure off the pNext
    /// </summary>
    public VkPipelineLayout layout;

    /// <summary>firstSet is the set number of the first descriptor set to be bound.</summary>
    public uint firstSet;

    /// <summary>descriptorSetCount is the number of elements in the pDescriptorSets array.</summary>
    public uint descriptorSetCount;

    /// <summary>
    ///     pDescriptorSets is a pointer to an array of handles to VkDescriptorSet objects describing the descriptor sets
    ///     to bind to.
    /// </summary>
    public VkDescriptorSet* pDescriptorSets;

    /// <summary>dynamicOffsetCount is the number of dynamic offsets in the pDynamicOffsets array.</summary>
    public uint dynamicOffsetCount;

    /// <summary>pDynamicOffsets is a pointer to an array of uint32_t values specifying dynamic offsets.</summary>
    public uint* pDynamicOffsets;
}