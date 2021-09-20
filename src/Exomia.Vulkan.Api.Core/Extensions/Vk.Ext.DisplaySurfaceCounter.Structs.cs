#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSurfaceCapabilities2EXT
    {
        public const VkStructureType            STYPE = VkStructureType.SURFACE_CAPABILITIES_2_EXT;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       uint                       minImageCount;
        public       uint                       maxImageCount;
        public       VkExtent2D                 currentExtent;
        public       VkExtent2D                 minImageExtent;
        public       VkExtent2D                 maxImageExtent;
        public       uint                       maxImageArrayLayers;
        public       VkSurfaceTransformFlagsKHR supportedTransforms;
        public       VkSurfaceTransformFlagsKHR currentTransform;
        public       VkCompositeAlphaFlagsKHR   supportedCompositeAlpha;
        public       VkImageUsageFlagBits       supportedUsageFlags;
        public       VkSurfaceCounterFlagsEXT   supportedSurfaceCounters;
    }
}