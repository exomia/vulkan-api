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
public enum VkSampleCountFlagBits
{
    _1_BIT             = 0x00000001,
    _2_BIT             = 0x00000002,
    _4_BIT             = 0x00000004,
    _8_BIT             = 0x00000008,
    _16_BIT            = 0x00000010,
    _32_BIT            = 0x00000020,
    _64_BIT            = 0x00000040,
    FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
}