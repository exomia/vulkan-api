#region License

// Copyright (c) 2018-2020, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Windows
{
    public enum VkFullScreenExclusiveEXT
    {
        DEFAULT_EXT                = 0,
        ALLOWED_EXT                = 1,
        DISALLOWED_EXT             = 2,
        APPLICATION_CONTROLLED_EXT = 3,
        MAX_ENUM_EXT               = 0x7FFFFFFF
    }
}