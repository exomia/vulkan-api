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
///     VkSamplerYcbcrRange - Range of encoded values in a color space -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrRange.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrRange.html</a>
/// </summary>
public enum VkSamplerYcbcrRange
{
    /// <summary>
    ///     VK_SAMPLER_YCBCR_RANGE_ITU_FULL specifies that the full range of the encoded values are valid and interpreted
    ///     according to the ITU &#8220;full range&#8221; quantization rules.
    /// </summary>
    VK_SAMPLER_YCBCR_RANGE_ITU_FULL = 0,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_RANGE_ITU_NARROW specifies that headroom and foot room are reserved in the numerical range of
    ///     encoded values, and the remaining values are expanded according to the ITU &#8220;narrow range&#8221; quantization
    ///     rules.
    /// </summary>
    VK_SAMPLER_YCBCR_RANGE_ITU_NARROW = 1,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_RANGE_ITU_FULL specifies that the full range of the encoded values are valid and interpreted
    ///     according to the ITU &#8220;full range&#8221; quantization rules.
    /// </summary>
    VK_SAMPLER_YCBCR_RANGE_ITU_FULL_KHR = VK_SAMPLER_YCBCR_RANGE_ITU_FULL,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_RANGE_ITU_NARROW specifies that headroom and foot room are reserved in the numerical range of
    ///     encoded values, and the remaining values are expanded according to the ITU &#8220;narrow range&#8221; quantization
    ///     rules.
    /// </summary>
    VK_SAMPLER_YCBCR_RANGE_ITU_NARROW_KHR = VK_SAMPLER_YCBCR_RANGE_ITU_NARROW
}