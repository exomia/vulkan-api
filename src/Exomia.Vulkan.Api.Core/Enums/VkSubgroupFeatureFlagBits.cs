#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[Flags]
public enum VkSubgroupFeatureFlagBits
{
    BASIC_BIT            = 0x00000001,
    VOTE_BIT             = 0x00000002,
    ARITHMETIC_BIT       = 0x00000004,
    BALLOT_BIT           = 0x00000008,
    SHUFFLE_BIT          = 0x00000010,
    SHUFFLE_RELATIVE_BIT = 0x00000020,
    CLUSTERED_BIT        = 0x00000040,
    QUAD_BIT             = 0x00000080,
    PARTITIONED_BIT_NV   = 0x00000100,
    FLAG_BITS_MAX_ENUM   = 0x7FFFFFFF
}