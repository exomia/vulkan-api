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

public enum VkImageLayout
{
    UNDEFINED                                      = 0,
    GENERAL                                        = 1,
    COLOR_ATTACHMENT_OPTIMAL                       = 2,
    DEPTH_STENCIL_ATTACHMENT_OPTIMAL               = 3,
    DEPTH_STENCIL_READ_ONLY_OPTIMAL                = 4,
    SHADER_READ_ONLY_OPTIMAL                       = 5,
    TRANSFER_SRC_OPTIMAL                           = 6,
    TRANSFER_DST_OPTIMAL                           = 7,
    PREINITIALIZED                                 = 8,
    DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL     = 1000117000,
    DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL     = 1000117001,
    DEPTH_ATTACHMENT_OPTIMAL                       = 1000241000,
    DEPTH_READ_ONLY_OPTIMAL                        = 1000241001,
    STENCIL_ATTACHMENT_OPTIMAL                     = 1000241002,
    STENCIL_READ_ONLY_OPTIMAL                      = 1000241003,
    PRESENT_SRC_KHR                                = 1000001002,
    VIDEO_DECODE_DST_KHR                           = 1000024000,
    VIDEO_DECODE_SRC_KHR                           = 1000024001,
    VIDEO_DECODE_DPB_KHR                           = 1000024002,
    SHARED_PRESENT_KHR                             = 1000111000,
    FRAGMENT_DENSITY_MAP_OPTIMAL_EXT               = 1000218000,
    FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR   = 1000164003,
    VIDEO_ENCODE_DST_KHR                           = 1000299000,
    VIDEO_ENCODE_SRC_KHR                           = 1000299001,
    VIDEO_ENCODE_DPB_KHR                           = 1000299002,
    READ_ONLY_OPTIMAL_KHR                          = 1000314000,
    ATTACHMENT_OPTIMAL_KHR                         = 1000314001,
    DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR = DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL,
    DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR = DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL,
    SHADING_RATE_OPTIMAL_NV                        = FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR,
    DEPTH_ATTACHMENT_OPTIMAL_KHR                   = DEPTH_ATTACHMENT_OPTIMAL,
    DEPTH_READ_ONLY_OPTIMAL_KHR                    = DEPTH_READ_ONLY_OPTIMAL,
    STENCIL_ATTACHMENT_OPTIMAL_KHR                 = STENCIL_ATTACHMENT_OPTIMAL,
    STENCIL_READ_ONLY_OPTIMAL_KHR                  = STENCIL_READ_ONLY_OPTIMAL,
    MAX_ENUM                                       = 0x7FFFFFFF
}