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
    public enum VkPipelineStageFlagBits
    {
        TOP_OF_PIPE_BIT                          = 0x00000001,
        DRAW_INDIRECT_BIT                        = 0x00000002,
        VERTEX_INPUT_BIT                         = 0x00000004,
        VERTEX_SHADER_BIT                        = 0x00000008,
        TESSELLATION_CONTROL_SHADER_BIT          = 0x00000010,
        TESSELLATION_EVALUATION_SHADER_BIT       = 0x00000020,
        GEOMETRY_SHADER_BIT                      = 0x00000040,
        FRAGMENT_SHADER_BIT                      = 0x00000080,
        EARLY_FRAGMENT_TESTS_BIT                 = 0x00000100,
        LATE_FRAGMENT_TESTS_BIT                  = 0x00000200,
        COLOR_ATTACHMENT_OUTPUT_BIT              = 0x00000400,
        COMPUTE_SHADER_BIT                       = 0x00000800,
        TRANSFER_BIT                             = 0x00001000,
        BOTTOM_OF_PIPE_BIT                       = 0x00002000,
        HOST_BIT                                 = 0x00004000,
        ALL_GRAPHICS_BIT                         = 0x00008000,
        ALL_COMMANDS_BIT                         = 0x00010000,
        TRANSFORM_FEEDBACK_BIT_EXT               = 0x01000000,
        CONDITIONAL_RENDERING_BIT_EXT            = 0x00040000,
        ACCELERATION_STRUCTURE_BUILD_BIT_KHR     = 0x02000000,
        RAY_TRACING_SHADER_BIT_KHR               = 0x00200000,
        TASK_SHADER_BIT_NV                       = 0x00080000,
        MESH_SHADER_BIT_NV                       = 0x00100000,
        FRAGMENT_DENSITY_PROCESS_BIT_EXT         = 0x00800000,
        FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00400000,
        COMMAND_PREPROCESS_BIT_NV                = 0x00020000,
        NONE_KHR                                 = 0,
        SHADING_RATE_IMAGE_BIT_NV                = FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,
        RAY_TRACING_SHADER_BIT_NV                = RAY_TRACING_SHADER_BIT_KHR,
        ACCELERATION_STRUCTURE_BUILD_BIT_NV      = ACCELERATION_STRUCTURE_BUILD_BIT_KHR,
        FLAG_BITS_MAX_ENUM                       = 0x7FFFFFFF
    }
}