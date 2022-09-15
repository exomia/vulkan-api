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
///     VkDynamicState - Indicate which dynamic state is taken from dynamic state commands -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDynamicState.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDynamicState.html</a>
/// </summary>
public enum VkDynamicState
{
    /// <summary>
    ///     VK_DYNAMIC_STATE_VIEWPORT specifies that the pViewportsstate in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">
    ///         VkPipelineViewportStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewport.html">vkCmdSetViewport</a>
    ///     before any drawing commands. The number of viewports used by a pipeline is still specified by the viewportCount
    ///     member of
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">
    ///         VkPipelineViewportStateCreateInfo
    ///     </a>
    ///     .
    /// </summary>
    VK_DYNAMIC_STATE_VIEWPORT = 0,

    /// <summary>
    ///     VK_DYNAMIC_STATE_SCISSOR specifies that the pScissors state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">
    ///         VkPipelineViewportStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissor.html">vkCmdSetScissor</a>
    ///     before any drawing commands. The number of scissor rectangles used by a pipeline is still specified by the
    ///     scissorCount member of
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">
    ///         VkPipelineViewportStateCreateInfo
    ///     </a>
    ///     .
    /// </summary>
    VK_DYNAMIC_STATE_SCISSOR = 1,

    /// <summary>
    ///     VK_DYNAMIC_STATE_LINE_WIDTH specifies that the lineWidthstate in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineWidth.html">vkCmdSetLineWidth</a>
    ///     before any drawing commands that generate line primitives for the rasterizer.
    /// </summary>
    VK_DYNAMIC_STATE_LINE_WIDTH = 2,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_BIAS specifies that the depthBiasConstantFactor, depthBiasClamp and depthBiasSlopeFactor
    ///     states in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and mustbe set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBias.html">vkCmdSetDepthBias</a>
    ///     before any draws are performed with depthBiasEnable in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     set to VK_TRUE.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_BIAS = 3,

    /// <summary>
    ///     VK_DYNAMIC_STATE_BLEND_CONSTANTS specifies that the blendConstants state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendStateCreateInfo.html">
    ///         VkPipelineColorBlendStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetBlendConstants.html">vkCmdSetBlendConstants</a>
    ///     before any draws are performed with a pipeline state with VkPipelineColorBlendAttachmentState member blendEnable
    ///     set to VK_TRUE and any of the blend functions using a constant blend color.
    /// </summary>
    VK_DYNAMIC_STATE_BLEND_CONSTANTS = 4,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_BOUNDS specifies that the minDepthBounds and maxDepthBounds states of
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBounds.html">vkCmdSetDepthBounds</a>
    ///     before any draws are performed with a pipeline state with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     member depthBoundsTestEnable set to VK_TRUE.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_BOUNDS = 5,

    /// <summary>
    ///     VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK specifies that the compareMask state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     for both front and back will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilCompareMask.html">vkCmdSetStencilCompareMask</a>
    ///     before any draws are performed with a pipeline state with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     member stencilTestEnable set to VK_TRUE
    /// </summary>
    VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK = 6,

    /// <summary>
    ///     VK_DYNAMIC_STATE_STENCIL_WRITE_MASK specifies that the writeMask state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     for both front and back will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilWriteMask.html">vkCmdSetStencilWriteMask</a>
    ///     before any draws are performed with a pipeline state with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     member stencilTestEnable set to VK_TRUE
    /// </summary>
    VK_DYNAMIC_STATE_STENCIL_WRITE_MASK = 7,

    /// <summary>
    ///     VK_DYNAMIC_STATE_STENCIL_REFERENCE specifies that the reference state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     for both front and back will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilReference.html">vkCmdSetStencilReference</a>
    ///     before any draws are performed with a pipeline state with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     member stencilTestEnable set to VK_TRUE
    /// </summary>
    VK_DYNAMIC_STATE_STENCIL_REFERENCE = 8,

    /// <summary>
    ///     VK_DYNAMIC_STATE_CULL_MODE specifies that the cullMode state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullMode.html">vkCmdSetCullMode</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_CULL_MODE = 1000267000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_FRONT_FACE specifies that the frontFacestate in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFace.html">vkCmdSetFrontFace</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_FRONT_FACE = 1000267001,

    /// <summary>
    ///     VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY specifies that the topology state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineInputAssemblyStateCreateInfo.html">
    ///         VkPipelineInputAssemblyStateCreateInfo
    ///     </a>
    ///     only specifies the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-primitive-topology-class">
    ///         topology
    ///         class
    ///     </a>
    ///     , and the specific topology order and adjacency must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopology.html">vkCmdSetPrimitiveTopology</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY = 1000267002,

    /// <summary>
    ///     VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT specifies that the viewportCount and pViewports state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">
    ///         VkPipelineViewportStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCount.html">vkCmdSetViewportWithCount</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT = 1000267003,

    /// <summary>
    ///     VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT specifies that the scissorCount and pScissors state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">
    ///         VkPipelineViewportStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCount.html">vkCmdSetScissorWithCount</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT = 1000267004,

    /// <summary>
    ///     VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE specifies that the stride state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDescription.html">
    ///         VkVertexInputBindingDescription
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2.html">vkCmdBindVertexBuffers2</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE = 1000267005,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE specifies that the depthTestEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnable.html">vkCmdSetDepthTestEnable</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE = 1000267006,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE specifies that the depthWriteEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnable.html">vkCmdSetDepthWriteEnable</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE = 1000267007,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_COMPARE_OP specifies that the depthCompareOp state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOp.html">vkCmdSetDepthCompareOp</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_COMPARE_OP = 1000267008,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE specifies that the depthBoundsTestEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnable.html">vkCmdSetDepthBoundsTestEnable</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE = 1000267009,

    /// <summary>
    ///     VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE specifies that the stencilTestEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnable.html">vkCmdSetStencilTestEnable</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE = 1000267010,

    /// <summary>
    ///     VK_DYNAMIC_STATE_STENCIL_OP specifies that the failOp, passOp, depthFailOp, and compareOp states in
    ///     VkPipelineDepthStencilStateCreateInfo for both front and back will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOp.html">vkCmdSetStencilOp</a>
    ///     before any draws are performed with a pipeline state with VkPipelineDepthStencilStateCreateInfo member
    ///     stencilTestEnable set to VK_TRUE
    /// </summary>
    VK_DYNAMIC_STATE_STENCIL_OP = 1000267011,

    /// <summary>
    ///     VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE specifies that the rasterizerDiscardEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and mustbe set dynamically with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnable.html">
    ///         vkCmdSetRasterizerDiscardEnable
    ///     </a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE = 1000377001,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE specifies that the depthBiasEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and mustbe set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnable.html">vkCmdSetDepthBiasEnable</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE = 1000377002,

    /// <summary>
    ///     VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE specifies that the primitiveRestartEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineInputAssemblyStateCreateInfo.html">
    ///         VkPipelineInputAssemblyStateCreateInfo
    ///     </a>
    ///     will be ignored and mustbe set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnable.html">vkCmdSetPrimitiveRestartEnable</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE = 1000377004,

    /// <summary>
    ///     VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV specifies that the pViewportWScalings state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportWScalingStateCreateInfoNV.html">
    ///         VkPipelineViewportWScalingStateCreateInfoNV
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWScalingNV.html">vkCmdSetViewportWScalingNV</a>
    ///     before any draws are performed with a pipeline state with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportWScalingStateCreateInfoNV.html">
    ///         VkPipelineViewportWScalingStateCreateInfoNV
    ///     </a>
    ///     member viewportScalingEnable set to VK_TRUE
    /// </summary>
    VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV = 1000087000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT specifies that the pDiscardRectangles state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDiscardRectangleStateCreateInfoEXT.html">
    ///         VkPipelineDiscardRectangleStateCreateInfoEXT
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDiscardRectangleEXT.html">vkCmdSetDiscardRectangleEXT</a>
    ///     before any draw or clear commands. The
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDiscardRectangleModeEXT.html">VkDiscardRectangleModeEXT</a>
    ///     and the number of active discard rectangles is still specified by the discardRectangleMode and
    ///     discardRectangleCount members of
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDiscardRectangleStateCreateInfoEXT.html">
    ///         VkPipelineDiscardRectangleStateCreateInfoEXT
    ///     </a>
    ///     .
    /// </summary>
    VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT = 1000099000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT specifies that the sampleLocationsInfo state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineSampleLocationsStateCreateInfoEXT.html">
    ///         VkPipelineSampleLocationsStateCreateInfoEXT
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleLocationsEXT.html">vkCmdSetSampleLocationsEXT</a>
    ///     before any draw or clear commands. Enabling custom sample locations is still indicated by the sampleLocationsEnable
    ///     member of
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineSampleLocationsStateCreateInfoEXT.html">
    ///         VkPipelineSampleLocationsStateCreateInfoEXT
    ///     </a>
    ///     .
    /// </summary>
    VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT = 1000143000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR specifies that the default stack size computation for the
    ///     pipeline will be ignored and must be set dynamically with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRayTracingPipelineStackSizeKHR.html">
    ///         vkCmdSetRayTracingPipelineStackSizeKHR
    ///     </a>
    ///     before any ray tracing calls are performed.
    /// </summary>
    VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR = 1000347000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV specifies that the pShadingRatePalettes state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportShadingRateImageStateCreateInfoNV.html">
    ///         VkPipelineViewportShadingRateImageStateCreateInfoNV
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportShadingRatePaletteNV.html">
    ///         vkCmdSetViewportShadingRatePaletteNV
    ///     </a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV = 1000164004,

    /// <summary>
    ///     VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV specifies that the coarse sample order state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportCoarseSampleOrderStateCreateInfoNV.html">
    ///         VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoarseSampleOrderNV.html">vkCmdSetCoarseSampleOrderNV</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV = 1000164006,

    /// <summary>
    ///     VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV specifies that the pExclusiveScissors state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportExclusiveScissorStateCreateInfoNV.html">
    ///         VkPipelineViewportExclusiveScissorStateCreateInfoNV
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetExclusiveScissorNV.html">vkCmdSetExclusiveScissorNV</a>
    ///     before any drawing commands. The number of exclusive scissor rectangles used by a pipeline is still specified by
    ///     the exclusiveScissorCount member of
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportExclusiveScissorStateCreateInfoNV.html">
    ///         VkPipelineViewportExclusiveScissorStateCreateInfoNV
    ///     </a>
    ///     .
    /// </summary>
    VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV = 1000205001,

    /// <summary>
    ///     VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR specifies that state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineFragmentShadingRateStateCreateInfoKHR.html">
    ///         VkPipelineFragmentShadingRateStateCreateInfoKHR
    ///     </a>
    ///     and
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineFragmentShadingRateEnumStateCreateInfoNV.html">
    ///         VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateKHR.html">vkCmdSetFragmentShadingRateKHR</a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateEnumNV.html">
    ///         vkCmdSetFragmentShadingRateEnumNV
    ///     </a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR = 1000226000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_LINE_STIPPLE_EXT specifies that the lineStippleFactor and lineStipplePattern state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationLineStateCreateInfoEXT.html">
    ///         VkPipelineRasterizationLineStateCreateInfoEXT
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleEXT.html">vkCmdSetLineStippleEXT</a>
    ///     before any draws are performed with a pipeline state with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationLineStateCreateInfoEXT.html">
    ///         VkPipelineRasterizationLineStateCreateInfoEXT
    ///     </a>
    ///     member stippledLineEnable set to VK_TRUE.
    /// </summary>
    VK_DYNAMIC_STATE_LINE_STIPPLE_EXT = 1000259000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_VERTEX_INPUT_EXT specifies that the pVertexInputState state will be ignored and must be set
    ///     dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetVertexInputEXT.html">vkCmdSetVertexInputEXT</a>
    ///     before any drawing commands
    /// </summary>
    VK_DYNAMIC_STATE_VERTEX_INPUT_EXT = 1000352000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT specifies that the patchControlPoints state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineTessellationStateCreateInfo.html">
    ///         VkPipelineTessellationStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPatchControlPointsEXT.html">vkCmdSetPatchControlPointsEXT</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT = 1000377000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_LOGIC_OP_EXT specifies that the logicOpstate in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendStateCreateInfo.html">
    ///         VkPipelineColorBlendStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEXT.html">vkCmdSetLogicOpEXT</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_LOGIC_OP_EXT = 1000377003,

    /// <summary>
    ///     VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT specifies that the pColorWriteEnables state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorWriteCreateInfoEXT.html">
    ///         VkPipelineColorWriteCreateInfoEXT
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorWriteEnableEXT.html">vkCmdSetColorWriteEnableEXT</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT = 1000381000,

    /// <summary>
    ///     VK_DYNAMIC_STATE_CULL_MODE specifies that the cullMode state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullMode.html">vkCmdSetCullMode</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_CULL_MODE_EXT = VK_DYNAMIC_STATE_CULL_MODE,

    /// <summary>
    ///     VK_DYNAMIC_STATE_FRONT_FACE specifies that the frontFacestate in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFace.html">vkCmdSetFrontFace</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_FRONT_FACE_EXT = VK_DYNAMIC_STATE_FRONT_FACE,

    /// <summary>
    ///     VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY specifies that the topology state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineInputAssemblyStateCreateInfo.html">
    ///         VkPipelineInputAssemblyStateCreateInfo
    ///     </a>
    ///     only specifies the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-primitive-topology-class">
    ///         topology
    ///         class
    ///     </a>
    ///     , and the specific topology order and adjacency must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopology.html">vkCmdSetPrimitiveTopology</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT = VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY,

    /// <summary>
    ///     VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT specifies that the viewportCount and pViewports state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">
    ///         VkPipelineViewportStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCount.html">vkCmdSetViewportWithCount</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT = VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT,

    /// <summary>
    ///     VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT specifies that the scissorCount and pScissors state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">
    ///         VkPipelineViewportStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCount.html">vkCmdSetScissorWithCount</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT = VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT,

    /// <summary>
    ///     VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE specifies that the stride state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDescription.html">
    ///         VkVertexInputBindingDescription
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2.html">vkCmdBindVertexBuffers2</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT = VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE specifies that the depthTestEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnable.html">vkCmdSetDepthTestEnable</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE specifies that the depthWriteEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnable.html">vkCmdSetDepthWriteEnable</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_COMPARE_OP specifies that the depthCompareOp state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOp.html">vkCmdSetDepthCompareOp</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT = VK_DYNAMIC_STATE_DEPTH_COMPARE_OP,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE specifies that the depthBoundsTestEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnable.html">vkCmdSetDepthBoundsTestEnable</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE,

    /// <summary>
    ///     VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE specifies that the stencilTestEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
    ///         VkPipelineDepthStencilStateCreateInfo
    ///     </a>
    ///     will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnable.html">vkCmdSetStencilTestEnable</a>
    ///     before any draw call.
    /// </summary>
    VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE,

    /// <summary>
    ///     VK_DYNAMIC_STATE_STENCIL_OP specifies that the failOp, passOp, depthFailOp, and compareOp states in
    ///     VkPipelineDepthStencilStateCreateInfo for both front and back will be ignored and must be set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOp.html">vkCmdSetStencilOp</a>
    ///     before any draws are performed with a pipeline state with VkPipelineDepthStencilStateCreateInfo member
    ///     stencilTestEnable set to VK_TRUE
    /// </summary>
    VK_DYNAMIC_STATE_STENCIL_OP_EXT = VK_DYNAMIC_STATE_STENCIL_OP,

    /// <summary>
    ///     VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE specifies that the rasterizerDiscardEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and mustbe set dynamically with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnable.html">
    ///         vkCmdSetRasterizerDiscardEnable
    ///     </a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE_EXT = VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE,

    /// <summary>
    ///     VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE specifies that the depthBiasEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
    ///         VkPipelineRasterizationStateCreateInfo
    ///     </a>
    ///     will be ignored and mustbe set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnable.html">vkCmdSetDepthBiasEnable</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE,

    /// <summary>
    ///     VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE specifies that the primitiveRestartEnable state in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineInputAssemblyStateCreateInfo.html">
    ///         VkPipelineInputAssemblyStateCreateInfo
    ///     </a>
    ///     will be ignored and mustbe set dynamically with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnable.html">vkCmdSetPrimitiveRestartEnable</a>
    ///     before any drawing commands.
    /// </summary>
    VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE_EXT = VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE
}