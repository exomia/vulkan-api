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
///     VkVideoEncodeTuningModeKHR - Video encode tuning mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeTuningModeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeTuningModeKHR.html</a>
/// </summary>
public enum VkVideoEncodeTuningModeKHR
{
    /// <summary>VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR specifies the default tuning mode.</summary>
    VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR = 0,

    /// <summary>
    ///     VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR specifies that video encoding is tuned for high quality. When
    ///     using this tuning mode, the implementation may compromise the latency of video encoding operations to improve
    ///     quality.
    /// </summary>
    VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR = 1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR specifies that video encoding is tuned for low latency. When using
    ///     this tuning mode, the implementation may compromise quality to increase the performance and lower the latency of
    ///     video encode operations.
    /// </summary>
    VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR = 2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR specifies that video encoding is tuned for ultra-low
    ///     latency. When using this tuning mode, the implementation may compromise quality to maximize the performance and
    ///     minimize the latency of video encoding operations.
    /// </summary>
    VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR = 3,

    /// <summary>
    ///     VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR specifies that video encoding is tuned for lossless encoding. When
    ///     using this tuning mode, video encode operations produce lossless output.
    /// </summary>
    VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR = 4
}