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
    ///     VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR specifies that rate control is disabled and any quality control
    ///     parameters for the encoding are provided on a per-picture basis. In this mode implementations will encode pictures
    ///     independently of the output bitrate of prior video encode operations. When using an H.264 encode profile,
    ///     implementations will use the QP values specified in the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlInfoEXT.html">
    ///         VkVideoEncodeH264RateControlInfoEXT
    ///     </a>
    ///     structure for the encoded picture. When using an H.265 encode profile, implementations will use the QP values
    ///     specified in the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlInfoEXT.html">
    ///         VkVideoEncodeH265RateControlInfoEXT
    ///     </a>
    ///     structure for the encoded picture.
    /// </summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR = 0x1,

    /// <summary>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR specifies the use of constant bitrate rate control mode.</summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR = 0x2,

    /// <summary>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR specifies the use of variable bitrate rate control mode.</summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR = 0x4
}