#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDisplayControl
    {
        public const int    VK_EXT_DISPLAY_CONTROL                = 1;
        public const int    VK_EXT_DISPLAY_CONTROL_SPEC_VERSION   = 1;
        public const string VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME = "VK_EXT_display_control";
        
        public static delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayPowerInfoEXT*, /* pDisplayPowerInfo */
            VkResult> vkDisplayPowerControlEXT;
        
        public static delegate*<
            VkDevice,               /* device */
            VkDeviceEventInfoEXT*,  /* pDeviceEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> vkRegisterDeviceEventEXT;

        public static delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayEventInfoEXT*, /* pDisplayEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> vkRegisterDisplayEventEXT;
        
        public static delegate*<
            VkDevice,                 /* device */
            VkSwapchainKHR,           /* swapchain */
            VkSurfaceCounterFlagsEXT, /* counter */
            ulong*,                   /* pCounterValue */
            VkResult> vkGetSwapchainCounterEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    public enum VkDisplayPowerStateEXT
    {
        OFF_EXT      = 0,
        SUSPEND_EXT  = 1,
        ON_EXT       = 2,
        MAX_ENUM_EXT = 0x7FFFFFFF
    }

    public enum VkDeviceEventTypeEXT
    {
        DISPLAY_HOTPLUG_EXT = 0,
        MAX_ENUM_EXT        = 0x7FFFFFFF
    }

    public enum VkDisplayEventTypeEXT
    {
        FIRST_PIXEL_OUT_EXT = 0,
        MAX_ENUM_EXT        = 0x7FFFFFFF
    }

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