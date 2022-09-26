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
///     VkGeometryAABBNV - Structure specifying axis-aligned bounding box geometry in a bottom-level acceleration structure -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryAABBNV.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryAABBNV.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryAABBNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> aabbData is the buffer containing axis-aligned bounding box data. </summary>
    public VkBuffer aabbData;

    /// <summary> numAABBs is the number of AABBs in this geometry. </summary>
    public uint numAABBs;

    /// <summary> stride is the stride in bytes between AABBs in aabbData. </summary>
    public uint stride;

    /// <summary> offset is the offset in bytes of the first AABB in aabbData. </summary>
    public VkDeviceSize offset;
}