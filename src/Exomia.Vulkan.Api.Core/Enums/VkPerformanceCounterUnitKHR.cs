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

public enum VkPerformanceCounterUnitKHR
{
    GENERIC_KHR          = 0,
    PERCENTAGE_KHR       = 1,
    NANOSECONDS_KHR      = 2,
    BYTES_KHR            = 3,
    BYTES_PER_SECOND_KHR = 4,
    KELVIN_KHR           = 5,
    WATTS_KHR            = 6,
    VOLTS_KHR            = 7,
    AMPS_KHR             = 8,
    HERTZ_KHR            = 9,
    CYCLES_KHR           = 10,
    MAX_ENUM_KHR         = 0x7FFFFFFF
}