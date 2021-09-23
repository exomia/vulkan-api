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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Flags]
    public enum VkToolPurposeFlagsEXT
    {
        VALIDATION_BIT_EXT          = 0x00000001,
        PROFILING_BIT_EXT           = 0x00000002,
        TRACING_BIT_EXT             = 0x00000004,
        ADDITIONAL_FEATURES_BIT_EXT = 0x00000008,
        MODIFYING_FEATURES_BIT_EXT  = 0x00000010,
        DEBUG_REPORTING_BIT_EXT     = 0x00000020,
        DEBUG_MARKERS_BIT_EXT       = 0x00000040,
        FLAG_BITS_MAX_ENUM_EXT      = 0x7FFFFFFF
    }
}
