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
///     VkPerformanceOverrideTypeINTEL - Performance override type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceOverrideTypeINTEL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceOverrideTypeINTEL.html</a>
/// </summary>
public enum VkPerformanceOverrideTypeINTEL
{
    /// <summary>VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL turns all rendering operations into noop.</summary>
    VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL = 0,

    /// <summary>
    ///     VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL stalls the stream of commands until all previously emitted
    ///     commands have completed and all caches been flushed and invalidated.
    /// </summary>
    VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL = 1
}