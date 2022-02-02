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
///     VkPolygonMode - Control polygon rasterization mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPolygonMode.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPolygonMode.html</a>
/// </summary>
public enum VkPolygonMode
{
    /// <summary>
    ///     VK_POLYGON_MODE_FILL specifies that polygons are rendered using the polygon rasterization rules in this
    ///     section.
    /// </summary>
    VK_POLYGON_MODE_FILL = 0,

    /// <summary>VK_POLYGON_MODE_LINE specifies that polygon edges are drawn as line segments.</summary>
    VK_POLYGON_MODE_LINE = 1,

    /// <summary>VK_POLYGON_MODE_POINT specifies that polygon vertices are drawn as points.</summary>
    VK_POLYGON_MODE_POINT = 2,

    /// <summary>
    ///     VK_POLYGON_MODE_FILL_RECTANGLE_NV specifies that polygons are rendered using polygon rasterization rules,
    ///     modified to consider a sample within the primitive if the sample location is inside the axis-aligned bounding box
    ///     of the triangle after projection. Note that the barycentric weights used in attribute interpolation canextend
    ///     outside the range [0,1] when these primitives are shaded. Special treatment is given to a sample position on the
    ///     boundary edge of the bounding box. In such a case, if two rectangles lie on either side of a common edge (with
    ///     identical endpoints) on which a sample position lies, then exactly one of the triangles must produce a fragment
    ///     that covers that sample during rasterization.
    /// </summary>
    VK_POLYGON_MODE_FILL_RECTANGLE_NV = 1000153000
}