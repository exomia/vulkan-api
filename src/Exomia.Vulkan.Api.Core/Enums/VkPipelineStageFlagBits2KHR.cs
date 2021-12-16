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
public enum VkPipelineStageFlagBits2KHR : ulong
{
    NONE_KHR                                 = 0UL,
    TOP_OF_PIPE_BIT_KHR                      = 0x00000001UL,
    DRAW_INDIRECT_BIT_KHR                    = 0x00000002UL,
    VERTEX_INPUT_BIT_KHR                     = 0x00000004UL,
    VERTEX_SHADER_BIT_KHR                    = 0x00000008UL,
    TESSELLATION_CONTROL_SHADER_BIT_KHR      = 0x00000010UL,
    TESSELLATION_EVALUATION_SHADER_BIT_KHR   = 0x00000020UL,
    GEOMETRY_SHADER_BIT_KHR                  = 0x00000040UL,
    FRAGMENT_SHADER_BIT_KHR                  = 0x00000080UL,
    EARLY_FRAGMENT_TESTS_BIT_KHR             = 0x00000100UL,
    LATE_FRAGMENT_TESTS_BIT_KHR              = 0x00000200UL,
    COLOR_ATTACHMENT_OUTPUT_BIT_KHR          = 0x00000400UL,
    COMPUTE_SHADER_BIT_KHR                   = 0x00000800UL,
    ALL_TRANSFER_BIT_KHR                     = 0x00001000UL,
    TRANSFER_BIT_KHR                         = 0x00001000UL,
    BOTTOM_OF_PIPE_BIT_KHR                   = 0x00002000UL,
    HOST_BIT_KHR                             = 0x00004000UL,
    ALL_GRAPHICS_BIT_KHR                     = 0x00008000UL,
    ALL_COMMANDS_BIT_KHR                     = 0x00010000UL,
    COPY_BIT_KHR                             = 0x100000000UL,
    RESOLVE_BIT_KHR                          = 0x200000000UL,
    BLIT_BIT_KHR                             = 0x400000000UL,
    CLEAR_BIT_KHR                            = 0x800000000UL,
    INDEX_INPUT_BIT_KHR                      = 0x1000000000UL,
    VERTEX_ATTRIBUTE_INPUT_BIT_KHR           = 0x2000000000UL,
    PRE_RASTERIZATION_SHADERS_BIT_KHR        = 0x4000000000UL,
    VIDEO_DECODE_BIT_KHR                     = 0x04000000UL,
    VIDEO_ENCODE_BIT_KHR                     = 0x08000000UL,
    RESERVED_26_BIT_KHR                      = 0x04000000,
    RESERVED_27_BIT_KHR                      = 0x08000000,
    TRANSFORM_FEEDBACK_BIT_EXT               = 0x01000000UL,
    CONDITIONAL_RENDERING_BIT_EXT            = 0x00040000UL,
    COMMAND_PREPROCESS_BIT_NV                = 0x00020000UL,
    FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00400000UL,
    SHADING_RATE_IMAGE_BIT_NV                = 0x00400000UL,
    ACCELERATION_STRUCTURE_BUILD_BIT_KHR     = 0x02000000UL,
    RAY_TRACING_SHADER_BIT_KHR               = 0x00200000UL,
    RAY_TRACING_SHADER_BIT_NV                = 0x00200000UL,
    ACCELERATION_STRUCTURE_BUILD_BIT_NV      = 0x02000000UL,
    FRAGMENT_DENSITY_PROCESS_BIT_EXT         = 0x00800000UL,
    TASK_SHADER_BIT_NV                       = 0x00080000UL,
    MESH_SHADER_BIT_NV                       = 0x00100000UL,
    SUBPASS_SHADING_BIT_HUAWEI               = 0x8000000000UL
}