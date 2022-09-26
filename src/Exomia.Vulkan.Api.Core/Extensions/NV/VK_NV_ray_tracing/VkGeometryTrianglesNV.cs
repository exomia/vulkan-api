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
///     VkGeometryTrianglesNV - Structure specifying a triangle geometry in a bottom-level acceleration structure -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryTrianglesNV.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryTrianglesNV.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryTrianglesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> vertexData is the buffer containing vertex data for this geometry. </summary>
    public VkBuffer vertexData;

    /// <summary> vertexOffset is the offset in bytes within vertexDatacontaining vertex data for this geometry. </summary>
    public VkDeviceSize vertexOffset;

    /// <summary> vertexCount is the number of valid vertices. </summary>
    public uint vertexCount;

    /// <summary> vertexStride is the stride in bytes between each vertex. </summary>
    public VkDeviceSize vertexStride;

    /// <summary> vertexFormat is a VkFormat describing the format of each vertex element. </summary>
    public VkFormat vertexFormat;

    /// <summary> indexData is the buffer containing index data for this geometry. </summary>
    public VkBuffer indexData;

    /// <summary> indexOffset is the offset in bytes within indexDatacontaining index data for this geometry. </summary>
    public VkDeviceSize indexOffset;

    /// <summary> indexCount is the number of indices to include in this geometry. </summary>
    public uint indexCount;

    /// <summary> indexType is a VkIndexType describing the format of each index. </summary>
    public VkIndexType indexType;

    /// <summary> transformData is an optional buffer containing an VkTransformMatrixNV structure defining a transformation to be applied to this geometry. </summary>
    public VkBuffer transformData;

    /// <summary> transformOffset is the offset in bytes in transformData of the transform information described above. </summary>
    public VkDeviceSize transformOffset;
}