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
    public enum VkColorComponentFlagBits
    {
        R_BIT              = 0x00000001,
        G_BIT              = 0x00000002,
        B_BIT              = 0x00000004,
        A_BIT              = 0x00000008,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
}