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
    public enum VkExternalMemoryFeatureFlagBits
    {
        DEDICATED_ONLY_BIT     = 0x00000001,
        EXPORTABLE_BIT         = 0x00000002,
        IMPORTABLE_BIT         = 0x00000004,
        DEDICATED_ONLY_BIT_KHR = DEDICATED_ONLY_BIT,
        EXPORTABLE_BIT_KHR     = EXPORTABLE_BIT,
        IMPORTABLE_BIT_KHR     = IMPORTABLE_BIT,
        FLAG_BITS_MAX_ENUM     = 0x7FFFFFFF
    }
}