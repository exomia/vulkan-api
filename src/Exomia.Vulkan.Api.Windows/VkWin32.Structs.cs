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
using Exomia.Vulkan.Api.Windows.Native;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Windows
{
    using HANDLE = IntPtr;

    public unsafe struct VkWin32SurfaceCreateInfoKHR
    {
        public const VkStructureType              STYPE = VkStructureType.WIN32_SURFACE_CREATE_INFO_KHR;
        public       VkStructureType              sType;
        public       void*                        pNext;
        public       VkWin32SurfaceCreateFlagsKHR flags;
        public       IntPtr                       hInstance;
        public       IntPtr                       hWnd;
    }

    public unsafe struct VkImportMemoryWin32HandleInfoKHR
    {
        public const VkStructureType                    STYPE = VkStructureType.IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType                    sType;
        public       void*                              pNext;
        public       VkExternalMemoryHandleTypeFlagBits handleType;
        public       HANDLE                             handle;
        public       char*                              pName;
    }

    public unsafe struct VkExportMemoryWin32HandleInfoKHR
    {
        public const VkStructureType      STYPE = VkStructureType.EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType      sType;
        public       void*                pNext;
        public       SECURITY_ATTRIBUTES* pAttributes;
        public       uint                 dwAccess;
        public       char*                pName;
    }

    public unsafe struct VkMemoryWin32HandlePropertiesKHR
    {
        public const VkStructureType STYPE = VkStructureType.MEMORY_WIN32_HANDLE_PROPERTIES_KHR;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            memoryTypeBits;
    }

    public unsafe struct VkMemoryGetWin32HandleInfoKHR
    {
        public const VkStructureType                    STYPE = VkStructureType.MEMORY_GET_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType                    sType;
        public       void*                              pNext;
        public       VkDeviceMemory                     memory;
        public       VkExternalMemoryHandleTypeFlagBits handleType;
    }

    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
    {
        public const VkStructureType STYPE = VkStructureType.WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            acquireCount;
        public       VkDeviceMemory* pAcquireSyncs;
        public       ulong*          pAcquireKeys;
        public       uint*           pAcquireTimeouts;
        public       uint            releaseCount;
        public       VkDeviceMemory* pReleaseSyncs;
        public       ulong*          pReleaseKeys;
    }

    public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
    {
        public const VkStructureType                       STYPE = VkStructureType.IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType                       sType;
        public       void*                                 pNext;
        public       VkSemaphore                           semaphore;
        public       VkSemaphoreImportFlagBits             flags;
        public       VkExternalSemaphoreHandleTypeFlagBits handleType;
        public       HANDLE                                handle;
        public       char*                                 pName;
    }

    public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
    {
        public const VkStructureType      STYPE = VkStructureType.EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType      sType;
        public       void*                pNext;
        public       SECURITY_ATTRIBUTES* pAttributes;
        public       uint                 dwAccess;
        public       char*                pName;
    }

    public unsafe struct VkD3D12FenceSubmitInfoKHR
    {
        public const VkStructureType STYPE = VkStructureType.D3D12_FENCE_SUBMIT_INFO_KHR;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            waitSemaphoreValuesCount;
        public       ulong*          pWaitSemaphoreValues;
        public       uint            signalSemaphoreValuesCount;
        public       ulong*          pSignalSemaphoreValues;
    }

    public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
    {
        public const VkStructureType                       STYPE = VkStructureType.SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType                       sType;
        public       void*                                 pNext;
        public       VkSemaphore                           semaphore;
        public       VkExternalSemaphoreHandleTypeFlagBits handleType;
    }

    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
    {
        public const VkStructureType STYPE = VkStructureType.WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            acquireCount;
        public       VkDeviceMemory* pAcquireSyncs;
        public       ulong*          pAcquireKeys;
        public       uint*           pAcquireTimeoutMilliseconds;
        public       uint            releaseCount;
        public       VkDeviceMemory* pReleaseSyncs;
        public       ulong*          pReleaseKeys;
    }

    public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
    {
        public const VkStructureType          STYPE = VkStructureType.SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT;
        public       VkStructureType          sType;
        public       void*                    pNext;
        public       VkFullScreenExclusiveEXT fullScreenExclusive;
    }

    public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public const VkStructureType STYPE = VkStructureType.SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        fullScreenExclusiveSupported;
    }

    public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       IntPtr          hMonitor;
    }

    public unsafe struct VkImportFenceWin32HandleInfoKHR
    {
        public const VkStructureType                   STYPE = VkStructureType.IMPORT_FENCE_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       VkFence                           fence;
        public       VkFenceImportFlagBits             flags;
        public       VkExternalFenceHandleTypeFlagBits handleType;
        public       HANDLE                            handle;
        public       char*                             pName;
    }

    public unsafe struct VkExportFenceWin32HandleInfoKHR
    {
        public const VkStructureType      STYPE = VkStructureType.EXPORT_FENCE_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType      sType;
        public       void*                pNext;
        public       SECURITY_ATTRIBUTES* pAttributes;
        public       uint                 dwAccess;
        public       char*                pName;
    }

    public unsafe struct VkFenceGetWin32HandleInfoKHR
    {
        public const VkStructureType                   STYPE = VkStructureType.FENCE_GET_WIN32_HANDLE_INFO_KHR;
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       VkFence                           fence;
        public       VkExternalFenceHandleTypeFlagBits handleType;
    }

    public unsafe struct VkImportMemoryWin32HandleInfoNV
    {
        public const VkStructureType                   STYPE = VkStructureType.IMPORT_MEMORY_WIN32_HANDLE_INFO_NV;
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       VkExternalMemoryHandleTypeFlagsNV handleType;
        public       HANDLE                            handle;
    }

    public unsafe struct VkExportMemoryWin32HandleInfoNV
    {
        public const VkStructureType      STYPE = VkStructureType.EXPORT_MEMORY_WIN32_HANDLE_INFO_NV;
        public       VkStructureType      sType;
        public       void*                pNext;
        public       SECURITY_ATTRIBUTES* pAttributes;
        public       uint                 dwAccess;
    }
}