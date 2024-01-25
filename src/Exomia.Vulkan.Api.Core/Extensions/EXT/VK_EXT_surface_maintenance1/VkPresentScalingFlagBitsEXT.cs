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
///     VkPresentScalingFlagBitsEXT - Bitmask specifying presentation scaling methods -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentScalingFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentScalingFlagBitsEXT.html</a>
/// </summary>
[Flags]
public enum VkPresentScalingFlagBitsEXT
{
    /// <summary>
    ///     VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT specifies that no scaling occurs, and pixels in the swapchain image are
    ///     mapped to one and only one pixel in the surface. The mapping between pixels is defined by the chosen presentation
    ///     gravity.
    /// </summary>
    VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT specifies that the swapchain image will be minified or
    ///     magnified such that at least one of the resulting width or height is equal to the corresponding surface dimension,
    ///     and the other resulting dimension is less than or equal to the corresponding surface dimension, with the aspect
    ///     ratio of the resulting image being identical to that of the original swapchain image.
    /// </summary>
    VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_PRESENT_SCALING_STRETCH_BIT_EXT specifies that the swapchain image will be minified or magnified such that
    ///     the resulting image dimensions are equal to those of the surface.
    /// </summary>
    VK_PRESENT_SCALING_STRETCH_BIT_EXT = 0x4
}