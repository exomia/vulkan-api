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
///     VkAccelerationStructureGeometryDataKHR - Union specifying acceleration structure geometry data -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryDataKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryDataKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public struct VkAccelerationStructureGeometryDataKHR
{
    /// <summary> triangles is a VkAccelerationStructureGeometryTrianglesDataKHR structure. </summary>
    [FieldOffset(0)]
    public VkAccelerationStructureGeometryTrianglesDataKHR triangles;

    /// <summary> aabbs is a VkAccelerationStructureGeometryAabbsDataKHRstructure. </summary>
    [FieldOffset(0)]
    public VkAccelerationStructureGeometryAabbsDataKHR aabbs;

    /// <summary> instances is a VkAccelerationStructureGeometryInstancesDataKHR structure. </summary>
    [FieldOffset(0)]
    public VkAccelerationStructureGeometryInstancesDataKHR instances;
}