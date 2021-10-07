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
    public enum VkCopyAccelerationStructureModeKHR
    {
        CLONE_KHR       = 0,
        COMPACT_KHR     = 1,
        SERIALIZE_KHR   = 2,
        DESERIALIZE_KHR = 3,
        CLONE_NV        = CLONE_KHR,
        COMPACT_NV      = COMPACT_KHR,
        MAX_ENUM_KHR    = 0x7FFFFFFF
    }
}