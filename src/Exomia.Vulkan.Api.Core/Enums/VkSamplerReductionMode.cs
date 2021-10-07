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
namespace Exomia.Vulkan.Api.Core
{
    public enum VkSamplerReductionMode
    {
        WEIGHTED_AVERAGE     = 0,
        MIN                  = 1,
        MAX                  = 2,
        WEIGHTED_AVERAGE_EXT = WEIGHTED_AVERAGE,
        MIN_EXT              = MIN,
        MAX_EXT              = MAX,
        MAX_ENUM             = 0x7FFFFFFF
    }
}