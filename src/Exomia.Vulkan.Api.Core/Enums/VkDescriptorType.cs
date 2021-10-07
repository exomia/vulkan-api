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
namespace Exomia.Vulkan.Api.Core
{
    public enum VkDescriptorType
    {
        SAMPLER                    = 0,
        COMBINED_IMAGE_SAMPLER     = 1,
        SAMPLED_IMAGE              = 2,
        STORAGE_IMAGE              = 3,
        UNIFORM_TEXEL_BUFFER       = 4,
        STORAGE_TEXEL_BUFFER       = 5,
        UNIFORM_BUFFER             = 6,
        STORAGE_BUFFER             = 7,
        UNIFORM_BUFFER_DYNAMIC     = 8,
        STORAGE_BUFFER_DYNAMIC     = 9,
        INPUT_ATTACHMENT           = 10,
        INLINE_UNIFORM_BLOCK_EXT   = 1000138000,
        ACCELERATION_STRUCTURE_KHR = 1000150000,
        ACCELERATION_STRUCTURE_NV  = 1000165000,
        MUTABLE_VALVE              = 1000351000,
        MAX_ENUM                   = 0x7FFFFFFF
    }
}