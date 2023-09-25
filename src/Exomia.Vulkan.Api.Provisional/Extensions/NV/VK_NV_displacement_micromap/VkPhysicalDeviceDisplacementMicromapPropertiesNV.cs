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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkPhysicalDeviceDisplacementMicromapPropertiesNV - Structure describing the displacement micromap properties of a
///     physical device -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDisplacementMicromapPropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDisplacementMicromapPropertiesNV.html
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
public unsafe struct VkPhysicalDeviceDisplacementMicromapPropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_PROPERTIES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>maxDisplacementMicromapSubdivisionLevel is the maximum allowed subdivisionLevel for displacement micromaps.</summary>
    public uint maxDisplacementMicromapSubdivisionLevel;
}