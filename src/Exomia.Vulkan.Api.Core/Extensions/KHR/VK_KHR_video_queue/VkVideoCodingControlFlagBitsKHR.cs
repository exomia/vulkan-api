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
///     VkVideoCodingControlFlagBitsKHR - Video coding control flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodingControlFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodingControlFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoCodingControlFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR specifies a request for the bound video session to be reset before other
    ///     coding control parameters are applied.
    /// </summary>
    VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_CODING_CONTROL_ENCODE_RATE_CONTROL_BIT_KHR specifies that the coding control parameters include video
    ///     encode rate control parameters (see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlInfoKHR.html">
    ///         VkVideoEncodeRateControlInfoKHR
    ///     </a>
    ///     ).
    /// </summary>
    VK_VIDEO_CODING_CONTROL_ENCODE_RATE_CONTROL_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_CODING_CONTROL_ENCODE_QUALITY_LEVEL_BIT_KHR specifies that the coding control parameters include
    ///     video encode quality level parameters (see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeQualityLevelInfoKHR.html">
    ///         VkVideoEncodeQualityLevelInfoKHR
    ///     </a>
    ///     ).
    /// </summary>
    VK_VIDEO_CODING_CONTROL_ENCODE_QUALITY_LEVEL_BIT_KHR = 0x4
}