#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [Flags]
    public enum VkStencilFaceFlagBits
    {
        VK_STENCIL_FACE_FRONT_BIT          = 0x00000001,
        VK_STENCIL_FACE_BACK_BIT           = 0x00000002,
        VK_STENCIL_FACE_FRONT_AND_BACK     = 0x00000003,
        VK_STENCIL_FRONT_AND_BACK          = VK_STENCIL_FACE_FRONT_AND_BACK,
        VK_STENCIL_FACE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }
}