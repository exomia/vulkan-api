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
public unsafe struct StdVideoH264PictureParameterSet
{
    public byte seq_parameter_set_id;

    public byte pic_parameter_set_id;

    public byte num_ref_idx_l0_default_active_minus1;

    public byte num_ref_idx_l1_default_active_minus1;

    public StdVideoH264WeightedBipredIdc weighted_bipred_idc;

    public sbyte pic_init_qp_minus26;

    public sbyte pic_init_qs_minus26;

    public sbyte chroma_qp_index_offset;

    public sbyte second_chroma_qp_index_offset;

    public StdVideoH264PpsFlags flags;

    public StdVideoH264ScalingLists* pScalingLists;
}