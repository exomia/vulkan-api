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
public enum VkSwapchainCreateFlagsKHR
{
    SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = 0x00000001,
    PROTECTED_BIT_KHR                   = 0x00000002,
    MUTABLE_FORMAT_BIT_KHR              = 0x00000004,
    FLAG_BITS_MAX_ENUM_KHR              = 0x7FFFFFFF
}