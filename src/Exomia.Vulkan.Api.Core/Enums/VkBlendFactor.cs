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

public enum VkBlendFactor
{
    ZERO                     = 0,
    ONE                      = 1,
    SRC_COLOR                = 2,
    ONE_MINUS_SRC_COLOR      = 3,
    DST_COLOR                = 4,
    ONE_MINUS_DST_COLOR      = 5,
    SRC_ALPHA                = 6,
    ONE_MINUS_SRC_ALPHA      = 7,
    DST_ALPHA                = 8,
    ONE_MINUS_DST_ALPHA      = 9,
    CONSTANT_COLOR           = 10,
    ONE_MINUS_CONSTANT_COLOR = 11,
    CONSTANT_ALPHA           = 12,
    ONE_MINUS_CONSTANT_ALPHA = 13,
    SRC_ALPHA_SATURATE       = 14,
    SRC1_COLOR               = 15,
    ONE_MINUS_SRC1_COLOR     = 16,
    SRC1_ALPHA               = 17,
    ONE_MINUS_SRC1_ALPHA     = 18,
    MAX_ENUM                 = 0x7FFFFFFF
}