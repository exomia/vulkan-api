﻿#region License

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
///     VkPipelineStageFlagBits2 - Pipeline stage flags for VkPipelineStageFlags2 -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineStageFlagBits2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineStageFlagBits2.html</a>
/// </summary>
[Flags]
public enum VkPipelineStageFlagBits2 : ulong
{
    /// <summary>VK_PIPELINE_STAGE_2_NONE specifies no stages of execution.</summary>
    VK_PIPELINE_STAGE_2_NONE = 0,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT is equivalent to VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccessFlags2.html">VkAccessFlags2</a>
    ///     set to 0 when specified in the second synchronization scope, but equivalent to VK_PIPELINE_STAGE_2_NONE in the
    ///     first scope.
    /// </summary>
    VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT = 0,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT specifies the stage of the pipeline where indirect command parameters
    ///     are consumed. This stage also includes reading commands written by
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html">
    ///         vkCmdPreprocessGeneratedCommandsNV
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT = 1,

    /// <summary>VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT is equivalent to the logical OR of:</summary>
    VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT = 2,

    /// <summary>VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT specifies the vertex shader stage.</summary>
    VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT = 3,

    /// <summary>VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT specifies the tessellation control shader stage.</summary>
    VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT = 4,

    /// <summary>VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT specifies the tessellation evaluation shader stage.</summary>
    VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT = 5,

    /// <summary>VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT specifies the geometry shader stage.</summary>
    VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT = 6,

    /// <summary>VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT specifies the fragment shader stage.</summary>
    VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT = 7,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT specifies the stage of the pipeline where early fragment tests (depth
    ///     and stencil tests before fragment shading) are performed. This stage also includes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load operations
    ///     </a>
    ///     for framebuffer attachments with a depth/stencil format.
    /// </summary>
    VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT = 8,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT specifies the stage of the pipeline where late fragment tests (depth
    ///     and stencil tests after fragment shading) are performed. This stage also includes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         store operations
    ///     </a>
    ///     for framebuffer attachments with a depth/stencil format.
    /// </summary>
    VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT = 9,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT specifies the stage of the pipeline after blending where the final
    ///     color values are output from the pipeline. This stage also includes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load and store operations
    ///     </a>
    ///     and multisample resolve operations for framebuffer attachments with a color or
    ///     depth/stencil format.
    /// </summary>
    VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT = 10,

    /// <summary>VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT specifies the compute shader stage.</summary>
    VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT = 11,

    /// <summary>VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT is equivalent to specifying all of:</summary>
    VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT = 12,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT is equivalent to VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccessFlags2.html">VkAccessFlags2</a>
    ///     set to 0 when specified in the first synchronization scope, but equivalent to VK_PIPELINE_STAGE_2_NONE in the
    ///     second scope.
    /// </summary>
    VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT = 13,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_HOST_BIT specifies a pseudo-stage indicating execution on the host of reads/writes of
    ///     device memory. This stage is not invoked by any commands recorded in a command buffer.
    /// </summary>
    VK_PIPELINE_STAGE_2_HOST_BIT = 14,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT specifies the execution of all graphics pipeline stages, and is
    ///     equivalent to the logical OR of:
    /// </summary>
    VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT = 15,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT specifies all operations performed by all commands supported on the queue
    ///     it is used with.
    /// </summary>
    VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT = 16,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_COPY_BIT specifies the execution of all
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a>,
    ///     including
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyQueryPoolResults.html">vkCmdCopyQueryPoolResults</a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_COPY_BIT = 32,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_RESOLVE_BIT specifies the execution of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage.html">vkCmdResolveImage</a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_RESOLVE_BIT = 33,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_BLIT_BIT specifies the execution of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html">vkCmdBlitImage</a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_BLIT_BIT = 34,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_CLEAR_BIT specifies the execution of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#clears">clear commands</a>,
    ///     with the exception of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdClearAttachments.html">vkCmdClearAttachments</a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_CLEAR_BIT = 35,

    /// <summary>VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT specifies the stage of the pipeline where index buffers are consumed.</summary>
    VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT = 36,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT specifies the stage of the pipeline where vertex buffers are
    ///     consumed.
    /// </summary>
    VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT = 37,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT is equivalent to specifying all supported
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#pipeline-graphics-subsets-pre-rasterization">
    ///         pre-rasterization
    ///         shader stages
    ///     </a>
    ///     :
    /// </summary>
    VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT = 38,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR specifies the stage of the pipeline where
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operation
    ///     </a>
    ///     are performed.
    /// </summary>
    VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR = 26,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR specifies the stage of the pipeline where
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operation
    ///     </a>
    ///     are performed.
    /// </summary>
    VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR = 27,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT specifies the stage of the pipeline where vertex attribute
    ///     output values are written to the transform feedback buffers.
    /// </summary>
    VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT = 24,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT specifies the stage of the pipeline where the predicate of
    ///     conditional rendering is consumed.
    /// </summary>
    VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT = 18,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV specifies the stage of the pipeline where device-side generation
    ///     of commands via
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html">
    ///         vkCmdPreprocessGeneratedCommandsNV
    ///     </a>
    ///     is handled.
    /// </summary>
    VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV = 17,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR    specifies the stage of the pipeline where the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-fragment-shading-rate-attachment">
    ///         fragment
    ///         shading rate     attachment
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-shading-rate-image">
    ///         shading
    ///         rate image
    ///     </a>
    ///     is read to determine the fragment shading rate for portions of a     rasterized primitive.
    /// </summary>
    VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 22,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR specifies the execution of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure">
    ///         acceleration
    ///         structure commands
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = 25,

    /// <summary>VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR specifies the execution of the ray tracing shader stages.</summary>
    VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR = 21,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT specifies the stage of the pipeline where the fragment density
    ///     map is read to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fragmentdensitymapops">
    ///         generate
    ///         the fragment areas
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 23,

    /// <summary>VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV specifies the task shader stage.</summary>
    VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV = 19,

    /// <summary>VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV specifies the mesh shader stage.</summary>
    VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV = 20,

    /// <summary>VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI specifies the subpass shading shader stage.</summary>
    VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI = 39,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI specifies the stage of the pipeline where the invocation mask
    ///     image is read by the implementation to optimize the ray dispatch.
    /// </summary>
    VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI = 40,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_RESERVED_387_BIT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineStageFlagBits2">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineStageFlagBits2</a>
    /// </summary>
    VK_PIPELINE_STAGE_2_RESERVED_387_BIT_KHR = 28,

    /// <summary>VK_PIPELINE_STAGE_2_NONE specifies no stages of execution.</summary>
    VK_PIPELINE_STAGE_2_NONE_KHR = VK_PIPELINE_STAGE_2_NONE,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT is equivalent to VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccessFlags2.html">VkAccessFlags2</a>
    ///     set to 0 when specified in the second synchronization scope, but equivalent to VK_PIPELINE_STAGE_2_NONE in the
    ///     first scope.
    /// </summary>
    VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR = VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT specifies the stage of the pipeline where indirect command parameters
    ///     are consumed. This stage also includes reading commands written by
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html">
    ///         vkCmdPreprocessGeneratedCommandsNV
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR = VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT,

    /// <summary>VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT is equivalent to the logical OR of:</summary>
    VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR = VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT,

    /// <summary>VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT specifies the vertex shader stage.</summary>
    VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR = VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT,

    /// <summary>VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT specifies the tessellation control shader stage.</summary>
    VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR = VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT,

    /// <summary>VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT specifies the tessellation evaluation shader stage.</summary>
    VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR = VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT,

    /// <summary>VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT specifies the geometry shader stage.</summary>
    VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR = VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT,

    /// <summary>VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT specifies the fragment shader stage.</summary>
    VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR = VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT specifies the stage of the pipeline where early fragment tests (depth
    ///     and stencil tests before fragment shading) are performed. This stage also includes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load operations
    ///     </a>
    ///     for framebuffer attachments with a depth/stencil format.
    /// </summary>
    VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR = VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT specifies the stage of the pipeline where late fragment tests (depth
    ///     and stencil tests after fragment shading) are performed. This stage also includes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         store operations
    ///     </a>
    ///     for framebuffer attachments with a depth/stencil format.
    /// </summary>
    VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR = VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT specifies the stage of the pipeline after blending where the final
    ///     color values are output from the pipeline. This stage also includes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load and store operations
    ///     </a>
    ///     and multisample resolve operations for framebuffer attachments with a color or
    ///     depth/stencil format.
    /// </summary>
    VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR = VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT,

    /// <summary>VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT specifies the compute shader stage.</summary>
    VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR = VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT,

    /// <summary>VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT is equivalent to specifying all of:</summary>
    VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR = VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_TRANSFER_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineStageFlagBits2">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineStageFlagBits2</a>
    /// </summary>
    VK_PIPELINE_STAGE_2_TRANSFER_BIT = VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineStageFlagBits2">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineStageFlagBits2</a>
    /// </summary>
    VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR = VK_PIPELINE_STAGE_2_TRANSFER_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT is equivalent to VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccessFlags2.html">VkAccessFlags2</a>
    ///     set to 0 when specified in the first synchronization scope, but equivalent to VK_PIPELINE_STAGE_2_NONE in the
    ///     second scope.
    /// </summary>
    VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR = VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_HOST_BIT specifies a pseudo-stage indicating execution on the host of reads/writes of
    ///     device memory. This stage is not invoked by any commands recorded in a command buffer.
    /// </summary>
    VK_PIPELINE_STAGE_2_HOST_BIT_KHR = VK_PIPELINE_STAGE_2_HOST_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT specifies the execution of all graphics pipeline stages, and is
    ///     equivalent to the logical OR of:
    /// </summary>
    VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR = VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT specifies all operations performed by all commands supported on the queue
    ///     it is used with.
    /// </summary>
    VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR = VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_COPY_BIT specifies the execution of all
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a>,
    ///     including
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyQueryPoolResults.html">vkCmdCopyQueryPoolResults</a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_COPY_BIT_KHR = VK_PIPELINE_STAGE_2_COPY_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_RESOLVE_BIT specifies the execution of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage.html">vkCmdResolveImage</a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR = VK_PIPELINE_STAGE_2_RESOLVE_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_BLIT_BIT specifies the execution of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html">vkCmdBlitImage</a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_BLIT_BIT_KHR = VK_PIPELINE_STAGE_2_BLIT_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_CLEAR_BIT specifies the execution of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#clears">clear commands</a>,
    ///     with the exception of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdClearAttachments.html">vkCmdClearAttachments</a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR = VK_PIPELINE_STAGE_2_CLEAR_BIT,

    /// <summary>VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT specifies the stage of the pipeline where index buffers are consumed.</summary>
    VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR = VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT specifies the stage of the pipeline where vertex buffers are
    ///     consumed.
    /// </summary>
    VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR = VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT is equivalent to specifying all supported
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#pipeline-graphics-subsets-pre-rasterization">
    ///         pre-rasterization
    ///         shader stages
    ///     </a>
    ///     :
    /// </summary>
    VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR = VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR    specifies the stage of the pipeline where the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-fragment-shading-rate-attachment">
    ///         fragment
    ///         shading rate     attachment
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-shading-rate-image">
    ///         shading
    ///         rate image
    ///     </a>
    ///     is read to determine the fragment shading rate for portions of a     rasterized primitive.
    /// </summary>
    VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV = VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,

    /// <summary>VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR specifies the execution of the ray tracing shader stages.</summary>
    VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_NV = VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR,

    /// <summary>
    ///     VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR specifies the execution of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure">
    ///         acceleration
    ///         structure commands
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV = VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR
}