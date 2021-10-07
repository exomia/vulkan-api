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
    public enum VkPipelineCreateFlagBits
    {
        DISABLE_OPTIMIZATION_BIT                               = 0x00000001,
        ALLOW_DERIVATIVES_BIT                                  = 0x00000002,
        DERIVATIVE_BIT                                         = 0x00000004,
        VIEW_INDEX_FROM_DEVICE_INDEX_BIT                       = 0x00000008,
        DISPATCH_BASE_BIT                                      = 0x00000010,
        RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR            = 0x00004000,
        RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR        = 0x00008000,
        RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR               = 0x00010000,
        RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR       = 0x00020000,
        RAY_TRACING_SKIP_TRIANGLES_BIT_KHR                     = 0x00001000,
        RAY_TRACING_SKIP_AABBS_BIT_KHR                         = 0x00002000,
        RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = 0x00080000,
        DEFER_COMPILE_BIT_NV                                   = 0x00000020,
        CAPTURE_STATISTICS_BIT_KHR                             = 0x00000040,
        CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR               = 0x00000080,
        INDIRECT_BINDABLE_BIT_NV                               = 0x00040000,
        LIBRARY_BIT_KHR                                        = 0x00000800,
        FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT              = 0x00000100,
        EARLY_RETURN_ON_FAILURE_BIT_EXT                        = 0x00000200,
        RAY_TRACING_ALLOW_MOTION_BIT_NV                        = 0x00100000,
        DISPATCH_BASE                                          = DISPATCH_BASE_BIT,
        VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR                   = VIEW_INDEX_FROM_DEVICE_INDEX_BIT,
        DISPATCH_BASE_KHR                                      = DISPATCH_BASE,
        FLAG_BITS_MAX_ENUM                                     = 0x7FFFFFFF
    }
}