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
using System.Security;
using Exomia.Vulkan.Api.Core;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Windows;

using HANDLE = IntPtr;

public static partial class VkWin32
{
    private const string IMPORT = "vulkan-1";

    [SuppressUnmanagedCodeSecurity]
    [DllImport(IMPORT, EntryPoint = "vkCreateWin32SurfaceKHR")]
    public static extern unsafe VkResult CreateWin32SurfaceKHR(
        VkInstance                   instance,
        VkWin32SurfaceCreateInfoKHR* pCreateInfo,
        VkAllocationCallbacks*       pAllocator,
        VkSurfaceKHR*                pSurface);

    [SuppressUnmanagedCodeSecurity]
    [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceWin32PresentationSupportKHR")]
    public static extern VkBool32 GetPhysicalDeviceWin32PresentationSupportKHR(
        VkPhysicalDevice physicalDevice,
        uint             queueFamilyIndex);

    [SuppressUnmanagedCodeSecurity]
    [DllImport(IMPORT, EntryPoint = "vkGetMemoryWin32HandleKHR")]
    public static extern unsafe VkResult GetMemoryWin32HandleKHR(
        VkDevice                       device,
        VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        HANDLE*                        pHandle);

    [SuppressUnmanagedCodeSecurity]
    [DllImport(IMPORT, EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR")]
    public static extern unsafe VkResult GetMemoryWin32HandlePropertiesKHR(
        VkDevice                           device,
        VkExternalMemoryHandleTypeFlagBits handleType,
        HANDLE                             handle,
        VkMemoryWin32HandlePropertiesKHR*  pMemoryWin32HandleProperties);

    [SuppressUnmanagedCodeSecurity]
    [DllImport(IMPORT, EntryPoint = "vkImportSemaphoreWin32HandleKHR")]
    public static extern unsafe VkResult ImportSemaphoreWin32HandleKHR(
        VkDevice                             device,
        VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);

    [SuppressUnmanagedCodeSecurity]
    [DllImport(IMPORT, EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
    public static extern unsafe VkResult GetSemaphoreWin32HandleKHR(
        VkDevice                          device,
        VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        HANDLE*                           pHandle);

    [SuppressUnmanagedCodeSecurity]
    [DllImport(IMPORT, EntryPoint = "vkImportFenceWin32HandleKHR")]
    public static extern unsafe VkResult ImportFenceWin32HandleKHR(
        VkDevice                         device,
        VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);

    [SuppressUnmanagedCodeSecurity]
    [DllImport(IMPORT, EntryPoint = "vkGetFenceWin32HandleKHR")]
    public static extern unsafe VkResult GetFenceWin32HandleKHR(
        VkDevice                      device,
        VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        HANDLE*                       pHandle);
}