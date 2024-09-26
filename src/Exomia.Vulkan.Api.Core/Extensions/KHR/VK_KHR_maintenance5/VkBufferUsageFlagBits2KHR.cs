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
///     VkBufferUsageFlagBits2KHR - Bitmask controlling how a pipeline is created -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferUsageFlagBits2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferUsageFlagBits2KHR.html</a>
/// </summary>
[Flags]
public enum VkBufferUsageFlagBits2KHR : ulong
{
    /// <summary>
    ///     VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT_KHR specifies that the buffer can be used as the source of a transfer command
    ///     (see the definition of
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-pipeline-stages-transfer">
    ///         <code>VK_PIPELINE_STAGE_TRANSFER_BIT</code>
    ///     </a>
    ///     ).
    /// </summary>
    VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_TRANSFER_DST_BIT_KHR specifies that the buffer can be used as the destination of a transfer
    ///     command.
    /// </summary>
    VK_BUFFER_USAGE_2_TRANSFER_DST_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR specifies that the buffer can be used to create a VkBufferView
    ///     suitable for occupying a VkDescriptorSet slot of type VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER.
    /// </summary>
    VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT_KHR specifies that the buffer can be used to create a VkBufferView
    ///     suitable for occupying a VkDescriptorSet slot of type VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER.
    /// </summary>
    VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT_KHR specifies that the buffer can be used in a VkDescriptorBufferInfo
    ///     suitable for occupying a VkDescriptorSet slot either of type VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.
    /// </summary>
    VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT_KHR = 0x10,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT_KHR specifies that the buffer can be used in a VkDescriptorBufferInfo
    ///     suitable for occupying a VkDescriptorSet slot either of type VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    ///     VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.
    /// </summary>
    VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT_KHR = 0x20,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT_KHR specifies that the buffer     is suitable for passing as the buffer
    ///     parameter to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer2KHR.html">vkCmdBindIndexBuffer2KHR</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html">vkCmdBindIndexBuffer</a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT_KHR = 0x40,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT_KHR specifies that the buffer is suitable for passing as an element of the
    ///     pBuffers array to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html">vkCmdBindVertexBuffers</a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT_KHR = 0x80,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT_KHR specifies that the buffer is suitable for passing as the buffer
    ///     parameter to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirect.html">vkCmdDrawIndirect</a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirect.html">vkCmdDrawIndexedIndirect</a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectNV.html">vkCmdDrawMeshTasksIndirectNV</a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountNV.html">
    ///         vkCmdDrawMeshTasksIndirectCountNV
    ///     </a>
    ///     , vkCmdDrawMeshTasksIndirectEXT, vkCmdDrawMeshTasksIndirectCountEXT,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawClusterIndirectHUAWEI.html">vkCmdDrawClusterIndirectHUAWEI</a>
    ///     , or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchIndirect.html">vkCmdDispatchIndirect</a>
    ///     . It is also suitable for passing as the buffer member of VkIndirectCommandsStreamNV, or sequencesCountBuffer or
    ///     sequencesIndexBuffer or preprocessedBuffer member of VkGeneratedCommandsInfoNV. It is also suitable for passing as
    ///     the underlying buffer of either the preprocessAddress or sequenceCountAddress members of
    ///     VkGeneratedCommandsInfoEXT.
    /// </summary>
    VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT_KHR = 0x100,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_EXECUTION_GRAPH_SCRATCH_BIT_AMDX specifies that the buffer can be used for as scratch memory for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#executiongraphs">
    ///         execution graph
    ///         dispatch
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_EXECUTION_GRAPH_SCRATCH_BIT_AMDX = 0x2000000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_CONDITIONAL_RENDERING_BIT_EXT specifies that the buffer is suitable for passing as the
    ///     buffer parameter to
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginConditionalRenderingEXT.html">
    ///         vkCmdBeginConditionalRenderingEXT
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_CONDITIONAL_RENDERING_BIT_EXT = 0x200,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR specifies that the buffer is suitable for use as a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#shader-binding-table">
    ///         Shader
    ///         Binding Table
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR = 0x400,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT specifies that the buffer is suitable for using for binding as
    ///     a transform feedback buffer with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindTransformFeedbackBuffersEXT.html">
    ///         vkCmdBindTransformFeedbackBuffersEXT
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = 0x800,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXTspecifies that the buffer is suitable for using as
    ///     a counter buffer with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginTransformFeedbackEXT.html">vkCmdBeginTransformFeedbackEXT</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndTransformFeedbackEXT.html">vkCmdEndTransformFeedbackEXT</a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = 0x1000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR specifies that the buffer can be used as the source video bitstream
    ///     buffer in a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operation
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR = 0x2000,

    /// <summary>VK_BUFFER_USAGE_2_VIDEO_DECODE_DST_BIT_KHR is reserved for future use.</summary>
    VK_BUFFER_USAGE_2_VIDEO_DECODE_DST_BIT_KHR = 0x4000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR specifies that the buffer can be used as the destination video bitstream
    ///     buffer in a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operation
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR = 0x8000,

    /// <summary>VK_BUFFER_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR is reserved for future use.</summary>
    VK_BUFFER_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR = 0x10000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT_KHR specifies that the buffer can be used to retrieve a buffer
    ///     device address via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddress.html">vkGetBufferDeviceAddress</a>
    ///     and use that address to access the buffer&#8217;s memory from a shader.
    /// </summary>
    VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT_KHR = 0x20000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHRspecifies that the buffer is suitable for use
    ///     as a read-only input to an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-building">
    ///         acceleration
    ///         structure build
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = 0x80000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR specifies that the buffer is suitable for storage
    ///     space for a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureKHR.html">VkAccelerationStructureKHR</a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR = 0x100000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT specifies that the buffer is suitable to contain sampler
    ///     and combined image sampler descriptors when bound as a descriptor buffer. Buffers containing combined image sampler
    ///     descriptors must also specify VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT.
    /// </summary>
    VK_BUFFER_USAGE_2_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT = 0x200000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT specifies that the buffer is suitable to contain resource
    ///     descriptors when bound as a descriptor buffer.
    /// </summary>
    VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT = 0x400000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXTspecifies that the buffer, when bound, can be used
    ///     by the implementation to support push descriptors when using descriptor buffers.
    /// </summary>
    VK_BUFFER_USAGE_2_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT = 0x4000000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits2KHR">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits2KHR</a>
    /// </summary>
    VK_BUFFER_USAGE_2_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT = 0x800000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_MICROMAP_STORAGE_BIT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits2KHR">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits2KHR</a>
    /// </summary>
    VK_BUFFER_USAGE_2_MICROMAP_STORAGE_BIT_EXT = 0x1000000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_PREPROCESS_BUFFER_BIT_EXT specifies that the buffer can be used as a preprocess buffer for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#device-generated-commands">
    ///         Device-Generated
    ///         Commands
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_PREPROCESS_BUFFER_BIT_EXT = 0x80000000,

    /// <summary>
    ///     VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR specifies that the buffer is suitable for use as a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#shader-binding-table">
    ///         Shader
    ///         Binding Table
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_2_RAY_TRACING_BIT_NV = VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR
}