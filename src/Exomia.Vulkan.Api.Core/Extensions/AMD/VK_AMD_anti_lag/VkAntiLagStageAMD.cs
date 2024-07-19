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
///     VkAntiLagStageAMD - Report the application stage -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAntiLagStageAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAntiLagStageAMD.html</a>
/// </summary>
public enum VkAntiLagStageAMD
{
    /// <summary>VK_ANTI_LAG_STAGE_INPUT_AMD specifies the stage before processing input.</summary>
    VK_ANTI_LAG_STAGE_INPUT_AMD = 0,

    /// <summary>
    ///     VK_ANTI_LAG_STAGE_PRESENT_AMD specifies the stage before
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueuePresentKHR.html">vkQueuePresentKHR</a>
    ///     .
    /// </summary>
    VK_ANTI_LAG_STAGE_PRESENT_AMD = 1
}