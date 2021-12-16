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
public enum VkShaderStageFlagBits
{
    VERTEX_BIT                  = 0x00000001,
    TESSELLATION_CONTROL_BIT    = 0x00000002,
    TESSELLATION_EVALUATION_BIT = 0x00000004,
    GEOMETRY_BIT                = 0x00000008,
    FRAGMENT_BIT                = 0x00000010,
    COMPUTE_BIT                 = 0x00000020,
    ALL_GRAPHICS                = 0x0000001F,
    ALL                         = 0x7FFFFFFF,
    RAYGEN_BIT_KHR              = 0x00000100,
    ANY_HIT_BIT_KHR             = 0x00000200,
    CLOSEST_HIT_BIT_KHR         = 0x00000400,
    MISS_BIT_KHR                = 0x00000800,
    INTERSECTION_BIT_KHR        = 0x00001000,
    CALLABLE_BIT_KHR            = 0x00002000,
    TASK_BIT_NV                 = 0x00000040,
    MESH_BIT_NV                 = 0x00000080,
    SUBPASS_SHADING_BIT_HUAWEI  = 0x00004000,
    RAYGEN_BIT_NV               = RAYGEN_BIT_KHR,
    ANY_HIT_BIT_NV              = ANY_HIT_BIT_KHR,
    CLOSEST_HIT_BIT_NV          = CLOSEST_HIT_BIT_KHR,
    MISS_BIT_NV                 = MISS_BIT_KHR,
    INTERSECTION_BIT_NV         = INTERSECTION_BIT_KHR,
    CALLABLE_BIT_NV             = CALLABLE_BIT_KHR,
    FLAG_BITS_MAX_ENUM          = 0x7FFFFFFF
}