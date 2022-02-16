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
public struct StdVideoH264ScalingLists
{
    public byte scaling_list_present_mask;

    public byte use_default_scaling_matrix_mask;

    public VkArray6<VkArray16<byte>> ScalingList4x4;

    public VkArray6<VkArray64<byte>> ScalingList8x8;
}