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
///     VkPipelineCreationFeedbackFlagBits - Bitmask specifying pipeline or pipeline stage creation feedback -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCreationFeedbackFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCreationFeedbackFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkPipelineCreationFeedbackFlagBits
{
    /// <summary>VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT indicates that the feedback information is valid.</summary>
    VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT = 0x1,

    /// <summary>
    ///     VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BITindicates that a readily usable pipeline or
    ///     pipeline stage was found in the pipelineCache specified by the application in the pipeline creation command.
    /// </summary>
    VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT = 0x2,

    /// <summary>
    ///     VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BITindicates that the base pipeline specified by the
    ///     basePipelineHandle or basePipelineIndex member of the Vk*PipelineCreateInfo structure was used to accelerate the
    ///     creation of the pipeline.
    /// </summary>
    VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT = 0x4,

    /// <summary>VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT indicates that the feedback information is valid.</summary>
    VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT = VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT,

    /// <summary>
    ///     VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BITindicates that a readily usable pipeline or
    ///     pipeline stage was found in the pipelineCache specified by the application in the pipeline creation command.
    /// </summary>
    VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT = VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT,

    /// <summary>
    ///     VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BITindicates that the base pipeline specified by the
    ///     basePipelineHandle or basePipelineIndex member of the Vk*PipelineCreateInfo structure was used to accelerate the
    ///     creation of the pipeline.
    /// </summary>
    VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT = VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT
}