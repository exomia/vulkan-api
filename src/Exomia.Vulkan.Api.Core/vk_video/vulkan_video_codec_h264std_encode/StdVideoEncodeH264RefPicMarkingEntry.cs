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
public struct StdVideoEncodeH264RefPicMarkingEntry
{
    public StdVideoH264MemMgmtControlOp memory_management_control_operation;

    public ushort difference_of_pic_nums_minus1;

    public ushort long_term_pic_num;

    public ushort long_term_frame_idx;

    public ushort max_long_term_frame_idx_plus1;
}