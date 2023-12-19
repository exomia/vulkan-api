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
///     VkVideoEncodeUsageFlagBitsKHR - Video encode usage flags -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeUsageFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeUsageFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkVideoEncodeUsageFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_USAGE_DEFAULT_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoEncodeUsageFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoEncodeUsageFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_VIDEO_ENCODE_USAGE_DEFAULT_KHR = 0,

    /// <summary>
    ///     VK_VIDEO_ENCODE_USAGE_TRANSCODING_BIT_KHR specifies that video encoding is intended to be used in conjunction
    ///     with video decoding to transcode a video bitstream with the same and/or different codecs.
    /// </summary>
    VK_VIDEO_ENCODE_USAGE_TRANSCODING_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_USAGE_STREAMING_BIT_KHR specifies that video encoding is intended to be used to produce a
    ///     video bitstream that is expected to be sent as a continuous flow over network.
    /// </summary>
    VK_VIDEO_ENCODE_USAGE_STREAMING_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_USAGE_RECORDING_BIT_KHR specifies that video encoding is intended to be used for real-time
    ///     recording for offline consumption.
    /// </summary>
    VK_VIDEO_ENCODE_USAGE_RECORDING_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_USAGE_CONFERENCING_BIT_KHR specifies that video encoding is intended to be used in a video
    ///     conferencing scenario.
    /// </summary>
    VK_VIDEO_ENCODE_USAGE_CONFERENCING_BIT_KHR = 0x8
}