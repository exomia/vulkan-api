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
///     VkPipelineRobustnessCreateInfoEXT - Structure controlling the robustness of a newly created pipeline shader
///     stage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo,VkPipelineShaderStageCreateInfo,VkRayTracingPipelineCreateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo,VkPipelineShaderStageCreateInfo,VkRayTracingPipelineCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRobustnessCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     storageBuffers sets the behaviour of out of bounds accesses made to resources bound
    ///     as:VK_DESCRIPTOR_TYPE_STORAGE_BUFFERVK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFERVK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC
    /// </summary>
    public VkPipelineRobustnessBufferBehaviorEXT storageBuffers;

    /// <summary>
    ///     uniformBuffers describes the behaviour of out of bounds accesses made to resources bound
    ///     as:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFERVK_DESCRIPTOR_TYPE_UNIFORM_BUFFERVK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMICVK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK
    /// </summary>
    public VkPipelineRobustnessBufferBehaviorEXT uniformBuffers;

    /// <summary>vertexInputs describes the behaviour of out of bounds accesses made to vertex input attributes</summary>
    public VkPipelineRobustnessBufferBehaviorEXT vertexInputs;

    /// <summary>
    ///     images describes the behaviour of out of bounds accesses made to resources bound
    ///     as:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGEVK_DESCRIPTOR_TYPE_STORAGE_IMAGE
    /// </summary>
    public VkPipelineRobustnessImageBehaviorEXT images;
}