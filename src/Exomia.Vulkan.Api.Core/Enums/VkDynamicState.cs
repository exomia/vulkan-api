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

public enum VkDynamicState
{
    VIEWPORT                            = 0,
    SCISSOR                             = 1,
    LINE_WIDTH                          = 2,
    DEPTH_BIAS                          = 3,
    BLEND_CONSTANTS                     = 4,
    DEPTH_BOUNDS                        = 5,
    STENCIL_COMPARE_MASK                = 6,
    STENCIL_WRITE_MASK                  = 7,
    STENCIL_REFERENCE                   = 8,
    VIEWPORT_W_SCALING_NV               = 1000087000,
    DISCARD_RECTANGLE_EXT               = 1000099000,
    SAMPLE_LOCATIONS_EXT                = 1000143000,
    RAY_TRACING_PIPELINE_STACK_SIZE_KHR = 1000347000,
    VIEWPORT_SHADING_RATE_PALETTE_NV    = 1000164004,
    VIEWPORT_COARSE_SAMPLE_ORDER_NV     = 1000164006,
    EXCLUSIVE_SCISSOR_NV                = 1000205001,
    FRAGMENT_SHADING_RATE_KHR           = 1000226000,
    LINE_STIPPLE_EXT                    = 1000259000,
    CULL_MODE_EXT                       = 1000267000,
    FRONT_FACE_EXT                      = 1000267001,
    PRIMITIVE_TOPOLOGY_EXT              = 1000267002,
    VIEWPORT_WITH_COUNT_EXT             = 1000267003,
    SCISSOR_WITH_COUNT_EXT              = 1000267004,
    VERTEX_INPUT_BINDING_STRIDE_EXT     = 1000267005,
    DEPTH_TEST_ENABLE_EXT               = 1000267006,
    DEPTH_WRITE_ENABLE_EXT              = 1000267007,
    DEPTH_COMPARE_OP_EXT                = 1000267008,
    DEPTH_BOUNDS_TEST_ENABLE_EXT        = 1000267009,
    STENCIL_TEST_ENABLE_EXT             = 1000267010,
    STENCIL_OP_EXT                      = 1000267011,
    VERTEX_INPUT_EXT                    = 1000352000,
    PATCH_CONTROL_POINTS_EXT            = 1000377000,
    RASTERIZER_DISCARD_ENABLE_EXT       = 1000377001,
    DEPTH_BIAS_ENABLE_EXT               = 1000377002,
    LOGIC_OP_EXT                        = 1000377003,
    PRIMITIVE_RESTART_ENABLE_EXT        = 1000377004,
    COLOR_WRITE_ENABLE_EXT              = 1000381000,
    MAX_ENUM                            = 0x7FFFFFFF
}