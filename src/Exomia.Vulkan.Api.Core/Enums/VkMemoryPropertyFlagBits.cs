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
    public enum VkMemoryPropertyFlagBits
    {
        DEVICE_LOCAL_BIT        = 0x00000001,
        HOST_VISIBLE_BIT        = 0x00000002,
        HOST_COHERENT_BIT       = 0x00000004,
        HOST_CACHED_BIT         = 0x00000008,
        LAZILY_ALLOCATED_BIT    = 0x00000010,
        PROTECTED_BIT           = 0x00000020,
        VIDEO_DECODE_BIT_KHR    = 0x00000020,
        VIDEO_ENCODE_BIT_KHR    = 0x00000040,
        DEVICE_COHERENT_BIT_AMD = 0x00000040,
        DEVICE_UNCACHED_BIT_AMD = 0x00000080,
        FLAG_BITS_MAX_ENUM      = 0x7FFFFFFF
    }
}