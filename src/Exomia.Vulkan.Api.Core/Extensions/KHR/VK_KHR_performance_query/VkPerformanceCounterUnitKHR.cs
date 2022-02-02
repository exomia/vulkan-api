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
///     VkPerformanceCounterUnitKHR - Supported counter unit types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterUnitKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterUnitKHR.html</a>
/// </summary>
public enum VkPerformanceCounterUnitKHR
{
    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR - the performance counter unit is a generic data point.</summary>
    VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR = 0,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR - the performance counter unit is a percentage (%).</summary>
    VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR = 1,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR - the performance counter unit is a value of nanoseconds (ns).</summary>
    VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR = 2,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR - the performance counter unit is a value of bytes.</summary>
    VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR = 3,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR - the performance counter unit is a value of bytes/s.</summary>
    VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR = 4,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR - the performance counter unit is a temperature reported in Kelvin.</summary>
    VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR = 5,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR - the performance counter unit is a value of watts (W).</summary>
    VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR = 6,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR - the performance counter unit is a value of volts (V).</summary>
    VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR = 7,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR - the performance counter unit is a value of amps (A).</summary>
    VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR = 8,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR - the performance counter unit is a value of hertz (Hz).</summary>
    VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR = 9,

    /// <summary>VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR - the performance counter unit is a value of cycles.</summary>
    VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR = 10
}