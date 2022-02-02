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
///     VkPhysicalDeviceSubpassShadingPropertiesHUAWEI - Structure describing subpass shading properties supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubpassShadingPropertiesHUAWEI.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubpassShadingPropertiesHUAWEI.html
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
public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxSubpassShadingWorkgroupSizeAspectRatio indicates the maximum ratio between the width and height of the
    ///     portion of the subpass shading shader workgroup size. maxSubpassShadingWorkgroupSizeAspectRatio must be a
    ///     power-of-two value, and must be less than or equal to max(WorkgroupSize.x / WorkgroupSize.y, WorkgroupSize.y /
    ///     WorkgroupSize.x).
    /// </summary>
    public uint maxSubpassShadingWorkgroupSizeAspectRatio;
}