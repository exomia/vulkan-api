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
///     VkVideoEncodeAV1StdFlagBitsKHR - Video encode AV1 syntax capability flags -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1StdFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1StdFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkVideoEncodeAV1StdFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_STD_UNIFORM_TILE_SPACING_FLAG_SET_BIT_KHRindicates whether the implementation supports using
    ///     the application-provided value for StdVideoAV1TileInfoFlags::uniform_tile_spacing_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-tile-params">
    ///         AV1 tile
    ///         parameters
    ///     </a>
    ///     when that value is 1, indifferent of the coded extent of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-input-picture">
    ///         encode
    ///         input picture
    ///     </a>
    ///     and the number of tile columns and rows requested in the TileCols and TileRows members of
    ///     StdVideoAV1TileInfo.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_STD_UNIFORM_TILE_SPACING_FLAG_SET_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_STD_SKIP_MODE_PRESENT_UNSET_BIT_KHR specifies whether the implementation supports using
    ///     the application-provided value for StdVideoEncodeAV1PictureInfoFlags::skip_mode_present when that value is 0.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_STD_SKIP_MODE_PRESENT_UNSET_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_STD_PRIMARY_REF_FRAME_BIT_KHR specifies whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeAV1PictureInfo::primary_ref_frame.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_STD_PRIMARY_REF_FRAME_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_STD_DELTA_Q_BIT_KHR specifies whether the implementation supports using the
    ///     application-provided values for the DeltaQYDc, DeltaQUDc, DeltaQUAc, DeltaQVDc, and DeltaQVAc members of
    ///     StdVideoAV1Quantization.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_STD_DELTA_Q_BIT_KHR = 0x8
}