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
public enum VkImageAspectFlagBits
{
    COLOR_BIT              = 0x00000001,
    DEPTH_BIT              = 0x00000002,
    STENCIL_BIT            = 0x00000004,
    METADATA_BIT           = 0x00000008,
    PLANE_0_BIT            = 0x00000010,
    PLANE_1_BIT            = 0x00000020,
    PLANE_2_BIT            = 0x00000040,
    MEMORY_PLANE_0_BIT_EXT = 0x00000080,
    MEMORY_PLANE_1_BIT_EXT = 0x00000100,
    MEMORY_PLANE_2_BIT_EXT = 0x00000200,
    MEMORY_PLANE_3_BIT_EXT = 0x00000400,
    PLANE_0_BIT_KHR        = PLANE_0_BIT,
    PLANE_1_BIT_KHR        = PLANE_1_BIT,
    PLANE_2_BIT_KHR        = PLANE_2_BIT,
    FLAG_BITS_MAX_ENUM     = 0x7FFFFFFF
}