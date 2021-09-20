#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace Exomia.Vulkan.Api.Core.Extensions
{

    public readonly unsafe struct VkDisplayPowerControlEXT
    {
        public static readonly VkDisplayPowerControlEXT Null = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayPowerInfoEXT*, /* pDisplayPowerInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkDisplayPowerControlEXT(void* ptr)
        {
            VkDisplayPowerControlEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkRegisterDeviceEventEXT
    {
        public static readonly VkRegisterDeviceEventEXT Null = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDeviceEventInfoEXT*,  /* pDeviceEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> UnsafeInvoke;

        public static implicit operator VkRegisterDeviceEventEXT(void* ptr)
        {
            VkRegisterDeviceEventEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkRegisterDisplayEventEXT
    {
        public static readonly VkRegisterDisplayEventEXT Null = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayEventInfoEXT*, /* pDisplayEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> UnsafeInvoke;

        public static implicit operator VkRegisterDisplayEventEXT(void* ptr)
        {
            VkRegisterDisplayEventEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetSwapchainCounterEXT
    {
        public static readonly VkGetSwapchainCounterEXT Null = null;

        public readonly delegate*<
            VkDevice,                 /* device */
            VkSwapchainKHR,           /* swapchain */
            VkSurfaceCounterFlagsEXT, /* counter */
            ulong*,                   /* pCounterValue */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetSwapchainCounterEXT(void* ptr)
        {
            VkGetSwapchainCounterEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }
}
