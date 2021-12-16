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

public enum VkSamplerYcbcrModelConversion
{
    RGB_IDENTITY       = 0,
    YCBCR_IDENTITY     = 1,
    YCBCR_709          = 2,
    YCBCR_601          = 3,
    YCBCR_2020         = 4,
    RGB_IDENTITY_KHR   = RGB_IDENTITY,
    YCBCR_IDENTITY_KHR = YCBCR_IDENTITY,
    YCBCR_709_KHR      = YCBCR_709,
    YCBCR_601_KHR      = YCBCR_601,
    YCBCR_2020_KHR     = YCBCR_2020,
    MAX_ENUM           = 0x7FFFFFFF
}