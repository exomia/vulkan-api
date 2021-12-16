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

public enum VkStencilOp
{
    KEEP                = 0,
    ZERO                = 1,
    REPLACE             = 2,
    INCREMENT_AND_CLAMP = 3,
    DECREMENT_AND_CLAMP = 4,
    INVERT              = 5,
    INCREMENT_AND_WRAP  = 6,
    DECREMENT_AND_WRAP  = 7,
    MAX_ENUM            = 0x7FFFFFFF
}