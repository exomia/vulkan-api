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
    public enum VkQueryPipelineStatisticFlagBits
    {
        INPUT_ASSEMBLY_VERTICES_BIT                    = 0x00000001,
        INPUT_ASSEMBLY_PRIMITIVES_BIT                  = 0x00000002,
        VERTEX_SHADER_INVOCATIONS_BIT                  = 0x00000004,
        GEOMETRY_SHADER_INVOCATIONS_BIT                = 0x00000008,
        GEOMETRY_SHADER_PRIMITIVES_BIT                 = 0x00000010,
        CLIPPING_INVOCATIONS_BIT                       = 0x00000020,
        CLIPPING_PRIMITIVES_BIT                        = 0x00000040,
        FRAGMENT_SHADER_INVOCATIONS_BIT                = 0x00000080,
        TESSELLATION_CONTROL_SHADER_PATCHES_BIT        = 0x00000100,
        TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT = 0x00000200,
        COMPUTE_SHADER_INVOCATIONS_BIT                 = 0x00000400,
        FLAG_BITS_MAX_ENUM                             = 0x7FFFFFFF
    }
}