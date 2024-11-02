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
///     VkPhysicalDeviceHdrVividFeaturesHUAWEI - Structure describing whether HDR Vivid metadata is supported -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceHdrVividFeaturesHUAWEI.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceHdrVividFeaturesHUAWEI.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceHdrVividFeaturesHUAWEI
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HDR_VIVID_FEATURES_HUAWEI;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary> hdrVivid specifies whether HDR Vivid metadata is supported.</summary>
    public VkBool32 hdrVivid;
}