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

public enum VkComponentSwizzle
{
    IDENTITY = 0,
    ZERO     = 1,
    ONE      = 2,
    R        = 3,
    G        = 4,
    B        = 5,
    A        = 6,
    MAX_ENUM = 0x7FFFFFFF
}