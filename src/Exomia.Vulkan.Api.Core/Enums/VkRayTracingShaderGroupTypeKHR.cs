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
namespace Exomia.Vulkan.Api.Core
{
    public enum VkRayTracingShaderGroupTypeKHR
    {
        GENERAL_KHR              = 0,
        TRIANGLES_HIT_GROUP_KHR  = 1,
        PROCEDURAL_HIT_GROUP_KHR = 2,
        GENERAL_NV               = GENERAL_KHR,
        TRIANGLES_HIT_GROUP_NV   = TRIANGLES_HIT_GROUP_KHR,
        PROCEDURAL_HIT_GROUP_NV  = PROCEDURAL_HIT_GROUP_KHR,
        MAX_ENUM_KHR             = 0x7FFFFFFF
    }
}