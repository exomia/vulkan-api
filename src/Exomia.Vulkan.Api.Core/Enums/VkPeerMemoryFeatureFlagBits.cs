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
public enum VkPeerMemoryFeatureFlagBits
{
    COPY_SRC_BIT        = 0x00000001,
    COPY_DST_BIT        = 0x00000002,
    GENERIC_SRC_BIT     = 0x00000004,
    GENERIC_DST_BIT     = 0x00000008,
    COPY_SRC_BIT_KHR    = COPY_SRC_BIT,
    COPY_DST_BIT_KHR    = COPY_DST_BIT,
    GENERIC_SRC_BIT_KHR = GENERIC_SRC_BIT,
    GENERIC_DST_BIT_KHR = GENERIC_DST_BIT,
    FLAG_BITS_MAX_ENUM  = 0x7FFFFFFF
}