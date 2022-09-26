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
///     VkLineRasterizationModeEXT - Line rasterization modes -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLineRasterizationModeEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLineRasterizationModeEXT.html </a>
/// </summary>
public enum VkLineRasterizationModeEXT
{
    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT is equivalent to VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT if
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLimits.html"> VkPhysicalDeviceLimits </a>
    ///     ::strictLines is VK_TRUE, otherwise lines are drawn as non-strictLines parallelograms. Both of these modes are defined in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-lines-basic"> Basic Line Segment Rasterization </a>
    ///     .
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT = 0,

    /// <summary> VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT specifies lines drawn as if they were rectangles extruded from the line </summary>
    VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT = 1,

    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT specifies lines drawn by determining which pixel diamonds the line intersects and exits, as defined in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-lines-bresenham"> Bresenham Line Segment Rasterization </a>
    ///     .
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT = 2,

    /// <summary>
    ///     VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT specifies lines drawn if they were rectangles extruded from the line, with alpha falloff, as defined in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-lines-smooth"> Smooth Lines </a>
    ///     .
    /// </summary>
    VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT = 3
}