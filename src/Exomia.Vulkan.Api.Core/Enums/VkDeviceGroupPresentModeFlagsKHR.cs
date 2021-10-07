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
    public enum VkDeviceGroupPresentModeFlagsKHR
    {
        LOCAL_BIT_KHR              = 0x00000001,
        REMOTE_BIT_KHR             = 0x00000002,
        SUM_BIT_KHR                = 0x00000004,
        LOCAL_MULTI_DEVICE_BIT_KHR = 0x00000008,
        FLAG_BITS_MAX_ENUM_KHR     = 0x7FFFFFFF
    }
}