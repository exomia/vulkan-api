﻿#region License

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
public enum VkGeometryInstanceFlagsKHR
{
    TRIANGLE_FACING_CULL_DISABLE_BIT_KHR    = 0x00000001,
    TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR = 0x00000002,
    FORCE_OPAQUE_BIT_KHR                    = 0x00000004,
    FORCE_NO_OPAQUE_BIT_KHR                 = 0x00000008,
    TRIANGLE_CULL_DISABLE_BIT_NV            = TRIANGLE_FACING_CULL_DISABLE_BIT_KHR,
    TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV  = TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR,
    FORCE_OPAQUE_BIT_NV                     = FORCE_OPAQUE_BIT_KHR,
    FORCE_NO_OPAQUE_BIT_NV                  = FORCE_NO_OPAQUE_BIT_KHR,
    FLAG_BITS_MAX_ENUM_KHR                  = 0x7FFFFFFF
}