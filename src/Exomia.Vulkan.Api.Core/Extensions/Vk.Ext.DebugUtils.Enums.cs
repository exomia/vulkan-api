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
    public enum VkDebugUtilsMessageSeverityFlagsEXT
    {
        VERBOSE_BIT_EXT = 0x00000001,
        INFO_BIT_EXT = 0x00000010,
        WARNING_BIT_EXT = 0x00000100,
        ERROR_BIT_EXT = 0x00001000,
        FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDebugUtilsMessageTypeFlagsEXT
    {
        GENERAL_BIT_EXT = 0x00000001,
        VALIDATION_BIT_EXT = 0x00000002,
        PERFORMANCE_BIT_EXT = 0x00000004,
        FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }
}
