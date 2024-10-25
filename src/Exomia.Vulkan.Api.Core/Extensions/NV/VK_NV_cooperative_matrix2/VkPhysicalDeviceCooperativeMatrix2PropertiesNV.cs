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
///     VkPhysicalDeviceCooperativeMatrix2PropertiesNV - Structure describing cooperative matrix properties supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrix2PropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrix2PropertiesNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCooperativeMatrix2PropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_PROPERTIES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     cooperativeMatrixWorkgroupScopeMaxWorkgroupSize is the maximum number of invocations in a workgroup when the
    ///     module uses OpTypeCooperativeMatrixKHR with Scope equal to Workgroup.
    /// </summary>
    public uint cooperativeMatrixWorkgroupScopeMaxWorkgroupSize;

    /// <summary>
    ///     cooperativeMatrixFlexibleDimensionsMaxDimension is the maximum supported dimension for cooperative matrix
    ///     types when cooperativeMatrixFlexibleDimensionsis enabled.
    /// </summary>
    public uint cooperativeMatrixFlexibleDimensionsMaxDimension;

    /// <summary>
    ///     cooperativeMatrixWorkgroupScopeReservedSharedMemory is the number of bytes of shared memory reserved for the
    ///     implementation when the module uses OpTypeCooperativeMatrixKHR with Scope equal to Workgroup.
    /// </summary>
    public uint cooperativeMatrixWorkgroupScopeReservedSharedMemory;
}