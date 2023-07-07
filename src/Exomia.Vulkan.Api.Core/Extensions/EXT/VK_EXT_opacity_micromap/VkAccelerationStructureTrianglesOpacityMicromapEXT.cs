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
///     VkAccelerationStructureTrianglesOpacityMicromapEXT - Structure specifying an opacity micromap in a bottom-level
///     acceleration structure -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureTrianglesOpacityMicromapEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureTrianglesOpacityMicromapEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkAccelerationStructureGeometryTrianglesDataKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkAccelerationStructureGeometryTrianglesDataKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureTrianglesOpacityMicromapEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>indexType is the type of triangle indices used when indexing this micromap</summary>
    public VkIndexType indexType;

    /// <summary>indexBuffer is the address containing the triangle indices</summary>
    public VkDeviceOrHostAddressConstKHR indexBuffer;

    /// <summary>indexStride is the byte stride between triangle indices</summary>
    public VkDeviceSize indexStride;

    /// <summary>baseTriangle is the base value added to the non-negative triangle indices</summary>
    public uint baseTriangle;

    /// <summary>
    ///     usageCountsCount specifies the number of usage counts structures that will be used to determine the size of
    ///     this micromap.
    /// </summary>
    public uint usageCountsCount;

    /// <summary>pUsageCounts is a pointer to an array of VkMicromapUsageEXTstructures.</summary>
    public VkMicromapUsageEXT* pUsageCounts;

    /// <summary>ppUsageCounts is a pointer to an array of pointers to VkMicromapUsageEXT structures.</summary>
    public VkMicromapUsageEXT** ppUsageCounts;

    /// <summary>micromap is the handle to the micromap object to include in this geometry</summary>
    public VkMicromapEXT micromap;
}