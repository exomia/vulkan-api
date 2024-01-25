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
///     VkAccelerationStructureGeometryTrianglesDataKHR - Structure specifying a triangle geometry in a bottom-level
///     acceleration structure -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryTrianglesDataKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryTrianglesDataKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>vertexFormat is the VkFormat of each vertex element.</summary>
    public VkFormat vertexFormat;

    /// <summary>vertexData is a device or host address to memory containing vertex data for this geometry.</summary>
    public VkDeviceOrHostAddressConstKHR vertexData;

    /// <summary>vertexStride is the stride in bytes between each vertex.</summary>
    public VkDeviceSize vertexStride;

    /// <summary>maxVertex is the highest index of a vertex that will be addressed by a build command using this structure.</summary>
    public uint maxVertex;

    /// <summary>indexType is the VkIndexType of each index element.</summary>
    public VkIndexType indexType;

    /// <summary>indexData is a device or host address to memory containing index data for this geometry.</summary>
    public VkDeviceOrHostAddressConstKHR indexData;

    /// <summary>
    ///     transformData is a device or host address to memory containing an optional reference to a VkTransformMatrixKHR
    ///     structure describing a transformation from the space in which the vertices in this geometry are described to the
    ///     space in which the acceleration structure is defined.
    /// </summary>
    public VkDeviceOrHostAddressConstKHR transformData;
}