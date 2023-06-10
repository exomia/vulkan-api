#region License

// Copyright (c) 2018-2023, exomia
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
public unsafe struct StdVideoEncodeH265ReferenceListsInfo
{
    public StdVideoEncodeH265ReferenceListsInfoFlags flags;

    public byte num_ref_idx_l0_active_minus1;

    public byte num_ref_idx_l1_active_minus1;

    public fixed byte RefPicList0[1];

    public fixed byte RefPicList1[1];

    public fixed byte list_entry_l0[1];

    public fixed byte list_entry_l1[1];
}