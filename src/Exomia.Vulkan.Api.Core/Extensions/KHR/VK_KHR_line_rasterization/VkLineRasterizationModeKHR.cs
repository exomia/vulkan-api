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
///     VkLineRasterizationModeKHR - Line rasterization modes -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLineRasterizationModeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLineRasterizationModeKHR.html</a>
/// </summary>
public enum VkLineRasterizationModeKHR
{
    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_DEFAULT_KHR is equivalent to VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR if
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLimits.html">VkPhysicalDeviceLimits</a>
    ///     ::strictLines is VK_TRUE, otherwise lines are drawn as non-strictLines parallelograms. Both of these modes are
    ///     defined in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-lines-basic">
    ///         Basic
    ///         Line Segment Rasterization
    ///     </a>
    ///     .
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_DEFAULT_KHR = 0,

    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR specifies lines drawn as if they were rectangles extruded from the
    ///     line
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR = 1,

    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_BRESENHAM_KHR specifies lines drawn by determining which pixel diamonds the line
    ///     intersects and exits, as defined in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-lines-bresenham">
    ///         Bresenham
    ///         Line Segment Rasterization
    ///     </a>
    ///     .
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_BRESENHAM_KHR = 2,

    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_KHR specifies lines drawn if they were rectangles extruded from
    ///     the line, with alpha falloff, as defined in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-lines-smooth">
    ///         Smooth
    ///         Lines
    ///     </a>
    ///     .
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_KHR = 3,

    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_DEFAULT_KHR is equivalent to VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR if
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLimits.html">VkPhysicalDeviceLimits</a>
    ///     ::strictLines is VK_TRUE, otherwise lines are drawn as non-strictLines parallelograms. Both of these modes are
    ///     defined in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-lines-basic">
    ///         Basic
    ///         Line Segment Rasterization
    ///     </a>
    ///     .
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT = VK_LINE_RASTERIZATION_MODE_DEFAULT_KHR,

    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR specifies lines drawn as if they were rectangles extruded from the
    ///     line
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT = VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR,

    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_BRESENHAM_KHR specifies lines drawn by determining which pixel diamonds the line
    ///     intersects and exits, as defined in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-lines-bresenham">
    ///         Bresenham
    ///         Line Segment Rasterization
    ///     </a>
    ///     .
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT = VK_LINE_RASTERIZATION_MODE_BRESENHAM_KHR,

    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_KHR specifies lines drawn if they were rectangles extruded from
    ///     the line, with alpha falloff, as defined in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-lines-smooth">
    ///         Smooth
    ///         Lines
    ///     </a>
    ///     .
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT = VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_KHR
}