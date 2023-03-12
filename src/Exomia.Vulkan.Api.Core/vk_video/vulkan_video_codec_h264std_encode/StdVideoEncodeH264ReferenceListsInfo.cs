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
public unsafe struct StdVideoEncodeH264ReferenceListsInfo
{
    public StdVideoEncodeH264ReferenceListsInfoFlags flags;

    public byte refPicList0EntryCount;

    public byte refPicList1EntryCount;

    public byte refList0ModOpCount;

    public byte refList1ModOpCount;

    public byte refPicMarkingOpCount;

    public fixed byte reserved1[7];

    public byte* pRefPicList0Entries;

    public byte* pRefPicList1Entries;

    public StdVideoEncodeH264RefListModEntry* pRefList0ModOperations;

    public StdVideoEncodeH264RefListModEntry* pRefList1ModOperations;

    public StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations;
}