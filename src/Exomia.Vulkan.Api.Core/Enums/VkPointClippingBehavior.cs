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
///     VkPointClippingBehavior - Enum specifying the point clipping behavior -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPointClippingBehavior.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPointClippingBehavior.html</a>
/// </summary>
public enum VkPointClippingBehavior
{
    /// <summary>
    ///     VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES specifies that the primitive is discarded if the vertex lies
    ///     outside any clip plane, including the planes bounding the view volume.
    /// </summary>
    VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES = 0,

    /// <summary>
    ///     VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY specifies that the primitive is discarded only if the vertex
    ///     lies outside any user clip plane.
    /// </summary>
    VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY = 1,

    /// <summary>
    ///     VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES specifies that the primitive is discarded if the vertex lies
    ///     outside any clip plane, including the planes bounding the view volume.
    /// </summary>
    VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES_KHR = VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES,

    /// <summary>
    ///     VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY specifies that the primitive is discarded only if the vertex
    ///     lies outside any user clip plane.
    /// </summary>
    VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY_KHR = VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY
}