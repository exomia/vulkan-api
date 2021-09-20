#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayPowerInfoEXT
    {
        public const VkStructureType        STYPE = VkStructureType.DISPLAY_POWER_INFO_EXT;
        public       VkStructureType        sType;
        public       void*                  pNext;
        public       VkDisplayPowerStateEXT powerState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceEventInfoEXT
    {
        public const VkStructureType      STYPE = VkStructureType.DEVICE_EVENT_INFO_EXT;
        public       VkStructureType      sType;
        public       void*                pNext;
        public       VkDeviceEventTypeEXT deviceEvent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayEventInfoEXT
    {
        public const VkStructureType       STYPE = VkStructureType.DISPLAY_EVENT_INFO_EXT;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkDisplayEventTypeEXT displayEvent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSwapchainCounterCreateInfoEXT
    {
        public const VkStructureType          STYPE = VkStructureType.SWAPCHAIN_COUNTER_CREATE_INFO_EXT;
        public       VkStructureType          sType;
        public       void*                    pNext;
        public       VkSurfaceCounterFlagsEXT surfaceCounters;
    }
}
