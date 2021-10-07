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
namespace Exomia.Vulkan.Api.Core.Extensions.GOOGLE
{
    [VkExtGenerator]
    public static unsafe partial class VKGoogleDisplayTiming
    {
        public const int    VK_GOOGLE_DISPLAY_TIMING                = 1;
        public const int    VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION   = 1;
        public const string VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME = "VK_GOOGLE_display_timing";
        
        public static readonly delegate*<
            VkDevice, /* device */
            VkSwapchainKHR, /* swapchain */
            uint*, /* pPresentationTimingCount */
            VkPastPresentationTimingGOOGLE*, /* pPresentationTimings */
            VkResult> vkGetPastPresentationTimingGOOGLE = null;

        public static readonly delegate*<
            VkDevice, /* device */
            VkSwapchainKHR, /* swapchain */
            VkRefreshCycleDurationGOOGLE*, /* pDisplayTimingProperties */
            VkResult> vkGetRefreshCycleDurationGOOGLE = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPastPresentationTimingGOOGLE
    {
        public uint  presentID;
        public ulong desiredPresentTime;
        public ulong actualPresentTime;
        public ulong earliestPresentTime;
        public ulong presentMargin;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPresentTimeGOOGLE
    {
        public uint  presentID;
        public ulong desiredPresentTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkRefreshCycleDurationGOOGLE
    {
        public ulong refreshDuration;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPresentTimesInfoGOOGLE
    {
        public const VkStructureType      STYPE = VkStructureType.PRESENT_TIMES_INFO_GOOGLE;
        public       VkStructureType      sType;
        public       void*                pNext;
        public       uint                 swapchainCount;
        public       VkPresentTimeGOOGLE* pTimes;
    }
}