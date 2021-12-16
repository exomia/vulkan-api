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
public enum VkBuildAccelerationStructureFlagsKHR
{
    ALLOW_UPDATE_BIT_KHR      = 0x00000001,
    ALLOW_COMPACTION_BIT_KHR  = 0x00000002,
    PREFER_FAST_TRACE_BIT_KHR = 0x00000004,
    PREFER_FAST_BUILD_BIT_KHR = 0x00000008,
    LOW_MEMORY_BIT_KHR        = 0x00000010,
    STRUCTURE_MOTION_BIT_NV   = 0x00000020,
    ALLOW_UPDATE_BIT_NV       = ALLOW_UPDATE_BIT_KHR,
    ALLOW_COMPACTION_BIT_NV   = ALLOW_COMPACTION_BIT_KHR,
    PREFER_FAST_TRACE_BIT_NV  = PREFER_FAST_TRACE_BIT_KHR,
    PREFER_FAST_BUILD_BIT_NV  = PREFER_FAST_BUILD_BIT_KHR,
    LOW_MEMORY_BIT_NV         = LOW_MEMORY_BIT_KHR,
    FLAG_BITS_MAX_ENUM_KHR    = 0x7FFFFFFF
}