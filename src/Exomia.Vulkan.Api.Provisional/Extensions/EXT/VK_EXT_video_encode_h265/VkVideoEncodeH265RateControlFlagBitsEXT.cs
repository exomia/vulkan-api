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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkVideoEncodeH265RateControlFlagBitsEXT - H.265 encode rate control bits -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH265RateControlFlagBitsEXT
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_EXTspecifies that rate control should attempt to
    ///     produce an HRD compliant bitstream.
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_REGULAR_GOP_BIT_EXT specifies that the application intends to use a regular GOP
    ///     structure according to the parameters specified in the gopFrameCount, idrPeriod, and consecutiveBFrameCount members
    ///     of the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlInfoEXT.html">
    ///         VkVideoEncodeH265RateControlInfoEXT
    ///     </a>
    ///     structure.
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_REGULAR_GOP_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_EXTspecifies that the application intends to
    ///     follow a flat reference pattern.
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_EXTspecifies that the application intends to
    ///     follow a dyadic reference pattern.
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_RATE_CONTROL_TEMPORAL_SUB_LAYER_PATTERN_DYADIC_BIT_EXTspecifies that the application
    ///     intends to follow a dyadic temporal sub-layer pattern.
    /// </summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_TEMPORAL_SUB_LAYER_PATTERN_DYADIC_BIT_EXT = 0x10
}