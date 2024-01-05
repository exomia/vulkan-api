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
///     VkPipelineLayoutCreateFlagBits - Pipeline layout creation flag bits -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineLayoutCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineLayoutCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkPipelineLayoutCreateFlagBits
{
    /// <summary>
    ///     VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT specifies that implementations must ensure that the
    ///     properties and/or absence of a particular descriptor set do not influence any other properties of the pipeline
    ///     layout. This allows pipelines libraries linked without VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT to be
    ///     created with a subset of the total descriptor sets.
    /// </summary>
    VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT = 0x2
}