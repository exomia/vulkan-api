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
///     VkAccessFlagBits2 - Access flags for VkAccessFlags2 -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccessFlagBits2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccessFlagBits2.html</a>
/// </summary>
[Flags]
public enum VkAccessFlagBits2 : ulong
{
    /// <summary>VK_ACCESS_2_NONE specifies no accesses.</summary>
    VK_ACCESS_2_NONE = 0,

    /// <summary>
    ///     VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT specifies read access to     command data read from indirect buffers as
    ///     part of an indirect build, trace,     drawing or dispatch command.     Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT    pipeline stage.
    /// </summary>
    VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT = 1 << 0,

    /// <summary>
    ///     VK_ACCESS_2_INDEX_READ_BIT specifies read access to an index buffer as part of an indexed drawing command,
    ///     bound by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html">vkCmdBindIndexBuffer</a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_INDEX_INPUT_BITpipeline stage.
    /// </summary>
    VK_ACCESS_2_INDEX_READ_BIT = 1 << 1,

    /// <summary>
    ///     VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT specifies read access to a vertex buffer as part of a drawing command,
    ///     bound by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html">vkCmdBindVertexBuffers</a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT = 1 << 2,

    /// <summary>
    ///     VK_ACCESS_2_UNIFORM_READ_BIT specifies read access to a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbuffer">
    ///         uniform
    ///         buffer
    ///     </a>
    ///     in any shader pipeline stage.
    /// </summary>
    VK_ACCESS_2_UNIFORM_READ_BIT = 1 << 3,

    /// <summary>
    ///     VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT specifies read access to an
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">input attachment</a>
    ///     within a render pass during subpass shading or fragment shading. Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI or VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT = 1 << 4,

    /// <summary>
    ///     VK_ACCESS_2_SHADER_READ_BITspecifies read access to a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#shader-binding-table">
    ///         shader
    ///         binding table
    ///     </a>
    ///     in any shader pipeline. In addition, it is equivalent to the logical OR of:
    /// </summary>
    VK_ACCESS_2_SHADER_READ_BIT = 1 << 5,

    /// <summary>VK_ACCESS_2_SHADER_WRITE_BIT is equivalent to VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT.</summary>
    VK_ACCESS_2_SHADER_WRITE_BIT = 1 << 6,

    /// <summary>
    ///     VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT specifies read access to a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">color attachment</a>
    ///     , such as via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-blending">blending</a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-logicop">
    ///         logic
    ///         operations
    ///     </a>
    ///     , or via certain
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load operations
    ///     </a>
    ///     . It does not include
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-blend-advanced">
    ///         advanced
    ///         blend operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT = 1 << 7,

    /// <summary>
    ///     VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT specifies write access to a
    ///     <a href="#renderpass">color, resolve, or depth/stencil resolve attachment</a>during a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">render pass</a>
    ///     or via certain
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load and store operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT
    ///     pipeline stage.
    /// </summary>
    VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT = 1 << 8,

    /// <summary>
    ///     VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT specifies read access to a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">
    ///         depth/stencil
    ///         attachment
    ///     </a>
    ///     , via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fragops-ds-state">
    ///         depth or
    ///         stencil operations
    ///     </a>
    ///     or via certain
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT or
    ///     VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT pipeline stages.
    /// </summary>
    VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT = 1 << 9,

    /// <summary>
    ///     VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT specifies write access to a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">
    ///         depth/stencil
    ///         attachment
    ///     </a>
    ///     , via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fragops-ds-state">
    ///         depth or
    ///         stencil operations
    ///     </a>
    ///     or via certain
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load and store operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT or
    ///     VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT pipeline stages.
    /// </summary>
    VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = 1 << 10,

    /// <summary>
    ///     VK_ACCESS_2_TRANSFER_READ_BIT specifies read access to an image or buffer in a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy</a> operation.
    ///     Such access occurs in the VK_PIPELINE_STAGE_2_COPY_BIT, VK_PIPELINE_STAGE_2_BLIT_BIT, or
    ///     VK_PIPELINE_STAGE_2_RESOLVE_BIT pipeline stages.
    /// </summary>
    VK_ACCESS_2_TRANSFER_READ_BIT = 1 << 11,

    /// <summary>
    ///     VK_ACCESS_2_TRANSFER_WRITE_BIT specifies write access to an image or buffer in a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#clears">clear</a> or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy</a> operation.
    ///     Such access occurs in the VK_PIPELINE_STAGE_2_COPY_BIT, VK_PIPELINE_STAGE_2_BLIT_BIT,
    ///     VK_PIPELINE_STAGE_2_CLEAR_BIT, or VK_PIPELINE_STAGE_2_RESOLVE_BIT pipeline stages.
    /// </summary>
    VK_ACCESS_2_TRANSFER_WRITE_BIT = 1 << 12,

    /// <summary>
    ///     VK_ACCESS_2_HOST_READ_BIT specifies read access by a host operation. Accesses of this type are not performed
    ///     through a resource, but directly on memory. Such access occurs in the VK_PIPELINE_STAGE_2_HOST_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_HOST_READ_BIT = 1 << 13,

    /// <summary>
    ///     VK_ACCESS_2_HOST_WRITE_BIT specifies write access by a host operation. Accesses of this type are not performed
    ///     through a resource, but directly on memory. Such access occurs in the VK_PIPELINE_STAGE_2_HOST_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_HOST_WRITE_BIT = 1 << 14,

    /// <summary>
    ///     VK_ACCESS_2_MEMORY_READ_BIT specifies all read accesses. It is always valid in any access mask, and is treated
    ///     as equivalent to setting all READ access flags that are valid where it is used.
    /// </summary>
    VK_ACCESS_2_MEMORY_READ_BIT = 1 << 15,

    /// <summary>
    ///     VK_ACCESS_2_MEMORY_WRITE_BIT specifies all write accesses. It is always valid in any access mask, and is
    ///     treated as equivalent to setting all WRITE access flags that are valid where it is used.
    /// </summary>
    VK_ACCESS_2_MEMORY_WRITE_BIT = 1 << 16,

    /// <summary>
    ///     VK_ACCESS_2_SHADER_SAMPLED_READ_BIT specifies read access to a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformtexelbuffer">
    ///         uniform
    ///         texel buffer
    ///     </a>
    ///     or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampledimage">
    ///         sampled
    ///         image
    ///     </a>
    ///     in any shader pipeline stage.
    /// </summary>
    VK_ACCESS_2_SHADER_SAMPLED_READ_BIT = 1 << 32,

    /// <summary>
    ///     VK_ACCESS_2_SHADER_STORAGE_READ_BIT specifies read access to a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebuffer">
    ///         storage
    ///         buffer
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-physical-storage-buffer">
    ///         physical
    ///         storage buffer
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer">
    ///         storage
    ///         texel buffer
    ///     </a>
    ///     , or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         image
    ///     </a>
    ///     in any shader pipeline stage.
    /// </summary>
    VK_ACCESS_2_SHADER_STORAGE_READ_BIT = 1 << 33,

    /// <summary>
    ///     VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT specifies write access to a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebuffer">
    ///         storage
    ///         buffer
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-physical-storage-buffer">
    ///         physical
    ///         storage buffer
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer">
    ///         storage
    ///         texel buffer
    ///     </a>
    ///     , or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         image
    ///     </a>
    ///     in any shader pipeline stage.
    /// </summary>
    VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT = 1 << 34,

    /// <summary>
    ///     VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR specifies read access to an image or buffer resource as part of a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operation
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHRpipeline stage.
    /// </summary>
    VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR = 1 << 35,

    /// <summary>
    ///     VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR specifies write access to an image or buffer resource as part of a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operation
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHRpipeline stage.
    /// </summary>
    VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR = 1 << 36,

    /// <summary>
    ///     VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR specifies read access to an image or buffer resource as part of a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operation
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHRpipeline stage.
    /// </summary>
    VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR = 1 << 37,

    /// <summary>
    ///     VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR specifies write access to an image or buffer resource as part of a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operation
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHRpipeline stage.
    /// </summary>
    VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR = 1 << 38,

    /// <summary>
    ///     VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT specifies write access to a transform feedback buffer made when
    ///     transform feedback is active. Such access occurs in the VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT pipeline
    ///     stage.
    /// </summary>
    VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = 1 << 25,

    /// <summary>
    ///     VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT specifies read access to a transform feedback counter
    ///     buffer which is read when
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginTransformFeedbackEXT.html">vkCmdBeginTransformFeedbackEXT</a>
    ///     executes. Such access occurs in the VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT pipeline stage.
    /// </summary>
    VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = 1 << 26,

    /// <summary>
    ///     VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT specifies write access to a transform feedback counter
    ///     buffer which is written when
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndTransformFeedbackEXT.html">vkCmdEndTransformFeedbackEXT</a>
    ///     executes. Such access occurs in the VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT pipeline stage.
    /// </summary>
    VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = 1 << 27,

    /// <summary>
    ///     VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT specifies read access to a predicate as part of conditional
    ///     rendering. Such access occurs in the VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT pipeline stage.
    /// </summary>
    VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT = 1 << 20,

    /// <summary>
    ///     VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV specifies reads from buffer inputs to
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html">
    ///         vkCmdPreprocessGeneratedCommandsNV
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV pipeline stage.
    /// </summary>
    VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV = 1 << 17,

    /// <summary>
    ///     VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV specifies writes to the target command buffer preprocess outputs.
    ///     Such access occurs in the VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV pipeline stage.
    /// </summary>
    VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV = 1 << 18,

    /// <summary>
    ///     VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHRspecifies read access to a fragment shading rate
    ///     attachment during rasterization. Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHRpipeline stage.
    /// </summary>
    VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 1 << 23,

    /// <summary>
    ///     VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR specifies read access to an acceleration structure as part of a
    ///     trace, build, or copy command, or to an
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-scratch">
    ///         acceleration
    ///         structure scratch buffer
    ///     </a>
    ///     as part of a build command. Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR pipeline stage or
    ///     VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR pipeline stage.
    /// </summary>
    VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR = 1 << 21,

    /// <summary>
    ///     VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR specifies write access to an acceleration structure or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-scratch">
    ///         acceleration
    ///         structure scratch buffer
    ///     </a>
    ///     as part of a build or copy command. Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR pipeline stage.
    /// </summary>
    VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = 1 << 22,

    /// <summary>
    ///     VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT specifies read access to a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-fragmentdensitymapattachment">
    ///         fragment
    ///         density map attachment
    ///     </a>
    ///     during dynamic
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fragmentdensitymapops">
    ///         fragment
    ///         density map operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT
    ///     pipeline stage.
    /// </summary>
    VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = 1 << 24,

    /// <summary>
    ///     VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT specifies read access to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">
    ///         color
    ///         attachments
    ///     </a>
    ///     , including
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-blend-advanced">
    ///         advanced
    ///         blend operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = 1 << 19,

    /// <summary>
    ///     VK_ACCESS_2_RESERVED_41_BIT_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAccessFlagBits2">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAccessFlagBits2</a>
    /// </summary>
    VK_ACCESS_2_RESERVED_41_BIT_AMD = 1 << 41,

    /// <summary>
    ///     VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI specifies read access to a invocation mask image in the
    ///     VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI pipeline stage.
    /// </summary>
    VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI = 1 << 39,

    /// <summary>
    ///     VK_ACCESS_2_RESERVED_387_BIT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAccessFlagBits2">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAccessFlagBits2</a>
    /// </summary>
    VK_ACCESS_2_RESERVED_387_BIT_KHR = 1 << 40,

    /// <summary>VK_ACCESS_2_NONE specifies no accesses.</summary>
    VK_ACCESS_2_NONE_KHR = VK_ACCESS_2_NONE,

    /// <summary>
    ///     VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT specifies read access to     command data read from indirect buffers as
    ///     part of an indirect build, trace,     drawing or dispatch command.     Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT    pipeline stage.
    /// </summary>
    VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR = VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_INDEX_READ_BIT specifies read access to an index buffer as part of an indexed drawing command,
    ///     bound by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html">vkCmdBindIndexBuffer</a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_INDEX_INPUT_BITpipeline stage.
    /// </summary>
    VK_ACCESS_2_INDEX_READ_BIT_KHR = VK_ACCESS_2_INDEX_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT specifies read access to a vertex buffer as part of a drawing command,
    ///     bound by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html">vkCmdBindVertexBuffers</a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR = VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_UNIFORM_READ_BIT specifies read access to a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbuffer">
    ///         uniform
    ///         buffer
    ///     </a>
    ///     in any shader pipeline stage.
    /// </summary>
    VK_ACCESS_2_UNIFORM_READ_BIT_KHR = VK_ACCESS_2_UNIFORM_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT specifies read access to an
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">input attachment</a>
    ///     within a render pass during subpass shading or fragment shading. Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI or VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR = VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_SHADER_READ_BITspecifies read access to a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#shader-binding-table">
    ///         shader
    ///         binding table
    ///     </a>
    ///     in any shader pipeline. In addition, it is equivalent to the logical OR of:
    /// </summary>
    VK_ACCESS_2_SHADER_READ_BIT_KHR = VK_ACCESS_2_SHADER_READ_BIT,

    /// <summary>VK_ACCESS_2_SHADER_WRITE_BIT is equivalent to VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT.</summary>
    VK_ACCESS_2_SHADER_WRITE_BIT_KHR = VK_ACCESS_2_SHADER_WRITE_BIT,

    /// <summary>
    ///     VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT specifies read access to a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">color attachment</a>
    ///     , such as via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-blending">blending</a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-logicop">
    ///         logic
    ///         operations
    ///     </a>
    ///     , or via certain
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load operations
    ///     </a>
    ///     . It does not include
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-blend-advanced">
    ///         advanced
    ///         blend operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR = VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT specifies write access to a
    ///     <a href="#renderpass">color, resolve, or depth/stencil resolve attachment</a>during a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">render pass</a>
    ///     or via certain
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load and store operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT
    ///     pipeline stage.
    /// </summary>
    VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR = VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT,

    /// <summary>
    ///     VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT specifies read access to a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">
    ///         depth/stencil
    ///         attachment
    ///     </a>
    ///     , via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fragops-ds-state">
    ///         depth or
    ///         stencil operations
    ///     </a>
    ///     or via certain
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT or
    ///     VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT pipeline stages.
    /// </summary>
    VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR = VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT specifies write access to a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass">
    ///         depth/stencil
    ///         attachment
    ///     </a>
    ///     , via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fragops-ds-state">
    ///         depth or
    ///         stencil operations
    ///     </a>
    ///     or via certain
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-load-store-ops">
    ///         subpass
    ///         load and store operations
    ///     </a>
    ///     . Such access occurs in the VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT or
    ///     VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT pipeline stages.
    /// </summary>
    VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR = VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT,

    /// <summary>
    ///     VK_ACCESS_2_TRANSFER_READ_BIT specifies read access to an image or buffer in a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy</a> operation.
    ///     Such access occurs in the VK_PIPELINE_STAGE_2_COPY_BIT, VK_PIPELINE_STAGE_2_BLIT_BIT, or
    ///     VK_PIPELINE_STAGE_2_RESOLVE_BIT pipeline stages.
    /// </summary>
    VK_ACCESS_2_TRANSFER_READ_BIT_KHR = VK_ACCESS_2_TRANSFER_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_TRANSFER_WRITE_BIT specifies write access to an image or buffer in a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#clears">clear</a> or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy</a> operation.
    ///     Such access occurs in the VK_PIPELINE_STAGE_2_COPY_BIT, VK_PIPELINE_STAGE_2_BLIT_BIT,
    ///     VK_PIPELINE_STAGE_2_CLEAR_BIT, or VK_PIPELINE_STAGE_2_RESOLVE_BIT pipeline stages.
    /// </summary>
    VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR = VK_ACCESS_2_TRANSFER_WRITE_BIT,

    /// <summary>
    ///     VK_ACCESS_2_HOST_READ_BIT specifies read access by a host operation. Accesses of this type are not performed
    ///     through a resource, but directly on memory. Such access occurs in the VK_PIPELINE_STAGE_2_HOST_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_HOST_READ_BIT_KHR = VK_ACCESS_2_HOST_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_HOST_WRITE_BIT specifies write access by a host operation. Accesses of this type are not performed
    ///     through a resource, but directly on memory. Such access occurs in the VK_PIPELINE_STAGE_2_HOST_BIT pipeline stage.
    /// </summary>
    VK_ACCESS_2_HOST_WRITE_BIT_KHR = VK_ACCESS_2_HOST_WRITE_BIT,

    /// <summary>
    ///     VK_ACCESS_2_MEMORY_READ_BIT specifies all read accesses. It is always valid in any access mask, and is treated
    ///     as equivalent to setting all READ access flags that are valid where it is used.
    /// </summary>
    VK_ACCESS_2_MEMORY_READ_BIT_KHR = VK_ACCESS_2_MEMORY_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_MEMORY_WRITE_BIT specifies all write accesses. It is always valid in any access mask, and is
    ///     treated as equivalent to setting all WRITE access flags that are valid where it is used.
    /// </summary>
    VK_ACCESS_2_MEMORY_WRITE_BIT_KHR = VK_ACCESS_2_MEMORY_WRITE_BIT,

    /// <summary>
    ///     VK_ACCESS_2_SHADER_SAMPLED_READ_BIT specifies read access to a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformtexelbuffer">
    ///         uniform
    ///         texel buffer
    ///     </a>
    ///     or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampledimage">
    ///         sampled
    ///         image
    ///     </a>
    ///     in any shader pipeline stage.
    /// </summary>
    VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR = VK_ACCESS_2_SHADER_SAMPLED_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_SHADER_STORAGE_READ_BIT specifies read access to a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebuffer">
    ///         storage
    ///         buffer
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-physical-storage-buffer">
    ///         physical
    ///         storage buffer
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer">
    ///         storage
    ///         texel buffer
    ///     </a>
    ///     , or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         image
    ///     </a>
    ///     in any shader pipeline stage.
    /// </summary>
    VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR = VK_ACCESS_2_SHADER_STORAGE_READ_BIT,

    /// <summary>
    ///     VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT specifies write access to a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebuffer">
    ///         storage
    ///         buffer
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-physical-storage-buffer">
    ///         physical
    ///         storage buffer
    ///     </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer">
    ///         storage
    ///         texel buffer
    ///     </a>
    ///     , or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         image
    ///     </a>
    ///     in any shader pipeline stage.
    /// </summary>
    VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR = VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT,

    /// <summary>
    ///     VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHRspecifies read access to a fragment shading rate
    ///     attachment during rasterization. Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHRpipeline stage.
    /// </summary>
    VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV = VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR,

    /// <summary>
    ///     VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR specifies read access to an acceleration structure as part of a
    ///     trace, build, or copy command, or to an
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-scratch">
    ///         acceleration
    ///         structure scratch buffer
    ///     </a>
    ///     as part of a build command. Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR pipeline stage or
    ///     VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR pipeline stage.
    /// </summary>
    VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV = VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR,

    /// <summary>
    ///     VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR specifies write access to an acceleration structure or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-scratch">
    ///         acceleration
    ///         structure scratch buffer
    ///     </a>
    ///     as part of a build or copy command. Such access occurs in the
    ///     VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR pipeline stage.
    /// </summary>
    VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV = VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR
}