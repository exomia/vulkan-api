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
///     VkCoverageReductionModeNV - Specify the coverage reduction mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoverageReductionModeNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoverageReductionModeNV.html</a>
/// </summary>
public enum VkCoverageReductionModeNV
{
    /// <summary>
    ///     VK_COVERAGE_REDUCTION_MODE_MERGE_NV specifies that each color sample will be associated with an
    ///     implementation-dependent subset of samples in the pixel coverage. If any of those associated samples are covered,
    ///     the color sample is covered.
    /// </summary>
    VK_COVERAGE_REDUCTION_MODE_MERGE_NV = 0,

    /// <summary>
    ///     VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV specifies that for color samples present in the color attachments, a color
    ///     sample is covered if the pixel coverage sample with the same
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-multisampling-coverage-mask">
    ///         sample
    ///         index
    ///     </a>
    ///     i is covered; other pixel coverage samples are discarded.
    /// </summary>
    VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV = 1
}