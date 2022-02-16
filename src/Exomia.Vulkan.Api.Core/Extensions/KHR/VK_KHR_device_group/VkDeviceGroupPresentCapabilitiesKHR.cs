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
///     VkDeviceGroupPresentCapabilitiesKHR - Present capabilities from other physical devices -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupPresentCapabilitiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupPresentCapabilitiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     presentMask is an array of VK_MAX_DEVICE_GROUP_SIZEuint32_t masks, where the mask at element i is non-zero if
    ///     physical device i has a presentation engine, and where bit jis set in element i if physical device i can present
    ///     swapchain images from physical device j. If element i is non-zero, then bit i must be set.
    /// </summary>
    public VkArray32<uint> presentMask;

    /// <summary>
    ///     modes is a bitmask of VkDeviceGroupPresentModeFlagBitsKHRindicating which device group presentation modes are
    ///     supported.
    /// </summary>
    public VkDeviceGroupPresentModeFlagsKHR modes;
}