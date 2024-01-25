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
///     VkSetDescriptorBufferOffsetsInfoEXT - Structure specifying descriptor buffer offsets to set in a command buffer -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSetDescriptorBufferOffsetsInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSetDescriptorBufferOffsetsInfoEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSetDescriptorBufferOffsetsInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SET_DESCRIPTOR_BUFFER_OFFSETS_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stageFlags is a bitmask of VkShaderStageFlagBits specifying the shader stages the descriptor sets will be
    ///     bound to
    /// </summary>
    public VkShaderStageFlags stageFlags;

    /// <summary>
    ///     layout is a VkPipelineLayout object used to program the bindings. If the dynamicPipelineLayoutfeature is
    ///     enabled, layout can be VK_NULL_HANDLE and the layout must be specified by chaining
    ///     VkPipelineLayoutCreateInfostructure off the pNext
    /// </summary>
    public VkPipelineLayout layout;

    /// <summary>firstSet is the number of the first set to be bound.</summary>
    public uint firstSet;

    /// <summary>setCount is the number of elements in the pBufferIndices and pOffsets arrays.</summary>
    public uint setCount;

    /// <summary>
    ///     pBufferIndices is a pointer to an array of indices into the descriptor buffer binding points set by
    ///     vkCmdBindDescriptorBuffersEXT.
    /// </summary>
    public uint* pBufferIndices;

    /// <summary>pOffsets is a pointer to an array of VkDeviceSize offsets to apply to the bound descriptor buffers.</summary>
    public VkDeviceSize* pOffsets;
}