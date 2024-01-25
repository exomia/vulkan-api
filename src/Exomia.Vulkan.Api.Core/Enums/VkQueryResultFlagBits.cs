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
///     VkQueryResultFlagBits - Bitmask specifying how and when query results are returned -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryResultFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryResultFlagBits.html</a>
/// </summary>
[Flags]
public enum VkQueryResultFlagBits
{
    /// <summary>
    ///     VK_QUERY_RESULT_64_BIT specifies the results will be written as an array of 64-bit unsigned integer values. If
    ///     this bit is not set, the results will be written as an array of 32-bit unsigned integer values.
    /// </summary>
    VK_QUERY_RESULT_64_BIT = 0x1,

    /// <summary>
    ///     VK_QUERY_RESULT_WAIT_BIT specifies that Vulkan will wait for each query&#8217;s status to become available
    ///     before retrieving its results.
    /// </summary>
    VK_QUERY_RESULT_WAIT_BIT = 0x2,

    /// <summary>VK_QUERY_RESULT_WITH_AVAILABILITY_BIT specifies that the availability status accompanies the results.</summary>
    VK_QUERY_RESULT_WITH_AVAILABILITY_BIT = 0x4,

    /// <summary>VK_QUERY_RESULT_PARTIAL_BIT specifies that returning partial results is acceptable.</summary>
    VK_QUERY_RESULT_PARTIAL_BIT = 0x8,

    /// <summary>
    ///     VK_QUERY_RESULT_WITH_STATUS_BIT_KHR specifies that the last value returned in the query is a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryResultStatusKHR.html">VkQueryResultStatusKHR</a>
    ///     value. See
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-result-status-only">
    ///         result
    ///         status query
    ///     </a>
    ///     for information on how an application can determine whether the use of this flag bit is
    ///     supported.
    /// </summary>
    VK_QUERY_RESULT_WITH_STATUS_BIT_KHR = 0x10
}