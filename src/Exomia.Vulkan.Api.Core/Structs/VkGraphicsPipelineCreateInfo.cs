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
///     VkGraphicsPipelineCreateInfo - Structure specifying parameters of a newly created graphics pipeline -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsPipelineCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkPipelineCreateFlagBits specifying how the pipeline will be generated.</summary>
    public VkPipelineCreateFlags flags;

    /// <summary>stageCount is the number of entries in the pStages array.</summary>
    public uint stageCount;

    /// <summary>
    ///     pStages is a pointer to an array of stageCountVkPipelineShaderStageCreateInfo structures describing the set of
    ///     the shader stages to be included in the graphics pipeline.
    /// </summary>
    public VkPipelineShaderStageCreateInfo* pStages;

    /// <summary>
    ///     pVertexInputState is a pointer to a VkPipelineVertexInputStateCreateInfo structure. It is ignored if the
    ///     pipeline includes a mesh shader stage. It is ignored if the pipeline is created with the
    ///     VK_DYNAMIC_STATE_VERTEX_INPUT_EXT dynamic state set.
    /// </summary>
    public VkPipelineVertexInputStateCreateInfo* pVertexInputState;

    /// <summary>
    ///     pInputAssemblyState is a pointer to a VkPipelineInputAssemblyStateCreateInfo structure which determines input
    ///     assembly behavior, as described in Drawing Commands. It is ignored if the pipeline includes a mesh shader stage.
    /// </summary>
    public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;

    /// <summary>
    ///     pTessellationState is a pointer to a VkPipelineTessellationStateCreateInfo structure, and is ignored if the
    ///     pipeline does not include a tessellation control shader stage and tessellation evaluation shader stage.
    /// </summary>
    public VkPipelineTessellationStateCreateInfo* pTessellationState;

    /// <summary>
    ///     pViewportState is a pointer to a VkPipelineViewportStateCreateInfo structure, and is ignored if the pipeline
    ///     has rasterization disabled.
    /// </summary>
    public VkPipelineViewportStateCreateInfo* pViewportState;

    /// <summary>pRasterizationState is a pointer to a VkPipelineRasterizationStateCreateInfo structure.</summary>
    public VkPipelineRasterizationStateCreateInfo* pRasterizationState;

    /// <summary>
    ///     pMultisampleState is a pointer to a VkPipelineMultisampleStateCreateInfo structure, and is ignored if the
    ///     pipeline has rasterization disabled.
    /// </summary>
    public VkPipelineMultisampleStateCreateInfo* pMultisampleState;

    /// <summary>
    ///     pDepthStencilState is a pointer to a VkPipelineDepthStencilStateCreateInfo structure, and is ignored if the
    ///     pipeline has rasterization disabled or if no depth/stencil attachment is used.
    /// </summary>
    public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;

    /// <summary>
    ///     pColorBlendState is a pointer to a VkPipelineColorBlendStateCreateInfo structure, and is ignored if the
    ///     pipeline has rasterization disabled or if no color attachments are used.
    /// </summary>
    public VkPipelineColorBlendStateCreateInfo* pColorBlendState;

    /// <summary>
    ///     pDynamicState is a pointer to a VkPipelineDynamicStateCreateInfo structure, and is used to indicate which
    ///     properties of the pipeline state object are dynamic and can be changed independently of the pipeline state. This
    ///     can be NULL, which means no state in the pipeline is considered dynamic.
    /// </summary>
    public VkPipelineDynamicStateCreateInfo* pDynamicState;

    /// <summary>
    ///     layout is the description of binding locations used by both the pipeline and descriptor sets used with the
    ///     pipeline.
    /// </summary>
    public VkPipelineLayout layout;

    /// <summary>
    ///     renderPass is a handle to a render pass object describing the environment in which the pipeline will be used.
    ///     The pipeline must only be used with a render pass instance compatible with the one provided. See Render Pass
    ///     Compatibility for more information.
    /// </summary>
    public VkRenderPass renderPass;

    /// <summary>subpass is the index of the subpass in the render pass where this pipeline will be used.</summary>
    public uint subpass;

    /// <summary>basePipelineHandle is a pipeline to derive from.</summary>
    public VkPipeline basePipelineHandle;

    /// <summary>basePipelineIndex is an index into the pCreateInfosparameter to use as a pipeline to derive from.</summary>
    public int basePipelineIndex;
}