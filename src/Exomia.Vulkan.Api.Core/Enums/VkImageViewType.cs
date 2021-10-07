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
    public enum VkImageViewType
    {
        _1D        = 0,
        _2D        = 1,
        _3D        = 2,
        CUBE       = 3,
        _1D_ARRAY  = 4,
        _2D_ARRAY  = 5,
        CUBE_ARRAY = 6,
        MAX_ENUM   = 0x7FFFFFFF
    }
}