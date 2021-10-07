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
    public enum VkImageUsageFlagBits
    {
        TRANSFER_SRC_BIT                         = 0x00000001,
        TRANSFER_DST_BIT                         = 0x00000002,
        SAMPLED_BIT                              = 0x00000004,
        STORAGE_BIT                              = 0x00000008,
        COLOR_ATTACHMENT_BIT                     = 0x00000010,
        DEPTH_STENCIL_ATTACHMENT_BIT             = 0x00000020,
        TRANSIENT_ATTACHMENT_BIT                 = 0x00000040,
        INPUT_ATTACHMENT_BIT                     = 0x00000080,
        VIDEO_DECODE_DST_BIT_KHR                 = 0x00000400,
        VIDEO_DECODE_SRC_BIT_KHR                 = 0x00000800,
        VIDEO_DECODE_DPB_BIT_KHR                 = 0x00001000,
        FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00000100,
        FRAGMENT_DENSITY_MAP_BIT_EXT             = 0x00000200,
        VIDEO_ENCODE_DST_BIT_KHR                 = 0x00002000,
        VIDEO_ENCODE_SRC_BIT_KHR                 = 0x00004000,
        VIDEO_ENCODE_DPB_BIT_KHR                 = 0x00008000,
        SHADING_RATE_IMAGE_BIT_NV                = FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,
        FLAG_BITS_MAX_ENUM                       = 0x7FFFFFFF
    }
}