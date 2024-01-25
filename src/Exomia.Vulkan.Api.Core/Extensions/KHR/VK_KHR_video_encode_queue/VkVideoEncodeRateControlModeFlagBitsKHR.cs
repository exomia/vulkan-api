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
///     VkVideoEncodeRateControlModeFlagBitsKHR - Video encode rate control modes -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlModeFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlModeFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeRateControlModeFlagBitsKHR
{
    /// <summary>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DEFAULT_KHR specifies the use of implementation-specific rate control.</summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DEFAULT_KHR = 0,

    /// <summary>
    ///     VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR specifies that rate control is disabled and the application will
    ///     specify per-operation rate control parameters controlling the encoding quality. In this mode implementations will
    ///     encode pictures independently of the output bitrate of prior video encode operations.<br />
    ///     When using an H.264 encode profile, implementations will use the QP value specified in
    ///     VkVideoEncodeH264NaluSliceInfoKHR::constantQp to control the quality of the encoded picture.<br />
    ///     When using an H.265 encode profile, implementations will use the QP value specified in
    ///     VkVideoEncodeH265NaluSliceSegmentInfoKHR::constantQp to control the quality of the encoded picture.<br />
    /// </summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR specifies the use of constant bitrate (CBR) rate control mode.
    ///     In this mode the implementation will attempt to produce the encoded bitstream at a constant bitrate while
    ///     conforming to the constraints of other rate control parameters.
    /// </summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR specifies the use of variable bitrate (VBR) rate control mode.
    ///     In this mode the implementation will produce the encoded bitstream at a variable bitrate according to the
    ///     constraints of other rate control parameters.
    /// </summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR = 0x4
}