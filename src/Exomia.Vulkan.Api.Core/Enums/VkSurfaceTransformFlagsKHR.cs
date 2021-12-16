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
public enum VkSurfaceTransformFlagsKHR
{
    IDENTITY_BIT_KHR                     = 0x00000001,
    ROTATE_90_BIT_KHR                    = 0x00000002,
    ROTATE_180_BIT_KHR                   = 0x00000004,
    ROTATE_270_BIT_KHR                   = 0x00000008,
    HORIZONTAL_MIRROR_BIT_KHR            = 0x00000010,
    HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR  = 0x00000020,
    HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR = 0x00000040,
    HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR = 0x00000080,
    INHERIT_BIT_KHR                      = 0x00000100,
    FLAG_BITS_MAX_ENUM_KHR               = 0x7FFFFFFF
}