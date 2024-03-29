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
///     VkTimeDomainKHR - Supported time domains -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTimeDomainKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTimeDomainKHR.html</a>
/// </summary>
public enum VkTimeDomainKHR
{
    /// <summary>
    ///     VK_TIME_DOMAIN_DEVICE_KHR specifies the device time domain. Timestamp values in this time domain use the same units
    ///     and are comparable with device timestamp values captured using
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp.html">vkCmdWriteTimestamp</a>
    ///     or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2.html">vkCmdWriteTimestamp2</a>
    ///     and are defined to be incrementing according to the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#limits-timestampPeriod">
    ///         <code>timestampPeriod</code>
    ///     </a>
    ///     of the device.
    /// </summary>
    VK_TIME_DOMAIN_DEVICE_KHR = 0,

    /// <summary>
    ///     VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR specifies the CLOCK_MONOTONIC time domain available on POSIX platforms.
    ///     Timestamp values in this time domain are in units of nanoseconds and are comparable with platform timestamp values
    ///     captured using the POSIX clock_gettime API as computed by this example:
    /// </summary>
    VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR = 1,

    /// <summary>
    ///     VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR specifies the CLOCK_MONOTONIC_RAW time domain available on POSIX
    ///     platforms. Timestamp values in this time domain are in units of nanoseconds and are comparable with platform
    ///     timestamp values captured using the POSIX clock_gettime API as computed by this example:
    /// </summary>
    VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR = 2,

    /// <summary>
    ///     VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR specifies the performance counter (QPC) time domain available on
    ///     Windows. Timestamp values in this time domain are in the same units as those provided by the Windows
    ///     QueryPerformanceCounter API and are comparable with platform timestamp values captured using that API as computed
    ///     by this example:
    /// </summary>
    VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR = 3,

    /// <summary>
    ///     VK_TIME_DOMAIN_DEVICE_KHR specifies the device time domain. Timestamp values in this time domain use the same units
    ///     and are comparable with device timestamp values captured using
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp.html">vkCmdWriteTimestamp</a>
    ///     or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2.html">vkCmdWriteTimestamp2</a>
    ///     and are defined to be incrementing according to the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#limits-timestampPeriod">
    ///         <code>timestampPeriod</code>
    ///     </a>
    ///     of the device.
    /// </summary>
    VK_TIME_DOMAIN_DEVICE_EXT = VK_TIME_DOMAIN_DEVICE_KHR,

    /// <summary>
    ///     VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR specifies the CLOCK_MONOTONIC time domain available on POSIX platforms.
    ///     Timestamp values in this time domain are in units of nanoseconds and are comparable with platform timestamp values
    ///     captured using the POSIX clock_gettime API as computed by this example:
    /// </summary>
    VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT = VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR,

    /// <summary>
    ///     VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR specifies the CLOCK_MONOTONIC_RAW time domain available on POSIX
    ///     platforms. Timestamp values in this time domain are in units of nanoseconds and are comparable with platform
    ///     timestamp values captured using the POSIX clock_gettime API as computed by this example:
    /// </summary>
    VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT = VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR,

    /// <summary>
    ///     VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR specifies the performance counter (QPC) time domain available on
    ///     Windows. Timestamp values in this time domain are in the same units as those provided by the Windows
    ///     QueryPerformanceCounter API and are comparable with platform timestamp values captured using that API as computed
    ///     by this example:
    /// </summary>
    VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT = VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR
}