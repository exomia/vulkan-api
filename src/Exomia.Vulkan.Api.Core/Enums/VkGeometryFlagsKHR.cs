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
public enum VkGeometryFlagsKHR
{
    OPAQUE_BIT_KHR                          = 0x00000001,
    NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR = 0x00000002,
    OPAQUE_BIT_NV                           = OPAQUE_BIT_KHR,
    NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV  = NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR,
    FLAG_BITS_MAX_ENUM_KHR                  = 0x7FFFFFFF
}