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
///     VkVideoEncodeH265RateControlFlagBitsKHR - H.265 encode rate control bits -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH265RateControlFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_KHRspecifies that rate control should attempt to
    ///     produce an HRD compliant bitstream, as defined in annex C of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#itu-t-h265">
    ///         ITU-T H.265
    ///         Specification
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_REGULAR_GOP_BIT_KHR specifies that the application intends to use a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-regular-gop">
    ///         regular
    ///         GOP structure
    ///     </a>
    ///     according to the parameters specified in the gopFrameCount, idrPeriod, and
    ///     consecutiveBFrameCountmembers of the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlInfoKHR.html">
    ///         VkVideoEncodeH265RateControlInfoKHR
    ///     </a>
    ///     structure.
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_REGULAR_GOP_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHRspecifies that the application intends to follow a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-ref-pattern-flat">
    ///         flat
    ///         reference pattern
    ///     </a>
    ///     in the GOP.
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHRspecifies that the application intends to follow
    ///     a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-ref-pattern-dyadic">
    ///         dyadic
    ///         reference pattern
    ///     </a>
    ///     in the GOP.
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_TEMPORAL_SUB_LAYER_PATTERN_DYADIC_BIT_KHRspecifies that the application intends
    ///     to follow a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-layer-pattern-dyadic">
    ///         dyadic
    ///         temporal sub-layer pattern
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_TEMPORAL_SUB_LAYER_PATTERN_DYADIC_BIT_KHR = 0x10
}