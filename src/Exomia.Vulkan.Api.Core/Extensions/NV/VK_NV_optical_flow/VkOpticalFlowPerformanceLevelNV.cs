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
///     VkOpticalFlowPerformanceLevelNV - Optical flow performance level types -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowPerformanceLevelNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowPerformanceLevelNV.html
///     </a>
/// </summary>
public enum VkOpticalFlowPerformanceLevelNV
{
    /// <summary>
    ///     VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkOpticalFlowPerformanceLevelNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkOpticalFlowPerformanceLevelNV
    ///     </a>
    /// </summary>
    VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV = 0,

    /// <summary>VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV is a level with slower performance but higher quality.</summary>
    VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV = 1,

    /// <summary>VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV is a level with medium performance and medium quality.</summary>
    VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV = 2,

    /// <summary>VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV is a preset with higher performance but lower quality.</summary>
    VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV = 3
}