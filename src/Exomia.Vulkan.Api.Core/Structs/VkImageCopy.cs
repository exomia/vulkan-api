﻿#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageCopy
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D               srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D               dstOffset;
        public VkExtent3D               extent;
    }
}