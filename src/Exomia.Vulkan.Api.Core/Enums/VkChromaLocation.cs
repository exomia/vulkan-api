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

public enum VkChromaLocation
{
    COSITED_EVEN     = 0,
    MIDPOINT         = 1,
    COSITED_EVEN_KHR = COSITED_EVEN,
    MIDPOINT_KHR     = MIDPOINT,
    MAX_ENUM         = 0x7FFFFFFF
}