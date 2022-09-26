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
///     VkPrimitiveTopology - Supported primitive topologies -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPrimitiveTopology.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPrimitiveTopology.html </a>
/// </summary>
public enum VkPrimitiveTopology
{
    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_POINT_LIST specifies a series of
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-point-lists"> separate point primitives </a>
    ///     .
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_POINT_LIST = 0,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_LINE_LIST specifies a series of
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-line-lists"> separate line primitives </a>
    ///     .
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_LINE_LIST = 1,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_LINE_STRIP specifies a series of
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-line-strips"> connected line primitives </a>
    ///     with consecutive lines sharing a vertex.
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_LINE_STRIP = 2,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST specifies a series of
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-triangle-lists"> separate triangle primitives </a>
    ///     .
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST = 3,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP specifies a series of
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-triangle-strips"> connected triangle primitives </a>
    ///     with consecutive triangles sharing an edge.
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP = 4,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN specifies a series of
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-triangle-fans"> connected triangle primitives </a>
    ///     with all triangles sharing a common vertex. If the VK_KHR_portability_subset extension is enabled, and
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePortabilitySubsetFeaturesKHR.html">
    ///         VkPhysicalDevicePortabilitySubsetFeaturesKHR
    ///     </a>
    ///     ::triangleFansis VK_FALSE, then triangle fans are not supported by the implementation, and VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN must not be used.
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN = 5,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY specifies a series of
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-line-lists-with-adjacency">
    ///         separate line primitives with adjacency
    ///     </a>
    ///     .
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY = 6,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY specifies a series of
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-line-strips-with-adjacency">
    ///         connected line primitives with adjacency
    ///     </a>
    ///     , with consecutive primitives sharing three vertices.
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY = 7,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY specifies a series of
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-triangle-lists-with-adjacency">
    ///         separate triangle primitives with adjacency
    ///     </a>
    ///     .
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY = 8,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY specifies
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-triangle-strips-with-adjacency">
    ///         connected triangle primitives with adjacency
    ///     </a>
    ///     , with consecutive triangles sharing an edge.
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY = 9,

    /// <summary>
    ///     VK_PRIMITIVE_TOPOLOGY_PATCH_LIST specifies
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-patch-lists"> separate patch primitives </a>
    ///     .
    /// </summary>
    VK_PRIMITIVE_TOPOLOGY_PATCH_LIST = 10
}