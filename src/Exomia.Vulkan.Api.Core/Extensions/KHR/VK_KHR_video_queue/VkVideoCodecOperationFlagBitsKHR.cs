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
///     VkVideoCodecOperationFlagBitsKHR - Video codec operation bits -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodecOperationFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodecOperationFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoCodecOperationFlagBitsKHR
{
    /// <summary>VK_VIDEO_CODEC_OPERATION_NONE_KHR indicates no support for any video codec operations.</summary>
    VK_VIDEO_CODEC_OPERATION_NONE_KHR = 0,

    /// <summary>
    ///     VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR specifies support for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264">
    ///         H.264 encode
    ///         operations
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR = 0x10000,

    /// <summary>
    ///     VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR specifies support for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265">
    ///         H.265 encode
    ///         operations
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR = 0x20000,

    /// <summary>
    ///     VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR specifies support for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#decode-h264">
    ///         H.264 decode
    ///         operations
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR specifies support for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#decode-h265">
    ///         H.265 decode
    ///         operations
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR specifies support for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#decode-av1">
    ///         AV1 decode
    ///         operations
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR = 0x4
}