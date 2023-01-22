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
///     VkVideoDecodeUsageFlagBitsKHR - Video decode usage flags -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeUsageFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeUsageFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkVideoDecodeUsageFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_DECODE_USAGE_DEFAULT_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoDecodeUsageFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoDecodeUsageFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_VIDEO_DECODE_USAGE_DEFAULT_KHR = 0,

    /// <summary>
    ///     VK_VIDEO_DECODE_USAGE_TRANSCODING_BIT_KHR specifies that video decoding is intended to be used in conjunction
    ///     with video encoding to transcode a video bitstream with the same and/or different codecs.
    /// </summary>
    VK_VIDEO_DECODE_USAGE_TRANSCODING_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_DECODE_USAGE_OFFLINE_BIT_KHR specifies that video decoding is intended to be used to consume a local
    ///     video bitstream.
    /// </summary>
    VK_VIDEO_DECODE_USAGE_OFFLINE_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_DECODE_USAGE_STREAMING_BIT_KHR specifies that video decoding is intended to be used to consume a
    ///     video bitstream received as a continuous flow over network.
    /// </summary>
    VK_VIDEO_DECODE_USAGE_STREAMING_BIT_KHR = 0x4
}