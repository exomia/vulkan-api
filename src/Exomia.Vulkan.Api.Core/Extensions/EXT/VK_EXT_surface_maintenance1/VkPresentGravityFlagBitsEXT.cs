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
///     VkPresentGravityFlagBitsEXT - Bitmask specifying presentation pixel gravity on either the x or y axis -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentGravityFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentGravityFlagBitsEXT.html</a>
/// </summary>
[Flags]
public enum VkPresentGravityFlagBitsEXT
{
    /// <summary>
    ///     VK_PRESENT_GRAVITY_MIN_BIT_EXT means that the pixels will gravitate towards the top or left side of the
    ///     surface.
    /// </summary>
    VK_PRESENT_GRAVITY_MIN_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_PRESENT_GRAVITY_MAX_BIT_EXT means that the pixels will gravitate towards the bottom or right side of the
    ///     surface.
    /// </summary>
    VK_PRESENT_GRAVITY_MAX_BIT_EXT = 0x2,

    /// <summary>VK_PRESENT_GRAVITY_CENTERED_BIT_EXT means that the pixels will be centered in the surface.</summary>
    VK_PRESENT_GRAVITY_CENTERED_BIT_EXT = 0x4
}