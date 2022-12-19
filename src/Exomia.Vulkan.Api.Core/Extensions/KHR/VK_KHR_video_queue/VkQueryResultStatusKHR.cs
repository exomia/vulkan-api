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
///     VkQueryResultStatusKHR - Specific status codes for operations -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryResultStatusKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryResultStatusKHR.html</a>
/// </summary>
public enum VkQueryResultStatusKHR
{
    /// <summary>VK_QUERY_RESULT_STATUS_ERROR_KHR specifies that operations did not complete successfully.</summary>
    VK_QUERY_RESULT_STATUS_ERROR_KHR = -1,

    /// <summary>VK_QUERY_RESULT_STATUS_NOT_READY_KHR specifies that the query result is not yet available.</summary>
    VK_QUERY_RESULT_STATUS_NOT_READY_KHR = 0,

    /// <summary>
    ///     VK_QUERY_RESULT_STATUS_COMPLETE_KHR specifies that operations completed successfully and the query result is
    ///     available.
    /// </summary>
    VK_QUERY_RESULT_STATUS_COMPLETE_KHR = 1
}