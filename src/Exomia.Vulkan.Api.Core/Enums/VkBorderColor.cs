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

public enum VkBorderColor
{
    FLOAT_TRANSPARENT_BLACK = 0,
    INT_TRANSPARENT_BLACK   = 1,
    FLOAT_OPAQUE_BLACK      = 2,
    INT_OPAQUE_BLACK        = 3,
    FLOAT_OPAQUE_WHITE      = 4,
    INT_OPAQUE_WHITE        = 5,
    FLOAT_CUSTOM_EXT        = 1000287003,
    INT_CUSTOM_EXT          = 1000287004,
    MAX_ENUM                = 0x7FFFFFFF
}