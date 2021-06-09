#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using Exomia.Vulkan.Api.Core;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Windows
{
    using HANDLE = IntPtr;

    public unsafe delegate VkResult PFN_vkCreateWin32SurfaceKHR(
        VkInstance                   instance,
        VkWin32SurfaceCreateInfoKHR* pCreateInfo,
        VkAllocationCallbacks*       pAllocator,
        VkSurfaceKHR*                pSurface);

    public delegate VkBool32 PFN_vkGetPhysicalDeviceWin32PresentationSupportKHR(
        VkPhysicalDevice physicalDevice,
        uint             queueFamilyIndex);

    public unsafe delegate VkResult PFN_vkGetMemoryWin32HandleKHR(
        VkDevice                       device,
        VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        HANDLE*                        pHandle);

    public unsafe delegate VkResult PFN_vkGetMemoryWin32HandlePropertiesKHR(
        VkDevice                           device,
        VkExternalMemoryHandleTypeFlagBits handleType,
        HANDLE                             handle,
        VkMemoryWin32HandlePropertiesKHR*  pMemoryWin32HandleProperties);

    public unsafe delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXT(
        VkPhysicalDevice                 physicalDevice,
        VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
        uint*                            pPresentModeCount,
        VkPresentModeKHR*                pPresentModes);

    public delegate VkResult AcquireFullScreenExclusiveModeEXT(
        VkDevice       device,
        VkSwapchainKHR swapchain);

    public delegate VkResult ReleaseFullScreenExclusiveModeEXT(
        VkDevice       device,
        VkSwapchainKHR swapchain);

    public unsafe delegate VkResult GetDeviceGroupSurfacePresentModes2EXT(
        VkDevice                          device,
        VkPhysicalDeviceSurfaceInfo2KHR*  pSurfaceInfo,
        VkDeviceGroupPresentModeFlagsKHR* pModes);

    public unsafe delegate VkResult ImportSemaphoreWin32HandleKHR(
        VkDevice                             device,
        VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);

    public unsafe delegate VkResult GetSemaphoreWin32HandleKHR(
        VkDevice                          device,
        VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        HANDLE*                           pHandle);

    public unsafe delegate VkResult ImportFenceWin32HandleKHR(
        VkDevice                         device,
        VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);

    public unsafe delegate VkResult GetFenceWin32HandleKHR(
        VkDevice                      device,
        VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        HANDLE*                       pHandle);

    public unsafe delegate VkResult GetMemoryWin32HandleNV(
        VkDevice                          device,
        VkDeviceMemory                    memory,
        VkExternalMemoryHandleTypeFlagsNV handleType,
        HANDLE*                           pHandle);
}