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
///     VkMemoryOverallocationBehaviorAMD - Specify memory overallocation behavior -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryOverallocationBehaviorAMD.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryOverallocationBehaviorAMD.html
///     </a>
/// </summary>
public enum VkMemoryOverallocationBehaviorAMD
{
    /// <summary>VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD lets the implementation decide if overallocation is allowed.</summary>
    VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD = 0,

    /// <summary>VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD specifies overallocation is allowed if platform permits.</summary>
    VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD = 1,

    /// <summary>
    ///     VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD specifies the application is not allowed to allocate device
    ///     memory beyond the heap sizes reported by
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryProperties.html">
    ///         VkPhysicalDeviceMemoryProperties
    ///     </a>
    ///     . Allocations that are not explicitly made by the application within the scope of the Vulkan instance are not
    ///     accounted for.
    /// </summary>
    VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD = 2
}