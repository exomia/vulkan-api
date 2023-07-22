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
///     VkGraphicsPipelineCreateInfo - Structure specifying parameters of a newly created graphics pipeline -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsPipelineCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
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
    ///     pipeline includes a mesh shader stage. It can be NULL if the pipeline is created with the
    ///     VK_DYNAMIC_STATE_VERTEX_INPUT_EXT dynamic state set.
    /// </summary>
    public VkPipelineVertexInputStateCreateInfo* pVertexInputState;

    /// <summary>
    ///     pInputAssemblyState is a pointer to a VkPipelineInputAssemblyStateCreateInfo structure which determines input
    ///     assembly behavior for vertex shading, as described in Drawing Commands. If the VK_EXT_extended_dynamic_state3
    ///     extension is enabled, it can be NULL if the pipeline is created with both
    ///     VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE, and VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY dynamic states set and
    ///     dynamicPrimitiveTopologyUnrestricted is VK_TRUE. It is ignored if the pipeline includes a mesh shader stage.
    /// </summary>
    public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;

    /// <summary>
    ///     pTessellationState is a pointer to a VkPipelineTessellationStateCreateInfo structure defining tessellation
    ///     state used by tessellation shaders. It can be NULL if the pipeline is created with the
    ///     VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT dynamic state set.
    /// </summary>
    public VkPipelineTessellationStateCreateInfo* pTessellationState;

    /// <summary>
    ///     pViewportState is a pointer to a VkPipelineViewportStateCreateInfo structure defining viewport state used when
    ///     rasterization is enabled. If the VK_EXT_extended_dynamic_state3 extension is enabled, it can be NULL if the
    ///     pipeline is created with both VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT, and VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT dynamic
    ///     states set.
    /// </summary>
    public VkPipelineViewportStateCreateInfo* pViewportState;

    /// <summary>
    ///     pRasterizationState is a pointer to a VkPipelineRasterizationStateCreateInfo structure defining rasterization
    ///     state. If the VK_EXT_extended_dynamic_state3 extension is enabled, it can be NULL if the pipeline is created with
    ///     all of VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT, VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE,
    ///     VK_DYNAMIC_STATE_POLYGON_MODE_EXT, VK_DYNAMIC_STATE_CULL_MODE, VK_DYNAMIC_STATE_FRONT_FACE,
    ///     VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE, VK_DYNAMIC_STATE_DEPTH_BIAS, and VK_DYNAMIC_STATE_LINE_WIDTHdynamic states set.
    /// </summary>
    public VkPipelineRasterizationStateCreateInfo* pRasterizationState;

    /// <summary>
    ///     pMultisampleState is a pointer to a VkPipelineMultisampleStateCreateInfo structure defining multisample state
    ///     used when rasterization is enabled. If the VK_EXT_extended_dynamic_state3 extension is enabled, it can be NULL if
    ///     the pipeline is created with all of VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT, VK_DYNAMIC_STATE_SAMPLE_MASK_EXT,
    ///     VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT, and VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT dynamic states set, in
    ///     which case VkPipelineMultisampleStateCreateInfo::sampleShadingEnable is assumed to be VK_FALSE.
    /// </summary>
    public VkPipelineMultisampleStateCreateInfo* pMultisampleState;

    /// <summary>
    ///     pDepthStencilState is a pointer to a VkPipelineDepthStencilStateCreateInfo structure defining depth/stencil
    ///     state used when rasterization is enabled for depth or stencil attachments accessed during rendering. If the
    ///     VK_EXT_extended_dynamic_state3 extension is enabled, it can be NULL if the pipeline is created with all of
    ///     VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE, VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE, VK_DYNAMIC_STATE_DEPTH_COMPARE_OP,
    ///     VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE, VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE, VK_DYNAMIC_STATE_STENCIL_OP, and
    ///     VK_DYNAMIC_STATE_DEPTH_BOUNDS dynamic states set.
    /// </summary>
    public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;

    /// <summary>
    ///     pColorBlendState is a pointer to a VkPipelineColorBlendStateCreateInfo structure defining color blend state
    ///     used when rasterization is enabled for any color attachments accessed during rendering. If the
    ///     VK_EXT_extended_dynamic_state3 extension is enabled, it can be NULL if the pipeline is created with all of
    ///     VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT, VK_DYNAMIC_STATE_LOGIC_OP_EXT, VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT,
    ///     VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT, VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT, and
    ///     VK_DYNAMIC_STATE_BLEND_CONSTANTS dynamic states set.
    /// </summary>
    public VkPipelineColorBlendStateCreateInfo* pColorBlendState;

    /// <summary>
    ///     pDynamicState is a pointer to a VkPipelineDynamicStateCreateInfo structure defining which properties of the
    ///     pipeline state object are dynamic and can be changed independently of the pipeline state. This can be NULL, which
    ///     means no state in the pipeline is considered dynamic.
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