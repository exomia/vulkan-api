#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDisplaySurfaceCounter
    {
        public const int    VK_EXT_DISPLAY_SURFACE_COUNTER                = 1;
        public const int    VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION   = 1;
        public const string VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME = "VK_EXT_display_surface_counter";

        public static delegate*<
            VkPhysicalDevice,           /* physicalDevice */
            VkSurfaceKHR,               /* surface */
            VkSurfaceCapabilities2EXT*, /* pSurfaceCapabilities */
            VkResult> vkGetPhysicalDeviceSurfaceCapabilities2EXT;

        public static partial void Load(VkInstance vkInstance);
    }

    [Flags]
    public enum VkSurfaceCounterFlagsEXT
    {
        VBLANK_BIT_EXT         = 0x00000001,
        VBLANK_EXT             = VBLANK_BIT_EXT,
        FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
    }

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