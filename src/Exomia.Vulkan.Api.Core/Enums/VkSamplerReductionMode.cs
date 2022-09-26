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
///     VkSamplerReductionMode - Specify reduction mode for texture filtering -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionMode.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionMode.html </a>
/// </summary>
public enum VkSamplerReductionMode
{
    /// <summary>
    ///     VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE specifies that texel values are combined by computing a weighted average of values in the footprint, using weights as specified in
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-unnormalized-to-integer">
    ///         the image operations chapter
    ///     </a>
    ///     .
    /// </summary>
    VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE = 0,

    /// <summary> VK_SAMPLER_REDUCTION_MODE_MIN specifies that texel values are combined by taking the component-wise minimum of values in the footprint with non-zero weights. </summary>
    VK_SAMPLER_REDUCTION_MODE_MIN = 1,

    /// <summary> VK_SAMPLER_REDUCTION_MODE_MAX specifies that texel values are combined by taking the component-wise maximum of values in the footprint with non-zero weights. </summary>
    VK_SAMPLER_REDUCTION_MODE_MAX = 2,

    /// <summary>
    ///     VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE specifies that texel values are combined by computing a weighted average of values in the footprint, using weights as specified in
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-unnormalized-to-integer">
    ///         the image operations chapter
    ///     </a>
    ///     .
    /// </summary>
    VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT = VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE,

    /// <summary> VK_SAMPLER_REDUCTION_MODE_MIN specifies that texel values are combined by taking the component-wise minimum of values in the footprint with non-zero weights. </summary>
    VK_SAMPLER_REDUCTION_MODE_MIN_EXT = VK_SAMPLER_REDUCTION_MODE_MIN,

    /// <summary> VK_SAMPLER_REDUCTION_MODE_MAX specifies that texel values are combined by taking the component-wise maximum of values in the footprint with non-zero weights. </summary>
    VK_SAMPLER_REDUCTION_MODE_MAX_EXT = VK_SAMPLER_REDUCTION_MODE_MAX
}