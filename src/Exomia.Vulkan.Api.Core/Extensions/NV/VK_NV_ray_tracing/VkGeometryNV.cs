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
///     VkGeometryNV - Structure specifying a geometry in a bottom-level acceleration structure -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeometryNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GEOMETRY_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>geometryType specifies the VkGeometryTypeKHR which this geometry refers to.</summary>
    public VkGeometryTypeKHR geometryType;

    /// <summary>geometry contains the geometry data as described in VkGeometryDataNV.</summary>
    public VkGeometryDataNV geometry;

    /// <summary>flags has VkGeometryFlagBitsKHR describing options for this geometry.</summary>
    public VkGeometryFlagsKHR flags;
}