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
///     VkGeometryInstanceFlagBitsKHR - Instance flag bits -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryInstanceFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryInstanceFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkGeometryInstanceFlagBitsKHR
{
    /// <summary>VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR disables face culling for this instance.</summary>
    VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR indicates that the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#ray-traversal-culling-face">
    ///         facing
    ///         determination
    ///     </a>
    ///     for geometry in this instance is inverted. Because the facing is determined in object space,
    ///     an instance transform does not change the winding, but a geometry transform does.
    /// </summary>
    VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR causes this instance to act as though VK_GEOMETRY_OPAQUE_BIT_KHR
    ///     were specified on all geometries referenced by this instance. This behavior can be overridden by the SPIR-V
    ///     NoOpaqueKHR ray flag.
    /// </summary>
    VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR causes this instance to act as though VK_GEOMETRY_OPAQUE_BIT_KHR
    ///     were not specified on all geometries referenced by this instance. This behavior can be overridden by the SPIR-V
    ///     OpaqueKHR ray flag.
    /// </summary>
    VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkGeometryInstanceFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkGeometryInstanceFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_EXT = 0x10,

    /// <summary>
    ///     VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkGeometryInstanceFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkGeometryInstanceFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT = 0x20,

    /// <summary>
    ///     VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR indicates that the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#ray-traversal-culling-face">
    ///         facing
    ///         determination
    ///     </a>
    ///     for geometry in this instance is inverted. Because the facing is determined in object space,
    ///     an instance transform does not change the winding, but a geometry transform does.
    /// </summary>
    VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR = VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR,

    /// <summary>VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR disables face culling for this instance.</summary>
    VK_GEOMETRY_INSTANCE_TRIANGLE_CULL_DISABLE_BIT_NV = VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR,

    /// <summary>
    ///     VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkGeometryInstanceFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkGeometryInstanceFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV = VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR,

    /// <summary>
    ///     VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR causes this instance to act as though VK_GEOMETRY_OPAQUE_BIT_KHR
    ///     were specified on all geometries referenced by this instance. This behavior can be overridden by the SPIR-V
    ///     NoOpaqueKHR ray flag.
    /// </summary>
    VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_NV = VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR,

    /// <summary>
    ///     VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR causes this instance to act as though VK_GEOMETRY_OPAQUE_BIT_KHR
    ///     were not specified on all geometries referenced by this instance. This behavior can be overridden by the SPIR-V
    ///     OpaqueKHR ray flag.
    /// </summary>
    VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_NV = VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR
}