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
public enum VkResolveModeFlagBits
{
    NONE                = 0,
    SAMPLE_ZERO_BIT     = 0x00000001,
    AVERAGE_BIT         = 0x00000002,
    MIN_BIT             = 0x00000004,
    MAX_BIT             = 0x00000008,
    NONE_KHR            = NONE,
    SAMPLE_ZERO_BIT_KHR = SAMPLE_ZERO_BIT,
    AVERAGE_BIT_KHR     = AVERAGE_BIT,
    MIN_BIT_KHR         = MIN_BIT,
    MAX_BIT_KHR         = MAX_BIT,
    FLAG_BITS_MAX_ENUM  = 0x7FFFFFFF
}