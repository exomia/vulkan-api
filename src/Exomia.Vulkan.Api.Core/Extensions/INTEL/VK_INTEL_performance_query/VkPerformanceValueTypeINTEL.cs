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
///     VkPerformanceValueTypeINTEL - Type of the parameters that can be queried -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceValueTypeINTEL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceValueTypeINTEL.html</a>
/// </summary>
public enum VkPerformanceValueTypeINTEL
{
    /// <summary>
    ///     VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL</a>
    /// </summary>
    VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL = 0,

    /// <summary>
    ///     VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL</a>
    /// </summary>
    VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL = 1,

    /// <summary>
    ///     VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL</a>
    /// </summary>
    VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL = 2,

    /// <summary>
    ///     VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL</a>
    /// </summary>
    VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL = 3,

    /// <summary>
    ///     VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceValueTypeINTEL</a>
    /// </summary>
    VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL = 4
}