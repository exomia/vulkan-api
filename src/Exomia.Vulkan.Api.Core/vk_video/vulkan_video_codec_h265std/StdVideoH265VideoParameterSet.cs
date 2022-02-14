#region License

// Copyright (c) 2018-2022, exomia
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
public unsafe struct StdVideoH265VideoParameterSet
{
    public byte vps_video_parameter_set_id;

    public byte vps_max_sub_layers_minus1;

    public uint vps_num_units_in_tick;

    public uint vps_time_scale;

    public uint vps_num_ticks_poc_diff_one_minus1;

    public StdVideoH265DecPicBufMgr* pDecPicBufMgr;

    public StdVideoH265HrdParameters* pHrdParameters;

    public StdVideoH265VpsFlags flags;
}