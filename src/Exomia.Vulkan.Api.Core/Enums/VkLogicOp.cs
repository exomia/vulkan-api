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

public enum VkLogicOp
{
    CLEAR         = 0,
    AND           = 1,
    AND_REVERSE   = 2,
    COPY          = 3,
    AND_INVERTED  = 4,
    NO_OP         = 5,
    XOR           = 6,
    OR            = 7,
    NOR           = 8,
    EQUIVALENT    = 9,
    INVERT        = 10,
    OR_REVERSE    = 11,
    COPY_INVERTED = 12,
    OR_INVERTED   = 13,
    NAND          = 14,
    SET           = 15,
    MAX_ENUM      = 0x7FFFFFFF
}