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
///     VkPipelineExecutableStatisticFormatKHR - Enum describing a pipeline executable statistic -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableStatisticFormatKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableStatisticFormatKHR.html
///     </a>
/// </summary>
public enum VkPipelineExecutableStatisticFormatKHR
{
    /// <summary>
    ///     VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR specifies that the statistic is returned as a 32-bit
    ///     boolean value which must be either VK_TRUE or VK_FALSE and should be read from the b32 field of
    ///     VkPipelineExecutableStatisticValueKHR.
    /// </summary>
    VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR = 0,

    /// <summary>
    ///     VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR specifies that the statistic is returned as a signed 64-bit
    ///     integer and should be read from the i64 field of VkPipelineExecutableStatisticValueKHR.
    /// </summary>
    VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR = 1,

    /// <summary>
    ///     VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR specifies that the statistic is returned as an unsigned
    ///     64-bit integer and should be read from the u64 field of VkPipelineExecutableStatisticValueKHR.
    /// </summary>
    VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR = 2,

    /// <summary>
    ///     VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR specifies that the statistic is returned as a 64-bit
    ///     floating-point value and shouldbe read from the f64 field of VkPipelineExecutableStatisticValueKHR.
    /// </summary>
    VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR = 3
}