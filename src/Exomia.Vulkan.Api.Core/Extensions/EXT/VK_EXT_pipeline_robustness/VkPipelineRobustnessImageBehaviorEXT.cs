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
///     VkPipelineRobustnessImageBehaviorEXT - Enum controlling the robustness of image accesses in a pipeline stage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessImageBehaviorEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessImageBehaviorEXT.html
///     </a>
/// </summary>
public enum VkPipelineRobustnessImageBehaviorEXT
{
    /// <summary> VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT_EXT specifies that this pipeline stage follows the robustness behavior of the logical device that created this pipeline </summary>
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT_EXT = 0,

    /// <summary> VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED_EXT specifies that image accesses by this pipeline stage to the relevant resource types must not be out of bounds </summary>
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED_EXT = 1,

    /// <summary>
    ///     VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_EXTspecifies that out of bounds accesses by this pipeline stage to images behave as if the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#features-robustImageAccess">
    ///         <code>robustImageAccess</code>
    ///     </a>
    ///     feature is enabled
    /// </summary>
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_EXT = 2,

    /// <summary>
    ///     VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2_EXTspecifies that out of bounds accesses by this pipeline stage to images behave as if the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#features-robustImageAccess2">
    ///         <code>robustImageAccess2</code>
    ///     </a>
    ///     feature is enabled
    /// </summary>
    VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2_EXT = 3
}