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
    public enum VkDescriptorBindingFlagBits
    {
        UPDATE_AFTER_BIND_BIT               = 0x00000001,
        UPDATE_UNUSED_WHILE_PENDING_BIT     = 0x00000002,
        PARTIALLY_BOUND_BIT                 = 0x00000004,
        VARIABLE_DESCRIPTOR_COUNT_BIT       = 0x00000008,
        UPDATE_AFTER_BIND_BIT_EXT           = UPDATE_AFTER_BIND_BIT,
        UPDATE_UNUSED_WHILE_PENDING_BIT_EXT = UPDATE_UNUSED_WHILE_PENDING_BIT,
        PARTIALLY_BOUND_BIT_EXT             = PARTIALLY_BOUND_BIT,
        VARIABLE_DESCRIPTOR_COUNT_BIT_EXT   = VARIABLE_DESCRIPTOR_COUNT_BIT,
        FLAG_BITS_MAX_ENUM                  = 0x7FFFFFFF
    }
}