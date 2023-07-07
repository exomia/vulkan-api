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
///     VkDeviceQueueInfo2 - Structure specifying the parameters used for device queue creation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueInfo2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueInfo2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceQueueInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext is NULL or a pointer to a structure extending this structure. The pNext chain of VkDeviceQueueInfo2 can
    ///     be used to provide additional device queue parameters to vkGetDeviceQueue2.
    /// </summary>
    public void* pNext;

    /// <summary>flags is a VkDeviceQueueCreateFlags value indicating the flags used to create the device queue.</summary>
    public VkDeviceQueueCreateFlags flags;

    /// <summary>queueFamilyIndex is the index of the queue family to which the queue belongs.</summary>
    public uint queueFamilyIndex;

    /// <summary>
    ///     queueIndex is the index of the queue to retrieve from within the set of queues that share both the queue
    ///     family and flags specified.
    /// </summary>
    public uint queueIndex;
}