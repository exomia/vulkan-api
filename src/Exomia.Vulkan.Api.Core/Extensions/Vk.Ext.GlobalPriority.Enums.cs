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
namespace Exomia.Vulkan.Api.Core.Extensions
{

    public enum VkQueueGlobalPriorityEXT
    {
        LOW_EXT      = 128,
        MEDIUM_EXT   = 256,
        HIGH_EXT     = 512,
        REALTIME_EXT = 1024,
        MAX_ENUM_EXT = 0x7FFFFFFF
    }
}
