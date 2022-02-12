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
///     VkPerformanceCounterDescriptionFlagBitsKHR - Bitmask specifying usage behavior for a counter -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterDescriptionFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterDescriptionFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkPerformanceCounterDescriptionFlagBitsKHR
{
    /// <summary>
    ///     VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHRspecifies that recording the counter may have
    ///     a noticeable performance impact.
    /// </summary>
    VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHR = 1 << 0,

    /// <summary>
    ///     VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHRspecifies that concurrently recording the
    ///     counter while other submitted command buffers are running may impact the accuracy of the recording.
    /// </summary>
    VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHR = 1 << 1,

    /// <summary>
    ///     VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHRspecifies that recording the counter may have
    ///     a noticeable performance impact.
    /// </summary>
    VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_KHR = VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHR,

    /// <summary>
    ///     VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHRspecifies that concurrently recording the
    ///     counter while other submitted command buffers are running may impact the accuracy of the recording.
    /// </summary>
    VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_KHR = VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHR
}