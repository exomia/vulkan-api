#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct StdVideoDecodeAV1PictureInfo
{
    public StdVideoDecodeAV1PictureInfoFlags flags;

    public StdVideoAV1FrameType frame_type;

    public uint current_frame_id;

    public byte OrderHint;

    public byte primary_ref_frame;

    public byte refresh_frame_flags;

    public byte reserved1;

    public StdVideoAV1InterpolationFilter interpolation_filter;

    public StdVideoAV1TxMode TxMode;

    public byte delta_q_res;

    public byte delta_lf_res;

    public fixed byte SkipModeFrame[(int)STD_VIDEO_AV1_SKIP_MODE_FRAMES];

    public byte coded_denom;

    public VkArray3<byte> reserved2;

    public fixed byte OrderHints[(int)STD_VIDEO_AV1_NUM_REF_FRAMES];

    public fixed uint expectedFrameId[(int)STD_VIDEO_AV1_NUM_REF_FRAMES];

    public StdVideoAV1TileInfo* pTileInfo;

    public StdVideoAV1Quantization* pQuantization;

    public StdVideoAV1Segmentation* pSegmentation;

    public StdVideoAV1LoopFilter* pLoopFilter;

    public StdVideoAV1CDEF* pCDEF;

    public StdVideoAV1LoopRestoration* pLoopRestoration;

    public StdVideoAV1GlobalMotion* pGlobalMotion;

    public StdVideoAV1FilmGrain* pFilmGrain;
}