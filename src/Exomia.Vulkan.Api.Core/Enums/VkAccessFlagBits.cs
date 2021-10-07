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
    public enum VkAccessFlagBits
    {
        INDIRECT_COMMAND_READ_BIT                     = 0x00000001,
        INDEX_READ_BIT                                = 0x00000002,
        VERTEX_ATTRIBUTE_READ_BIT                     = 0x00000004,
        UNIFORM_READ_BIT                              = 0x00000008,
        INPUT_ATTACHMENT_READ_BIT                     = 0x00000010,
        SHADER_READ_BIT                               = 0x00000020,
        SHADER_WRITE_BIT                              = 0x00000040,
        COLOR_ATTACHMENT_READ_BIT                     = 0x00000080,
        COLOR_ATTACHMENT_WRITE_BIT                    = 0x00000100,
        DEPTH_STENCIL_ATTACHMENT_READ_BIT             = 0x00000200,
        DEPTH_STENCIL_ATTACHMENT_WRITE_BIT            = 0x00000400,
        TRANSFER_READ_BIT                             = 0x00000800,
        TRANSFER_WRITE_BIT                            = 0x00001000,
        HOST_READ_BIT                                 = 0x00002000,
        HOST_WRITE_BIT                                = 0x00004000,
        MEMORY_READ_BIT                               = 0x00008000,
        MEMORY_WRITE_BIT                              = 0x00010000,
        TRANSFORM_FEEDBACK_WRITE_BIT_EXT              = 0x02000000,
        TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT       = 0x04000000,
        TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT      = 0x08000000,
        CONDITIONAL_RENDERING_READ_BIT_EXT            = 0x00100000,
        COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT     = 0x00080000,
        ACCELERATION_STRUCTURE_READ_BIT_KHR           = 0x00200000,
        ACCELERATION_STRUCTURE_WRITE_BIT_KHR          = 0x00400000,
        FRAGMENT_DENSITY_MAP_READ_BIT_EXT             = 0x01000000,
        FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 0x00800000,
        COMMAND_PREPROCESS_READ_BIT_NV                = 0x00020000,
        COMMAND_PREPROCESS_WRITE_BIT_NV               = 0x00040000,
        NONE_KHR                                      = 0,
        SHADING_RATE_IMAGE_READ_BIT_NV                = FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR,
        ACCELERATION_STRUCTURE_READ_BIT_NV            = ACCELERATION_STRUCTURE_READ_BIT_KHR,
        ACCELERATION_STRUCTURE_WRITE_BIT_NV           = ACCELERATION_STRUCTURE_WRITE_BIT_KHR,
        FLAG_BITS_MAX_ENUM                            = 0x7FFFFFFF
    }
}