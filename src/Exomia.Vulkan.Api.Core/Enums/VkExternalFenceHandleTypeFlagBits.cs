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
    public enum VkExternalFenceHandleTypeFlagBits
    {
        OPAQUE_FD_BIT            = 0x00000001,
        OPAQUE_WIN32_BIT         = 0x00000002,
        OPAQUE_WIN32_KMT_BIT     = 0x00000004,
        SYNC_FD_BIT              = 0x00000008,
        OPAQUE_FD_BIT_KHR        = OPAQUE_FD_BIT,
        OPAQUE_WIN32_BIT_KHR     = OPAQUE_WIN32_BIT,
        OPAQUE_WIN32_KMT_BIT_KHR = OPAQUE_WIN32_KMT_BIT,
        SYNC_FD_BIT_KHR          = SYNC_FD_BIT,
        FLAG_BITS_MAX_ENUM       = 0x7FFFFFFF
    }
}