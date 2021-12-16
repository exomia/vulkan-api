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
public enum VkAccessFlagBits2KHR : ulong
{
    NONE_KHR                                      = 0UL,
    INDIRECT_COMMAND_READ_BIT_KHR                 = 0x00000001UL,
    INDEX_READ_BIT_KHR                            = 0x00000002UL,
    VERTEX_ATTRIBUTE_READ_BIT_KHR                 = 0x00000004UL,
    UNIFORM_READ_BIT_KHR                          = 0x00000008UL,
    INPUT_ATTACHMENT_READ_BIT_KHR                 = 0x00000010UL,
    SHADER_READ_BIT_KHR                           = 0x00000020UL,
    SHADER_WRITE_BIT_KHR                          = 0x00000040UL,
    COLOR_ATTACHMENT_READ_BIT_KHR                 = 0x00000080UL,
    COLOR_ATTACHMENT_WRITE_BIT_KHR                = 0x00000100UL,
    DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR         = 0x00000200UL,
    DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR        = 0x00000400UL,
    TRANSFER_READ_BIT_KHR                         = 0x00000800UL,
    TRANSFER_WRITE_BIT_KHR                        = 0x00001000UL,
    HOST_READ_BIT_KHR                             = 0x00002000UL,
    HOST_WRITE_BIT_KHR                            = 0x00004000UL,
    MEMORY_READ_BIT_KHR                           = 0x00008000UL,
    MEMORY_WRITE_BIT_KHR                          = 0x00010000UL,
    SHADER_SAMPLED_READ_BIT_KHR                   = 0x100000000UL,
    SHADER_STORAGE_READ_BIT_KHR                   = 0x200000000UL,
    SHADER_STORAGE_WRITE_BIT_KHR                  = 0x400000000UL,
    VIDEO_DECODE_READ_BIT_KHR                     = 0x800000000UL,
    VIDEO_DECODE_WRITE_BIT_KHR                    = 0x1000000000UL,
    VIDEO_ENCODE_READ_BIT_KHR                     = 0x2000000000UL,
    VIDEO_ENCODE_WRITE_BIT_KHR                    = 0x4000000000UL,
    RESERVED_READ_35_BIT_KHR                      = 0x800000000UL,
    RESERVED_WRITE_36_BIT_KHR                     = 0x1000000000UL,
    RESERVED_READ_37_BIT_KHR                      = 0x2000000000UL,
    RESERVED_WRITE_38_BIT_KHR                     = 0x4000000000UL,
    TRANSFORM_FEEDBACK_WRITE_BIT_EXT              = 0x02000000UL,
    TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT       = 0x04000000UL,
    TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT      = 0x08000000UL,
    CONDITIONAL_RENDERING_READ_BIT_EXT            = 0x00100000UL,
    COMMAND_PREPROCESS_READ_BIT_NV                = 0x00020000UL,
    COMMAND_PREPROCESS_WRITE_BIT_NV               = 0x00040000UL,
    FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 0x00800000UL,
    SHADING_RATE_IMAGE_READ_BIT_NV                = 0x00800000UL,
    ACCELERATION_STRUCTURE_READ_BIT_KHR           = 0x00200000UL,
    ACCELERATION_STRUCTURE_WRITE_BIT_KHR          = 0x00400000UL,
    ACCELERATION_STRUCTURE_READ_BIT_NV            = 0x00200000UL,
    ACCELERATION_STRUCTURE_WRITE_BIT_NV           = 0x00400000UL,
    FRAGMENT_DENSITY_MAP_READ_BIT_EXT             = 0x01000000UL,
    COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT     = 0x00080000UL
}