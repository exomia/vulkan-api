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
///     VkQueueGlobalPriorityKHR - Values specifying a system-wide queue priority -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueGlobalPriorityKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueGlobalPriorityKHR.html</a>
/// </summary>
public enum VkQueueGlobalPriorityKHR
{
    /// <summary>VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR is below the system default. Useful for non-interactive tasks.</summary>
    VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR = 128,

    /// <summary>VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR is the system default priority.</summary>
    VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR = 256,

    /// <summary>VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR is above the system default.</summary>
    VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR = 512,

    /// <summary>VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR is the highest priority. Useful for critical tasks.</summary>
    VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR = 1024,

    /// <summary>VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR is below the system default. Useful for non-interactive tasks.</summary>
    VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT = VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR,

    /// <summary>VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR is the system default priority.</summary>
    VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT = VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR,

    /// <summary>VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR is above the system default.</summary>
    VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT = VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR,

    /// <summary>VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR is the highest priority. Useful for critical tasks.</summary>
    VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT = VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR
}