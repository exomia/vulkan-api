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
///     VkGeometryDataNV - Structure specifying geometry in a bottom-level acceleration structure -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryDataNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryDataNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkGeometryDataNV
{
    /// <summary>triangles contains triangle data if VkGeometryNV::geometryType is VK_GEOMETRY_TYPE_TRIANGLES_NV.</summary>
    public VkGeometryTrianglesNV triangles;

    /// <summary>aabbs contains axis-aligned bounding box data if VkGeometryNV::geometryType is VK_GEOMETRY_TYPE_AABBS_NV.</summary>
    public VkGeometryAABBNV aabbs;
}