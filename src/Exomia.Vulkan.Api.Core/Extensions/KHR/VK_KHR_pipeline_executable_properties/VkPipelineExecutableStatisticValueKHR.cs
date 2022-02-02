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
///     VkPipelineExecutableStatisticValueKHR - A union describing a pipeline executable statistic -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableStatisticValueKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableStatisticValueKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Explicit)]
public struct VkPipelineExecutableStatisticValueKHR
{
    /// <summary>
    ///     b32 is the 32-bit boolean value if the VkPipelineExecutableStatisticFormatKHR is
    ///     VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR.
    /// </summary>
    [FieldOffset(0)]
    public VkBool32 b32;

    /// <summary>
    ///     i64 is the signed 64-bit integer value if the VkPipelineExecutableStatisticFormatKHR is
    ///     VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR.
    /// </summary>
    [FieldOffset(0)]
    public long i64;

    /// <summary>
    ///     u64 is the unsigned 64-bit integer value if the VkPipelineExecutableStatisticFormatKHR is
    ///     VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR.
    /// </summary>
    [FieldOffset(0)]
    public ulong u64;

    /// <summary>
    ///     f64 is the 64-bit floating-point value if the VkPipelineExecutableStatisticFormatKHR is
    ///     VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR.
    /// </summary>
    [FieldOffset(0)]
    public double f64;
}