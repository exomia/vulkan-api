#region License

// Copyright (c) 2018-2023, exomia
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
///     VkPipelineRobustnessBufferBehaviorEXT - Enum controlling the robustness of buffer accesses in a pipeline stage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessBufferBehaviorEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessBufferBehaviorEXT.html
///     </a>
/// </summary>
public enum VkPipelineRobustnessBufferBehaviorEXT
{
    /// <summary>
    ///     VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT_EXTspecifies that this pipeline stage follows the
    ///     behavior of robustness features that are enabled on the device that created this pipeline
    /// </summary>
    VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT_EXT = 0,

    /// <summary>
    ///     VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED_EXT specifies that buffer accesses by this pipeline stage to
    ///     the relevant resource types must not be out of bounds
    /// </summary>
    VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED_EXT = 1,

    /// <summary>
    ///     VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_EXTspecifies that out of bounds accesses by this
    ///     pipeline stage to the relevant resource types behave as if the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#features-robustBufferAccess">
    ///         <code>robustBufferAccess</code>
    ///     </a>
    ///     feature is enabled
    /// </summary>
    VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_EXT = 2,

    /// <summary>
    ///     VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2_EXTspecifies that out of bounds accesses by this
    ///     pipeline stage to the relevant resource types behave as if the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#features-robustBufferAccess2">
    ///         <code>robustBufferAccess2</code>
    ///     </a>
    ///     feature is enabled
    /// </summary>
    VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2_EXT = 3
}