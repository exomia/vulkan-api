﻿#region License

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
    public enum VkBlendOp
    {
        ADD                    = 0,
        SUBTRACT               = 1,
        REVERSE_SUBTRACT       = 2,
        MIN                    = 3,
        MAX                    = 4,
        ZERO_EXT               = 1000148000,
        SRC_EXT                = 1000148001,
        DST_EXT                = 1000148002,
        SRC_OVER_EXT           = 1000148003,
        DST_OVER_EXT           = 1000148004,
        SRC_IN_EXT             = 1000148005,
        DST_IN_EXT             = 1000148006,
        SRC_OUT_EXT            = 1000148007,
        DST_OUT_EXT            = 1000148008,
        SRC_ATOP_EXT           = 1000148009,
        DST_ATOP_EXT           = 1000148010,
        XOR_EXT                = 1000148011,
        MULTIPLY_EXT           = 1000148012,
        SCREEN_EXT             = 1000148013,
        OVERLAY_EXT            = 1000148014,
        DARKEN_EXT             = 1000148015,
        LIGHTEN_EXT            = 1000148016,
        COLORDODGE_EXT         = 1000148017,
        COLORBURN_EXT          = 1000148018,
        HARDLIGHT_EXT          = 1000148019,
        SOFTLIGHT_EXT          = 1000148020,
        DIFFERENCE_EXT         = 1000148021,
        EXCLUSION_EXT          = 1000148022,
        INVERT_EXT             = 1000148023,
        INVERT_RGB_EXT         = 1000148024,
        LINEARDODGE_EXT        = 1000148025,
        LINEARBURN_EXT         = 1000148026,
        VIVIDLIGHT_EXT         = 1000148027,
        LINEARLIGHT_EXT        = 1000148028,
        PINLIGHT_EXT           = 1000148029,
        HARDMIX_EXT            = 1000148030,
        HSL_HUE_EXT            = 1000148031,
        HSL_SATURATION_EXT     = 1000148032,
        HSL_COLOR_EXT          = 1000148033,
        HSL_LUMINOSITY_EXT     = 1000148034,
        PLUS_EXT               = 1000148035,
        PLUS_CLAMPED_EXT       = 1000148036,
        PLUS_CLAMPED_ALPHA_EXT = 1000148037,
        PLUS_DARKER_EXT        = 1000148038,
        MINUS_EXT              = 1000148039,
        MINUS_CLAMPED_EXT      = 1000148040,
        CONTRAST_EXT           = 1000148041,
        INVERT_OVG_EXT         = 1000148042,
        RED_EXT                = 1000148043,
        GREEN_EXT              = 1000148044,
        BLUE_EXT               = 1000148045,
        MAX_ENUM               = 0x7FFFFFFF
    }
}