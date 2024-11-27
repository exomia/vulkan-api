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
///     VkVideoEncodeAV1RateControlGroupKHR - AV1 encode rate control group -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlGroupKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlGroupKHR.html
///     </a>
/// </summary>
public enum VkVideoEncodeAV1RateControlGroupKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR should be specified when encoding AV1 frames that use
    ///     intra-only prediction (e.g. when encoding AV1 frames of type STD_VIDEO_AV1_FRAME_TYPE_KEY or
    ///     STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY).
    /// </summary>
    VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR = 0,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR should be specified when encoding AV1 frames that only
    ///     have forward references in display order.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR = 1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR should be specified when encoding AV1 frames that have
    ///     backward references in display order.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR = 2
}