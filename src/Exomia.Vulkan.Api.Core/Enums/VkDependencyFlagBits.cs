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
public enum VkDependencyFlagBits
{
    BY_REGION_BIT        = 0x00000001,
    DEVICE_GROUP_BIT     = 0x00000004,
    VIEW_LOCAL_BIT       = 0x00000002,
    VIEW_LOCAL_BIT_KHR   = VIEW_LOCAL_BIT,
    DEVICE_GROUP_BIT_KHR = DEVICE_GROUP_BIT,
    FLAG_BITS_MAX_ENUM   = 0x7FFFFFFF
}