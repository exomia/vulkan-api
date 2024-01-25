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
///     VkQueryPoolSamplingModeINTEL - Enum specifying how performance queries should be captured -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryPoolSamplingModeINTEL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryPoolSamplingModeINTEL.html</a>
/// </summary>
public enum VkQueryPoolSamplingModeINTEL
{
    /// <summary>
    ///     VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL is the default mode in which the application calls
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginQuery.html">vkCmdBeginQuery</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndQuery.html">vkCmdEndQuery</a>
    ///     to record performance data.
    /// </summary>
    VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL = 0
}