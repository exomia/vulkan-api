﻿#region License

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
    public enum VkDescriptorSetLayoutCreateFlagBits
    {
        UPDATE_AFTER_BIND_POOL_BIT     = 0x00000002,
        PUSH_DESCRIPTOR_BIT_KHR        = 0x00000001,
        HOST_ONLY_POOL_BIT_VALVE       = 0x00000004,
        UPDATE_AFTER_BIND_POOL_BIT_EXT = UPDATE_AFTER_BIND_POOL_BIT,
        FLAG_BITS_MAX_ENUM             = 0x7FFFFFFF
    }
}