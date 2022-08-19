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
///     VkQueryType - Specify the type of queries managed by a query pool -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryType.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryType.html</a>
/// </summary>
public enum VkQueryType
{
    /// <summary>
    ///     VK_QUERY_TYPE_OCCLUSION specifies an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-occlusion">
    ///         occlusion
    ///         query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_OCCLUSION = 0,

    /// <summary>
    ///     VK_QUERY_TYPE_PIPELINE_STATISTICS specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-pipestats">
    ///         pipeline
    ///         statistics query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_PIPELINE_STATISTICS = 1,

    /// <summary>
    ///     VK_QUERY_TYPE_TIMESTAMP specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-timestamps">
    ///         timestamp
    ///         query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_TIMESTAMP = 2,

    /// <summary>
    ///     VK_QUERY_TYPE_RESULT_STATUS_ONLY_KHR specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-result-status-only">
    ///         result
    ///         status query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_RESULT_STATUS_ONLY_KHR = 1000023000,

    /// <summary>
    ///     VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-transform-feedback">
    ///         transform
    ///         feedback query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT = 1000028004,

    /// <summary>
    ///     VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-performance">
    ///         performance
    ///         query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR = 1000116000,

    /// <summary>
    ///     VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-copying">
    ///         acceleration
    ///         structure size query
    ///     </a>
    ///     for use with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkCmdWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR = 1000150000,

    /// <summary>
    ///     VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHRspecifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-copying">
    ///         serialization
    ///         acceleration structure size query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR = 1000150001,

    /// <summary>
    ///     VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV specifies an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-copying">
    ///         acceleration
    ///         structure size query
    ///     </a>
    ///     for use with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesNV.html">
    ///         vkCmdWriteAccelerationStructuresPropertiesNV
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV = 1000165000,

    /// <summary>
    ///     VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-performance-intel">
    ///         Intel
    ///         performance query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL = 1000210000,

    /// <summary>
    ///     VK_QUERY_TYPE_VIDEO_ENCODE_BITSTREAM_BUFFER_RANGE_KHR specifies a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-video-encode-bitstream-buffer-range">
    ///         video
    ///         encode bitstream range query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_VIDEO_ENCODE_BITSTREAM_BUFFER_RANGE_KHR = 1000299000,

    /// <summary>
    ///     VK_QUERY_TYPE_PRIMITIVES_GENERATED_EXT specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-primitives-generated">
    ///         primitives
    ///         generated query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_PRIMITIVES_GENERATED_EXT = 1000382000,

    /// <summary>
    ///     VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_BOTTOM_LEVEL_POINTERS_KHRspecifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#serialized-as-header">
    ///         serialization
    ///         acceleration structure pointer count query
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_BOTTOM_LEVEL_POINTERS_KHR = 1000386000,

    /// <summary>
    ///     VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SIZE_KHR specifies an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure-copying">
    ///         acceleration
    ///         structure size query
    ///     </a>
    ///     for use with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkCmdWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SIZE_KHR = 1000386001
}