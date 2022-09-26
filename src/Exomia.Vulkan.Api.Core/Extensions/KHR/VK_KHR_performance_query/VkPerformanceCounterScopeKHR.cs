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
///     VkPerformanceCounterScopeKHR - Supported counter scope types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterScopeKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterScopeKHR.html </a>
/// </summary>
public enum VkPerformanceCounterScopeKHR
{
    /// <summary> VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR - the performance counter scope is a single complete command buffer. </summary>
    VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR = 0,

    /// <summary> VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR - the performance counter scope is zero or more complete render passes. The performance query containing the performance counter must begin and end outside a render pass instance. </summary>
    VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR = 1,

    /// <summary> VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR - the performance counter scope is zero or more commands. </summary>
    VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR = 2,

    /// <summary> VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR - the performance counter scope is a single complete command buffer. </summary>
    VK_QUERY_SCOPE_COMMAND_BUFFER_KHR = VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR,

    /// <summary> VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR - the performance counter scope is zero or more complete render passes. The performance query containing the performance counter must begin and end outside a render pass instance. </summary>
    VK_QUERY_SCOPE_RENDER_PASS_KHR = VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR,

    /// <summary> VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR - the performance counter scope is zero or more commands. </summary>
    VK_QUERY_SCOPE_COMMAND_KHR = VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR
}