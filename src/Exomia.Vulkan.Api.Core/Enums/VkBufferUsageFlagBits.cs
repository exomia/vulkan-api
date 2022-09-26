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
///     VkBufferUsageFlagBits - Bitmask specifying allowed usage of a buffer -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferUsageFlagBits.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferUsageFlagBits.html </a>
/// </summary>
[Flags]
public enum VkBufferUsageFlagBits
{
    /// <summary>
    ///     VK_BUFFER_USAGE_TRANSFER_SRC_BIT specifies that the buffer can be used as the source of a transfer command (see the definition of
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-pipeline-stages-transfer">
    ///         <code>VK_PIPELINE_STAGE_TRANSFER_BIT</code>
    ///     </a>
    ///     ).
    /// </summary>
    VK_BUFFER_USAGE_TRANSFER_SRC_BIT = 0x1,

    /// <summary> VK_BUFFER_USAGE_TRANSFER_DST_BIT specifies that the buffer can be used as the destination of a transfer command. </summary>
    VK_BUFFER_USAGE_TRANSFER_DST_BIT = 0x2,

    /// <summary> VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT specifies that the buffer can be used to create a VkBufferView suitable for occupying a VkDescriptorSet slot of type VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER. </summary>
    VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT = 0x4,

    /// <summary> VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT specifies that the buffer can be used to create a VkBufferView suitable for occupying a VkDescriptorSet slot of type VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER. </summary>
    VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT = 0x8,

    /// <summary> VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT specifies that the buffer canbe used in a VkDescriptorBufferInfo suitable for occupying a VkDescriptorSet slot either of type VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC. </summary>
    VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT = 0x10,

    /// <summary> VK_BUFFER_USAGE_STORAGE_BUFFER_BIT specifies that the buffer canbe used in a VkDescriptorBufferInfo suitable for occupying a VkDescriptorSet slot either of type VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC. </summary>
    VK_BUFFER_USAGE_STORAGE_BUFFER_BIT = 0x20,

    /// <summary>
    ///     VK_BUFFER_USAGE_INDEX_BUFFER_BIT specifies that the buffer is suitable for passing as the buffer parameter to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html"> vkCmdBindIndexBuffer </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_INDEX_BUFFER_BIT = 0x40,

    /// <summary>
    ///     VK_BUFFER_USAGE_VERTEX_BUFFER_BIT specifies that the buffer is suitable for passing as an element of the pBuffers array to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html"> vkCmdBindVertexBuffers </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_VERTEX_BUFFER_BIT = 0x80,

    /// <summary>
    ///     VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT specifies that the buffer is suitable for passing as the buffer parameter to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirect.html"> vkCmdDrawIndirect </a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirect.html"> vkCmdDrawIndexedIndirect </a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectNV.html"> vkCmdDrawMeshTasksIndirectNV </a>
    ///     ,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountNV.html">
    ///         vkCmdDrawMeshTasksIndirectCountNV
    ///     </a>
    ///     , vkCmdDrawMeshTasksIndirectEXT, vkCmdDrawMeshTasksIndirectCountEXT, or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchIndirect.html"> vkCmdDispatchIndirect </a>
    ///     . It is also suitable for passing as the buffer member of VkIndirectCommandsStreamNV, or sequencesCountBuffer or sequencesIndexBuffer or preprocessedBuffer member of VkGeneratedCommandsInfoNV
    /// </summary>
    VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT = 0x100,

    /// <summary>
    ///     VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT specifies that the buffer can be used to retrieve a buffer device address via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddress.html"> vkGetBufferDeviceAddress </a>
    ///     and use that address to access the buffer&#8217;s memory from a shader.
    /// </summary>
    VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT = 0x20000,

    /// <summary>
    ///     VK_BUFFER_USAGE_VIDEO_DECODE_SRC_BIT_KHR specifies that the buffer can be used as the source bitstream buffer in a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations"> video decode operation </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_VIDEO_DECODE_SRC_BIT_KHR = 0x2000,

    /// <summary>
    ///     VK_BUFFER_USAGE_VIDEO_DECODE_DST_BIT_KHR specifies that the buffer can be used as the destination status buffer in a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations"> video decode operation </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_VIDEO_DECODE_DST_BIT_KHR = 0x4000,

    /// <summary>
    ///     VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT specifies that the buffer is suitable for using for binding as a transform feedback buffer with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindTransformFeedbackBuffersEXT.html">
    ///         vkCmdBindTransformFeedbackBuffersEXT
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = 0x800,

    /// <summary>
    ///     VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXTspecifies that the buffer is suitable for using as a counter buffer with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginTransformFeedbackEXT.html"> vkCmdBeginTransformFeedbackEXT </a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndTransformFeedbackEXT.html"> vkCmdEndTransformFeedbackEXT </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = 0x1000,

    /// <summary>
    ///     VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT specifies that the buffer is suitable for passing as the buffer parameter to
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginConditionalRenderingEXT.html">
    ///         vkCmdBeginConditionalRenderingEXT
    ///     </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT = 0x200,

    /// <summary>
    ///     VK_BUFFER_USAGE_RESERVED_25_BIT_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits </a>
    /// </summary>
    VK_BUFFER_USAGE_RESERVED_25_BIT_AMD = 0x2000000,

    /// <summary>
    ///     VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHRspecifies that the buffer is suitable for use as a read-only input to an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-building"> acceleration structure build </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = 0x80000,

    /// <summary>
    ///     VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR specifies that the buffer is suitable for storage space for a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureKHR.html"> VkAccelerationStructureKHR </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR = 0x100000,

    /// <summary>
    ///     VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR specifies that the buffer is suitable for use as a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#shader-binding-table"> Shader Binding Table </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR = 0x400,

    /// <summary>
    ///     VK_BUFFER_USAGE_RESERVED_18_BIT_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits </a>
    /// </summary>
    VK_BUFFER_USAGE_RESERVED_18_BIT_QCOM = 0x40000,

    /// <summary>
    ///     VK_BUFFER_USAGE_VIDEO_ENCODE_DST_BIT_KHR specifies that the buffer can be used as the destination bitstream buffer in a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations"> video encode operation </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_VIDEO_ENCODE_DST_BIT_KHR = 0x8000,

    /// <summary>
    ///     VK_BUFFER_USAGE_VIDEO_ENCODE_SRC_BIT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits </a>
    /// </summary>
    VK_BUFFER_USAGE_VIDEO_ENCODE_SRC_BIT_KHR = 0x10000,

    /// <summary>
    ///     VK_BUFFER_USAGE_RESERVED_21_BIT_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits </a>
    /// </summary>
    VK_BUFFER_USAGE_RESERVED_21_BIT_AMD = 0x200000,

    /// <summary>
    ///     VK_BUFFER_USAGE_RESERVED_22_BIT_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits </a>
    /// </summary>
    VK_BUFFER_USAGE_RESERVED_22_BIT_AMD = 0x400000,

    /// <summary>
    ///     VK_BUFFER_USAGE_RESERVED_23_BIT_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits </a>
    /// </summary>
    VK_BUFFER_USAGE_RESERVED_23_BIT_NV = 0x800000,

    /// <summary>
    ///     VK_BUFFER_USAGE_RESERVED_24_BIT_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBufferUsageFlagBits </a>
    /// </summary>
    VK_BUFFER_USAGE_RESERVED_24_BIT_NV = 0x1000000,

    /// <summary>
    ///     VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR specifies that the buffer is suitable for use as a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#shader-binding-table"> Shader Binding Table </a>
    ///     .
    /// </summary>
    VK_BUFFER_USAGE_RAY_TRACING_BIT_NV = VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR,

    /// <summary>
    ///     VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT specifies that the buffer can be used to retrieve a buffer device address via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddress.html"> vkGetBufferDeviceAddress </a>
    ///     and use that address to access the buffer&#8217;s memory from a shader.
    /// </summary>
    VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT = VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT,

    /// <summary>
    ///     VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT specifies that the buffer can be used to retrieve a buffer device address via
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddress.html"> vkGetBufferDeviceAddress </a>
    ///     and use that address to access the buffer&#8217;s memory from a shader.
    /// </summary>
    VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_KHR = VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT
}