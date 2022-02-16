﻿#region License

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
public unsafe struct StdVideoEncodeH265ReferenceModifications
{
    public StdVideoEncodeH265ReferenceModificationFlags flags;

    public byte referenceList0ModificationsCount;

    public byte* pReferenceList0Modifications;

    public byte referenceList1ModificationsCount;

    public byte* pReferenceList1Modifications;
}