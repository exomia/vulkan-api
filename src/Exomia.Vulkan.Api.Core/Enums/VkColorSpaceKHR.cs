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
    public enum VkColorSpaceKHR
    {
        SPACE_SRGB_NONLINEAR_KHR          = 0,
        SPACE_DISPLAY_P3_NONLINEAR_EXT    = 1000104001,
        SPACE_EXTENDED_SRGB_LINEAR_EXT    = 1000104002,
        SPACE_DISPLAY_P3_LINEAR_EXT       = 1000104003,
        SPACE_DCI_P3_NONLINEAR_EXT        = 1000104004,
        SPACE_BT709_LINEAR_EXT            = 1000104005,
        SPACE_BT709_NONLINEAR_EXT         = 1000104006,
        SPACE_BT2020_LINEAR_EXT           = 1000104007,
        SPACE_HDR10_ST2084_EXT            = 1000104008,
        SPACE_DOLBYVISION_EXT             = 1000104009,
        SPACE_HDR10_HLG_EXT               = 1000104010,
        SPACE_ADOBERGB_LINEAR_EXT         = 1000104011,
        SPACE_ADOBERGB_NONLINEAR_EXT      = 1000104012,
        SPACE_PASS_THROUGH_EXT            = 1000104013,
        SPACE_EXTENDED_SRGB_NONLINEAR_EXT = 1000104014,
        SPACE_DISPLAY_NATIVE_AMD          = 1000213000,
        VK_COLORSPACE_SRGB_NONLINEAR_KHR  = SPACE_SRGB_NONLINEAR_KHR,
        SPACE_DCI_P3_LINEAR_EXT           = SPACE_DISPLAY_P3_LINEAR_EXT,
        SPACE_MAX_ENUM_KHR                = 0x7FFFFFFF
    }
}