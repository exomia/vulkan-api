#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VulkanVideoCodecH264std;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

public static class VulkanVideoCodecH264std
{
    /// <summary> The spec version. </summary>
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_SPEC_VERSION = VK_STD_VULKAN_VIDEO_CODEC_H264_API_VERSION_0_9_5;

    /// <summary> The extension name. </summary>
    public const string VK_STD_VULKAN_VIDEO_CODEC_H264_EXTENSION_NAME = "VK_STD_vulkan_video_codec_h264";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_STD_VULKAN_VIDEO_CODEC_H264_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_STD_VULKAN_VIDEO_CODEC_H264_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_STD_VULKAN_VIDEO_CODEC_H264_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u535f\u4454\u565f\u4c55\u414b\u5f4e\u4956\u4544\u5f4f\u4f43\u4544\u5f43\u3248\u3436\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    public const int STD_VIDEO_H264_CPB_CNT_LIST_SIZE = 32;

    public const int STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS = 6;

    public const int STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS = 16;

    public const int STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS = 2;

    public const int STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS = 64;
}