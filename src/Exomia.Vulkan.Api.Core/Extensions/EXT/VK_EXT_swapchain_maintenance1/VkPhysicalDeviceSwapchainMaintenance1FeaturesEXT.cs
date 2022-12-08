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
///     VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT - Structure describing whether implementation supports swapchain
///     maintenance1 functionality -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     swapchainMaintenance1 indicates that the implementation supports the
    ///     following:VkSwapchainPresentFenceInfoEXT, specifying a fence that is signaled when the resources associated with a
    ///     present operation can be safely destroyed.VkSwapchainPresentModesCreateInfoEXT and VkSwapchainPresentModeInfoEXT,
    ///     allowing the swapchain to switch present modes without a need for
    ///     recreation.VkSwapchainPresentScalingCreateInfoEXT, specifying the scaling behavior of the swapchain in presence of
    ///     window resizing.The VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT flag, allowing the implementation to
    ///     defer the allocation of swapchain image memory until first acquisition.vkReleaseSwapchainImagesEXT, allowing
    ///     acquired swapchain images to be released without presenting them.
    /// </summary>
    public VkBool32 swapchainMaintenance1;
}