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
///     VkSurfaceTransformFlagBitsKHR - Presentation transforms supported on a device -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceTransformFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceTransformFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkSurfaceTransformFlagBitsKHR
{
    /// <summary>VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR specifies that image content is presented without being transformed.</summary>
    VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR = 1 << 0,

    /// <summary>VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR specifies that image content is rotated 90 degrees clockwise.</summary>
    VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR = 1 << 1,

    /// <summary>VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR specifies that image content is rotated 180 degrees clockwise.</summary>
    VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR = 1 << 2,

    /// <summary>VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR specifies that image content is rotated 270 degrees clockwise.</summary>
    VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR = 1 << 3,

    /// <summary>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR specifies that image content is mirrored horizontally.</summary>
    VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR = 1 << 4,

    /// <summary>
    ///     VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR specifies that image content is mirrored
    ///     horizontally, then rotated 90 degrees clockwise.
    /// </summary>
    VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR = 1 << 5,

    /// <summary>
    ///     VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHRspecifies that image content is mirrored
    ///     horizontally, then rotated 180 degrees clockwise.
    /// </summary>
    VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR = 1 << 6,

    /// <summary>
    ///     VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHRspecifies that image content is mirrored
    ///     horizontally, then rotated 270 degrees clockwise.
    /// </summary>
    VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR = 1 << 7,

    /// <summary>
    ///     VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR specifies that the presentation transform is not specified, and is
    ///     instead determined by platform-specific considerations and mechanisms outside Vulkan.
    /// </summary>
    VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR = 1 << 8
}