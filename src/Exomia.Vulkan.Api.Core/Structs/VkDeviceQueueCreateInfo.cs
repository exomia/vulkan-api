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
///     VkDeviceQueueCreateInfo - Structure specifying parameters of a newly created device queue -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceQueueCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask indicating behavior of the queue.</summary>
    public VkDeviceQueueCreateFlags flags;

    /// <summary>
    ///     queueFamilyIndex is an unsigned integer indicating the index of the queue family in which to create the queue
    ///     on this device. This index corresponds to the index of an element of the pQueueFamilyProperties array that was
    ///     returned by vkGetPhysicalDeviceQueueFamilyProperties.
    /// </summary>
    public uint queueFamilyIndex;

    /// <summary>
    ///     queueCount is an unsigned integer specifying the number of queues to create in the queue family indicated by
    ///     queueFamilyIndex.
    /// </summary>
    public uint queueCount;

    /// <summary>
    ///     pQueuePriorities is a pointer to an array of queueCountnormalized floating point values, specifying priorities
    ///     of work that will be submitted to each created queue. See Queue Priority for more information.
    /// </summary>
    public float* pQueuePriorities;
}