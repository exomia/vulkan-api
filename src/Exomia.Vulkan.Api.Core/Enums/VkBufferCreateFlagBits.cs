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
public enum VkBufferCreateFlagBits
{
    SPARSE_BINDING_BIT                    = 0x00000001,
    SPARSE_RESIDENCY_BIT                  = 0x00000002,
    SPARSE_ALIASED_BIT                    = 0x00000004,
    PROTECTED_BIT                         = 0x00000008,
    DEVICE_ADDRESS_CAPTURE_REPLAY_BIT     = 0x00000010,
    DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = DEVICE_ADDRESS_CAPTURE_REPLAY_BIT,
    DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = DEVICE_ADDRESS_CAPTURE_REPLAY_BIT,
    FLAG_BITS_MAX_ENUM                    = 0x7FFFFFFF
}