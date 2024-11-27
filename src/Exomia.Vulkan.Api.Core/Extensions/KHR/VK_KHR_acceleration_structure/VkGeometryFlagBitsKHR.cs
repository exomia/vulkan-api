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
///     VkGeometryFlagBitsKHR - Bitmask specifying additional parameters for a geometry -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkGeometryFlagBitsKHR
{
    /// <summary>
    ///     VK_GEOMETRY_OPAQUE_BIT_KHR specifies that this geometry does not invoke the any-hit shaders even if present in
    ///     a hit group.
    /// </summary>
    VK_GEOMETRY_OPAQUE_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR specifies that the implementation must only call the
    ///     any-hit shader a single time for each primitive in this geometry. If this bit is absent an implementation may
    ///     invoke the any-hit shader more than once for this geometry.
    /// </summary>
    VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_GEOMETRY_OPAQUE_BIT_KHR specifies that this geometry does not invoke the any-hit shaders even if present in
    ///     a hit group.
    /// </summary>
    VK_GEOMETRY_OPAQUE_BIT_NV = VK_GEOMETRY_OPAQUE_BIT_KHR,

    /// <summary>
    ///     VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR specifies that the implementation must only call the
    ///     any-hit shader a single time for each primitive in this geometry. If this bit is absent an implementation may
    ///     invoke the any-hit shader more than once for this geometry.
    /// </summary>
    VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV = VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR
}