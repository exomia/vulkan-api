#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSwapchainCreateInfoKHR
    {
        public const VkStructureType            STYPE = VkStructureType.SWAPCHAIN_CREATE_INFO_KHR;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkSwapchainCreateFlagsKHR  flags;
        public       VkSurfaceKHR               surface;
        public       uint                       minImageCount;
        public       VkFormat                   imageFormat;
        public       VkColorSpaceKHR            imageColorSpace;
        public       VkExtent2D                 imageExtent;
        public       uint                       imageArrayLayers;
        public       VkImageUsageFlagBits       imageUsage;
        public       VkSharingMode              imageSharingMode;
        public       uint                       queueFamilyIndexCount;
        public       uint*                      pQueueFamilyIndices;
        public       VkSurfaceTransformFlagsKHR preTransform;
        public       VkCompositeAlphaFlagsKHR   compositeAlpha;
        public       VkPresentModeKHR           presentMode;
        public       VkBool32                   clipped;
        public       VkSwapchainKHR             oldSwapchain;
    }
}