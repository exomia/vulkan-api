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
public enum VkBufferUsageFlagBits
{
    TRANSFER_SRC_BIT                                     = 0x00000001,
    TRANSFER_DST_BIT                                     = 0x00000002,
    UNIFORM_TEXEL_BUFFER_BIT                             = 0x00000004,
    STORAGE_TEXEL_BUFFER_BIT                             = 0x00000008,
    UNIFORM_BUFFER_BIT                                   = 0x00000010,
    STORAGE_BUFFER_BIT                                   = 0x00000020,
    INDEX_BUFFER_BIT                                     = 0x00000040,
    VERTEX_BUFFER_BIT                                    = 0x00000080,
    INDIRECT_BUFFER_BIT                                  = 0x00000100,
    SHADER_DEVICE_ADDRESS_BIT                            = 0x00020000,
    VIDEO_DECODE_SRC_BIT_KHR                             = 0x00002000,
    VIDEO_DECODE_DST_BIT_KHR                             = 0x00004000,
    TRANSFORM_FEEDBACK_BUFFER_BIT_EXT                    = 0x00000800,
    TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT            = 0x00001000,
    CONDITIONAL_RENDERING_BIT_EXT                        = 0x00000200,
    ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = 0x00080000,
    ACCELERATION_STRUCTURE_STORAGE_BIT_KHR               = 0x00100000,
    SHADER_BINDING_TABLE_BIT_KHR                         = 0x00000400,
    VIDEO_ENCODE_DST_BIT_KHR                             = 0x00008000,
    VIDEO_ENCODE_SRC_BIT_KHR                             = 0x00010000,
    RAY_TRACING_BIT_NV                                   = SHADER_BINDING_TABLE_BIT_KHR,
    SHADER_DEVICE_ADDRESS_BIT_EXT                        = SHADER_DEVICE_ADDRESS_BIT,
    SHADER_DEVICE_ADDRESS_BIT_KHR                        = SHADER_DEVICE_ADDRESS_BIT,
    FLAG_BITS_MAX_ENUM                                   = 0x7FFFFFFF
}