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
///     VkVideoEncodeH265TransformBlockSizeFlagBitsEXT - Supported transform block sizes for H.265 video encode -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265TransformBlockSizeFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265TransformBlockSizeFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH265TransformBlockSizeFlagBitsEXT
{
    /// <summary>VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_EXT specifies that a transform block size of 4x4 is supported.</summary>
    VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_EXT = 0x1,

    /// <summary>VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_EXT specifies that a transform block size of 8x8 is supported.</summary>
    VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_EXT specifies that a transform block size of 16x16 is
    ///     supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_EXT specifies that a transform block size of 32x32 is
    ///     supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_EXT = 0x8
}