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
///     VkPhysicalDeviceVulkanMemoryModelFeatures - Structure describing features supported by the memory model -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkanMemoryModelFeatures.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkanMemoryModelFeatures.html
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
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary> vulkanMemoryModelindicates whether shader modules can declare the VulkanMemoryModelcapability.</summary>
    public VkBool32 vulkanMemoryModel;

    /// <summary>
    ///     vulkanMemoryModelDeviceScope indicates whether the Vulkan Memory Model can use Device scope synchronization.
    ///     This also indicates whether shader modules can declare the VulkanMemoryModelDeviceScope capability.
    /// </summary>
    public VkBool32 vulkanMemoryModelDeviceScope;

    /// <summary>
    ///     vulkanMemoryModelAvailabilityVisibilityChains indicates whether the Vulkan Memory Model can use availability
    ///     and visibility chains with more than one element.
    /// </summary>
    public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
}