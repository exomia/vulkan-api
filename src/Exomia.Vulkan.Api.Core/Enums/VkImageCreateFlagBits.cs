#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [Flags]
    public enum VkImageCreateFlagBits
    {
        SPARSE_BINDING_BIT                        = 0x00000001,
        SPARSE_RESIDENCY_BIT                      = 0x00000002,
        SPARSE_ALIASED_BIT                        = 0x00000004,
        MUTABLE_FORMAT_BIT                        = 0x00000008,
        CUBE_COMPATIBLE_BIT                       = 0x00000010,
        ALIAS_BIT                                 = 0x00000400,
        SPLIT_INSTANCE_BIND_REGIONS_BIT           = 0x00000040,
        _2D_ARRAY_COMPATIBLE_BIT                  = 0x00000020,
        BLOCK_TEXEL_VIEW_COMPATIBLE_BIT           = 0x00000080,
        EXTENDED_USAGE_BIT                        = 0x00000100,
        PROTECTED_BIT                             = 0x00000800,
        DISJOINT_BIT                              = 0x00000200,
        CORNER_SAMPLED_BIT_NV                     = 0x00002000,
        SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT = 0x00001000,
        SUBSAMPLED_BIT_EXT                        = 0x00004000,
        SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR       = SPLIT_INSTANCE_BIND_REGIONS_BIT,
        _2D_ARRAY_COMPATIBLE_BIT_KHR              = _2D_ARRAY_COMPATIBLE_BIT,
        BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR       = BLOCK_TEXEL_VIEW_COMPATIBLE_BIT,
        EXTENDED_USAGE_BIT_KHR                    = EXTENDED_USAGE_BIT,
        DISJOINT_BIT_KHR                          = DISJOINT_BIT,
        ALIAS_BIT_KHR                             = ALIAS_BIT,
        FLAG_BITS_MAX_ENUM                        = 0x7FFFFFFF
    }
}