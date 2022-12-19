#region License

// Copyright (c) 2018-2022, exomia
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
///     VkVideoDecodeH264PictureLayoutFlagBitsKHR - H.264 video decode picture layout flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureLayoutFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureLayoutFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoDecodeH264PictureLayoutFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_KHR specifies support for progressive content. This flag has
    ///     the value 0.
    /// </summary>
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_KHR = 0,

    /// <summary>
    ///     VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_KHRspecifies support for or use of a
    ///     picture layout for interlaced content where all lines belonging to the top field are decoded to the even-numbered
    ///     lines within the picture resource, and all lines belonging to the bottom field are decoded to the odd-numbered
    ///     lines within the picture resource.
    /// </summary>
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHRspecifies support for or use of a
    ///     picture layout for interlaced content where all lines belonging to a field are grouped together in a single image
    ///     subregion, and the two fields comprising the frame can be stored in separate image subregions of the same image
    ///     subresource or in separate image subresources.
    /// </summary>
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHR = 0x2
}