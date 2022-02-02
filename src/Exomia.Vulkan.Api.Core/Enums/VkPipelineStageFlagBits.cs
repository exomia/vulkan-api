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
///     VkPipelineStageFlagBits - Bitmask specifying pipeline stages -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineStageFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineStageFlagBits.html</a>
/// </summary>
[Flags]
public enum VkPipelineStageFlagBits
{
    /// <summary>
    ///     VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT is equivalent to VK_PIPELINE_STAGE_ALL_COMMANDS_BIT with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccessFlags.html">VkAccessFlags</a>
    ///     set to 0 when specified in the second synchronization scope, but specifies no stage of execution when specified in
    ///     the first scope.
    /// </summary>
    VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT = 0,

    /// <summary>
    ///     VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT specifies the stage of the pipeline where VkDrawIndirect* /
    ///     VkDispatchIndirect* / VkTraceRaysIndirect* data structures are consumed. This stage also includes reading commands
    ///     written by
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsNV.html">
    ///         vkCmdExecuteGeneratedCommandsNV
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT = 1,

    /// <summary>
    ///     VK_PIPELINE_STAGE_VERTEX_INPUT_BIT specifies the stage of the pipeline where vertex and index buffers are
    ///     consumed.
    /// </summary>
    VK_PIPELINE_STAGE_VERTEX_INPUT_BIT = 2,

    /// <summary>VK_PIPELINE_STAGE_VERTEX_SHADER_BIT specifies the vertex shader stage.</summary>
    VK_PIPELINE_STAGE_VERTEX_SHADER_BIT = 3,

    /// <summary>VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT specifies the tessellation control shader stage.</summary>
    VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT = 4,

    /// <summary>VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT specifies the tessellation evaluation shader stage.</summary>
    VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT = 5,

    /// <summary>VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT specifies the geometry shader stage.</summary>
    VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT = 6,

    /// <summary>VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT specifies the fragment shader stage.</summary>
    VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT = 7,

    /// <summary>
    ///     VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT specifies the stage of the pipeline where early fragment tests (depth
    ///     and stencil tests before fragment shading) are performed. This stage also includes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load operations
    ///     </a>
    ///     for framebuffer attachments with a depth/stencil format.
    /// </summary>
    VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT = 8,

    /// <summary>
    ///     VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT specifies the stage of the pipeline where late fragment tests (depth and
    ///     stencil tests after fragment shading) are performed. This stage also includes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         store operations
    ///     </a>
    ///     for framebuffer attachments with a depth/stencil format.
    /// </summary>
    VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT = 9,

    /// <summary>
    ///     VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT specifies the stage of the pipeline after blending where the final
    ///     color values are output from the pipeline. This stage also includes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load and store operations
    ///     </a>
    ///     and multisample resolve operations for framebuffer attachments with a color or
    ///     depth/stencil format.
    /// </summary>
    VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT = 10,

    /// <summary>VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT specifies the execution of a compute shader.</summary>
    VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT = 11,

    /// <summary>
    ///     VK_PIPELINE_STAGE_TRANSFER_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineStageFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineStageFlagBits</a>
    /// </summary>
    VK_PIPELINE_STAGE_TRANSFER_BIT = 12,

    /// <summary>
    ///     VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT is equivalent to VK_PIPELINE_STAGE_ALL_COMMANDS_BIT with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccessFlags.html">VkAccessFlags</a>
    ///     set to 0 when specified in the first synchronization scope, but specifies no stage of execution when specified in
    ///     the second scope.
    /// </summary>
    VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT = 13,

    /// <summary>
    ///     VK_PIPELINE_STAGE_HOST_BIT specifies a pseudo-stage indicating execution on the host of reads/writes of device
    ///     memory. This stage is not invoked by any commands recorded in a command buffer.
    /// </summary>
    VK_PIPELINE_STAGE_HOST_BIT = 14,

    /// <summary>
    ///     VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT specifies the execution of all graphics pipeline stages, and is equivalent
    ///     to the logical OR of:
    /// </summary>
    VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT = 15,

    /// <summary>
    ///     VK_PIPELINE_STAGE_ALL_COMMANDS_BIT specifies all operations performed by all commands supported on the queue
    ///     it is used with.
    /// </summary>
    VK_PIPELINE_STAGE_ALL_COMMANDS_BIT = 16,

    /// <summary>VK_PIPELINE_STAGE_NONE specifies no stages of execution.</summary>
    VK_PIPELINE_STAGE_NONE = 0,

    /// <summary>
    ///     VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT specifies the stage of the pipeline where vertex attribute output
    ///     values are written to the transform feedback buffers.
    /// </summary>
    VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT = 24,

    /// <summary>
    ///     VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT specifies the stage of the pipeline where the predicate of
    ///     conditional rendering is consumed.
    /// </summary>
    VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT = 18,

    /// <summary>
    ///     VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR specifies     the execution of
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructureNV.html">
    ///         vkCmdBuildAccelerationStructureNV
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureNV.html">
    ///         vkCmdCopyAccelerationStructureNV
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesNV.html">
    ///         vkCmdWriteAccelerationStructuresPropertiesNV
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresKHR.html">
    ///         vkCmdBuildAccelerationStructuresKHR
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresIndirectKHR.html">
    ///         vkCmdBuildAccelerationStructuresIndirectKHR
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureKHR.html">
    ///         vkCmdCopyAccelerationStructureKHR
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureToMemoryKHR.html">
    ///         vkCmdCopyAccelerationStructureToMemoryKHR
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToAccelerationStructureKHR.html">
    ///         vkCmdCopyMemoryToAccelerationStructureKHR
    ///     </a>
    ///     , and
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkCmdWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = 25,

    /// <summary>
    ///     VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR specifies the     execution of the ray tracing shader stages, via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysNV.html">vkCmdTraceRaysNV</a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysKHR.html">vkCmdTraceRaysKHR</a>
    ///     , or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirectKHR.html">vkCmdTraceRaysIndirectKHR</a>
    /// </summary>
    VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR = 21,

    /// <summary>VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV specifies the task shader stage.</summary>
    VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV = 19,

    /// <summary>VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV specifies the mesh shader stage.</summary>
    VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV = 20,

    /// <summary>
    ///     VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT specifies the stage of the pipeline where the fragment density
    ///     map is read to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fragmentdensitymapops">
    ///         generate
    ///         the fragment areas
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 23,

    /// <summary>
    ///     VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR    specifies the stage of the pipeline where the
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
    VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 22,

    /// <summary>
    ///     VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV specifies the stage of the pipeline where device-side
    ///     preprocessing for generated commands via
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html">
    ///         vkCmdPreprocessGeneratedCommandsNV
    ///     </a>
    ///     is handled.
    /// </summary>
    VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV = 17,

    /// <summary>
    ///     VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR    specifies the stage of the pipeline where the
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
    VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV = VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,

    /// <summary>
    ///     VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR specifies the     execution of the ray tracing shader stages, via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysNV.html">vkCmdTraceRaysNV</a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysKHR.html">vkCmdTraceRaysKHR</a>
    ///     , or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirectKHR.html">vkCmdTraceRaysIndirectKHR</a>
    /// </summary>
    VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_NV = VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR,

    /// <summary>
    ///     VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR specifies     the execution of
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructureNV.html">
    ///         vkCmdBuildAccelerationStructureNV
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureNV.html">
    ///         vkCmdCopyAccelerationStructureNV
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesNV.html">
    ///         vkCmdWriteAccelerationStructuresPropertiesNV
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresKHR.html">
    ///         vkCmdBuildAccelerationStructuresKHR
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresIndirectKHR.html">
    ///         vkCmdBuildAccelerationStructuresIndirectKHR
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureKHR.html">
    ///         vkCmdCopyAccelerationStructureKHR
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureToMemoryKHR.html">
    ///         vkCmdCopyAccelerationStructureToMemoryKHR
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToAccelerationStructureKHR.html">
    ///         vkCmdCopyMemoryToAccelerationStructureKHR
    ///     </a>
    ///     , and
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkCmdWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_NV = VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR,

    /// <summary>VK_PIPELINE_STAGE_NONE specifies no stages of execution.</summary>
    VK_PIPELINE_STAGE_NONE_KHR = VK_PIPELINE_STAGE_NONE
}