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
///     VkDeviceCreateInfo - Structure specifying parameters of a newly created device -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkDeviceCreateFlags flags;

    /// <summary>
    ///     queueCreateInfoCount is the unsigned integer size of the pQueueCreateInfos array. Refer to the Queue Creation
    ///     section below for further details.
    /// </summary>
    public uint queueCreateInfoCount;

    /// <summary>
    ///     pQueueCreateInfos is a pointer to an array of VkDeviceQueueCreateInfo structures describing the queues that
    ///     are requested to be created along with the logical device. Refer to the Queue Creation section below for further
    ///     details.
    /// </summary>
    public VkDeviceQueueCreateInfo* pQueueCreateInfos;

    /// <summary>enabledLayerCount is deprecated and ignored.</summary>
    public uint enabledLayerCount;

    /// <summary>
    ///     ppEnabledLayerNames is deprecated and ignored. See
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#extendingvulkan-layers-devicelayerdeprecation.
    /// </summary>
    public byte** ppEnabledLayerNames;

    /// <summary>enabledExtensionCount is the number of device extensions to enable.</summary>
    public uint enabledExtensionCount;

    /// <summary>
    ///     ppEnabledExtensionNames is a pointer to an array of enabledExtensionCount null-terminated UTF-8 strings
    ///     containing the names of extensions to enable for the created device. See the
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#extendingvulkan-extensions section for
    ///     further details.
    /// </summary>
    public byte** ppEnabledExtensionNames;

    /// <summary>
    ///     pEnabledFeatures is NULL or a pointer to a VkPhysicalDeviceFeatures structure containing boolean indicators of
    ///     all the features to be enabled. Refer to the Features section for further details.
    /// </summary>
    public VkPhysicalDeviceFeatures* pEnabledFeatures;
}