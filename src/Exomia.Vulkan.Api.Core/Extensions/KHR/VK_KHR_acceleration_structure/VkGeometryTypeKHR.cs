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
///     VkGeometryTypeKHR - Enum specifying which type of geometry is provided -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryTypeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryTypeKHR.html</a>
/// </summary>
public enum VkGeometryTypeKHR
{
    /// <summary>VK_GEOMETRY_TYPE_TRIANGLES_KHR specifies a geometry type consisting of triangles.</summary>
    VK_GEOMETRY_TYPE_TRIANGLES_KHR = 0,

    /// <summary>VK_GEOMETRY_TYPE_AABBS_KHR specifies a geometry type consisting of axis-aligned bounding boxes.</summary>
    VK_GEOMETRY_TYPE_AABBS_KHR = 1,

    /// <summary>VK_GEOMETRY_TYPE_INSTANCES_KHR specifies a geometry type consisting of acceleration structure instances.</summary>
    VK_GEOMETRY_TYPE_INSTANCES_KHR = 2,

    /// <summary>VK_GEOMETRY_TYPE_TRIANGLES_KHR specifies a geometry type consisting of triangles.</summary>
    VK_GEOMETRY_TYPE_TRIANGLES_NV = VK_GEOMETRY_TYPE_TRIANGLES_KHR,

    /// <summary>VK_GEOMETRY_TYPE_AABBS_KHR specifies a geometry type consisting of axis-aligned bounding boxes.</summary>
    VK_GEOMETRY_TYPE_AABBS_NV = VK_GEOMETRY_TYPE_AABBS_KHR
}