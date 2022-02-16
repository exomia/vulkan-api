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
///     VkPerformanceCounterStorageKHR - Supported counter storage types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterStorageKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterStorageKHR.html</a>
/// </summary>
public enum VkPerformanceCounterStorageKHR
{
    /// <summary>VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR - the performance counter storage is a 32-bit signed integer.</summary>
    VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR = 0,

    /// <summary>VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR - the performance counter storage is a 64-bit signed integer.</summary>
    VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR = 1,

    /// <summary>VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR - the performance counter storage is a 32-bit unsigned integer.</summary>
    VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR = 2,

    /// <summary>VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR - the performance counter storage is a 64-bit unsigned integer.</summary>
    VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR = 3,

    /// <summary>VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR - the performance counter storage is a 32-bit floating-point.</summary>
    VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR = 4,

    /// <summary>VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR - the performance counter storage is a 64-bit floating-point.</summary>
    VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR = 5
}