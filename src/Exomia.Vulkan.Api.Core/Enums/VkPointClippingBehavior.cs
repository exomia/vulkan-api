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

public enum VkPointClippingBehavior
{
    ALL_CLIP_PLANES           = 0,
    USER_CLIP_PLANES_ONLY     = 1,
    ALL_CLIP_PLANES_KHR       = ALL_CLIP_PLANES,
    USER_CLIP_PLANES_ONLY_KHR = USER_CLIP_PLANES_ONLY,
    MAX_ENUM                  = 0x7FFFFFFF
}