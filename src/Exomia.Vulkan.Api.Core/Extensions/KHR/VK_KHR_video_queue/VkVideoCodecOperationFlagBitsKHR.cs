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

    /// <summary>VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_EXT specifies support for H.264 video encode operations.</summary>
    VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_EXT = 0x10000,

    /// <summary>VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_EXT specifies support for H.265 video encode operations.</summary>
    VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_EXT = 0x20000,

    /// <summary>VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR specifies support for H.264 video decode operations.</summary>
    VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR = 0x1,

    /// <summary>VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR specifies support for H.265 video decode operations.</summary>
    VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR = 0x2
}