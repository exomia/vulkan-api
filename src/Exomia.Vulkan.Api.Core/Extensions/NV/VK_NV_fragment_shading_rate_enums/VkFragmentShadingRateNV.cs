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
///     VkFragmentShadingRateNV - Enumeration with fragment shading rates -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateNV.html</a>
/// </summary>
public enum VkFragmentShadingRateNV
{
    /// <summary>VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV specifies a fragment size of 1x1 pixels.</summary>
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = 0,

    /// <summary>VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV specifies a fragment size of 1x2 pixels.</summary>
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = 1,

    /// <summary>VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV specifies a fragment size of 2x1 pixels.</summary>
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = 4,

    /// <summary>VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV specifies a fragment size of 2x2 pixels.</summary>
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = 5,

    /// <summary>VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV specifies a fragment size of 2x4 pixels.</summary>
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = 6,

    /// <summary>VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV specifies a fragment size of 4x2 pixels.</summary>
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = 9,

    /// <summary>VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV specifies a fragment size of 4x4 pixels.</summary>
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = 10,

    /// <summary>
    ///     VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV specifies a fragment size of 1x1 pixels, with two fragment
    ///     shader invocations per fragment.
    /// </summary>
    VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = 11,

    /// <summary>
    ///     VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV specifies a fragment size of 1x1 pixels, with four
    ///     fragment shader invocations per fragment.
    /// </summary>
    VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = 12,

    /// <summary>
    ///     VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV specifies a fragment size of 1x1 pixels, with eight
    ///     fragment shader invocations per fragment.
    /// </summary>
    VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = 13,

    /// <summary>
    ///     VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV specifies a fragment size of 1x1 pixels, with sixteen
    ///     fragment shader invocations per fragment.
    /// </summary>
    VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = 14,

    /// <summary>
    ///     VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV specifies that any portions of a primitive that use that shading
    ///     rate should be discarded without invoking any fragment shader.
    /// </summary>
    VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV = 15
}