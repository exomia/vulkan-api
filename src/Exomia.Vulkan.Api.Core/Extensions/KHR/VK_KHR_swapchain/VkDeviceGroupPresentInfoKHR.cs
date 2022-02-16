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
///     VkDeviceGroupPresentInfoKHR - Mode and mask controlling which physical devices' images are presented -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupPresentInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupPresentInfoKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPresentInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPresentInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupPresentInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>swapchainCount is zero or the number of elements in pDeviceMasks.</summary>
    public uint swapchainCount;

    /// <summary>pDeviceMasks is a pointer to an array of device masks, one for each element of VkPresentInfoKHR::pSwapchains.</summary>
    public uint* pDeviceMasks;

    /// <summary>
    ///     mode is a VkDeviceGroupPresentModeFlagBitsKHR value specifying the device group present mode that will be used
    ///     for this present.
    /// </summary>
    public VkDeviceGroupPresentModeFlagBitsKHR mode;
}