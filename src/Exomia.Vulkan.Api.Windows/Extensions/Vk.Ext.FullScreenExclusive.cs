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
using Exomia.Vulkan.Api.Core;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Windows.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtFullScreenExclusive
    {
        public const int VK_EXT_FULL_SCREEN_EXCLUSIVE = 1;
        public const int VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION = 4;
        public const string VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME = "VK_EXT_full_screen_exclusive";

        public static readonly delegate*<
            VkPhysicalDevice,                 /* physicalDevice */
            VkPhysicalDeviceSurfaceInfo2KHR*, /* pSurfaceInfo */
            uint*,                            /* pPresentModeCount */
            VkPresentModeKHR*,                /* pPresentModes */
            VkResult> vkGetPhysicalDeviceSurfacePresentModes2EXT = null;

        public static readonly delegate*<
            VkDevice,          /* device */
            VkSwapchainKHR,   /* swapchain */
            VkResult> vkAcquireFullScreenExclusiveModeEXT = null;


        public static readonly delegate*<
            VkDevice,       /* device */
            VkSwapchainKHR, /* swapchain */
            VkResult> vkReleaseFullScreenExclusiveModeEXT = null;


        public static readonly delegate*<
            VkDevice,                          /* device */
            VkPhysicalDeviceSurfaceInfo2KHR*,  /* pSurfaceInfo */
            VkDeviceGroupPresentModeFlagsKHR*, /* pModes */
            VkResult> vkGetDeviceGroupSurfacePresentModes2EXT = null;

        public static partial void Load(VkDevice vkDevice);
    }

    public enum VkFullScreenExclusiveEXT
    {
        DEFAULT_EXT = 0,
        ALLOWED_EXT = 1,
        DISALLOWED_EXT = 2,
        APPLICATION_CONTROLLED_EXT = 3,
        MAX_ENUM_EXT = 0x7FFFFFFF
    }

    public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public VkFullScreenExclusiveEXT fullScreenExclusive;
    }

    public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public const VkStructureType STYPE = VkStructureType.SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT;
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fullScreenExclusiveSupported;
    }

    public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public IntPtr hMonitor;
    }
}
