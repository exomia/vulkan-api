#region License

// Copyright (c) 2018-2020, exomia
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
        public VkStructureType sType;
        public void*           pNext;
        public uint            flags;
        public IntPtr          hInstance;
        public IntPtr          hWnd;
    }

    public unsafe struct VkImportMemoryWin32HandleInfoKHR
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public IntPtr                          handle;
        public byte*                           pName;
    }

    public unsafe struct VkExportMemoryWin32HandleInfoKHR
    {
        public VkStructureType      sType;
        public void*                pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint                 dwAccess;
        public byte*                pName;
    }

    public unsafe struct VkMemoryWin32HandlePropertiesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            memoryTypeBits;
    }

    public unsafe struct VkMemoryGetWin32HandleInfoKHR
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkDeviceMemory                  memory;
        public VkExternalMemoryHandleTypeFlags handleType;
    }

    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong*          pAcquireKeys;
        public uint*           pAcquireTimeouts;
        public uint            releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong*          pReleaseKeys;
    }

    public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkSemaphore                        semaphore;
        public VkSemaphoreImportFlags             flags;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public HANDLE                             handle;
        public byte*                              pName;
    }

    public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType      sType;
        public void*                pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint                 dwAccess;
        public byte*                pName;
    }

    public unsafe struct VkD3D12FenceSubmitInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            waitSemaphoreValuesCount;
        public ulong*          pWaitSemaphoreValues;
        public uint            signalSemaphoreValuesCount;
        public ulong*          pSignalSemaphoreValues;
    }

    public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkSemaphore                        semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
    }

    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong*          pAcquireKeys;
        public uint*           pAcquireTimeoutMilliseconds;
        public uint            releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong*          pReleaseKeys;
    }

    public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkFullScreenExclusiveEXT fullScreenExclusive;
    }

    public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public bool            fullScreenExclusiveSupported;
    }

    public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public IntPtr          hMonitor;
    }

    public unsafe struct VkImportFenceWin32HandleInfoKHR
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkFence                        fence;
        public VkFenceImportFlags             flags;
        public VkExternalFenceHandleTypeFlags handleType;
        public HANDLE                         handle;
        public byte*                          pName;
    }

    public unsafe struct VkExportFenceWin32HandleInfoKHR
    {
        public VkStructureType      sType;
        public void*                pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint                 dwAccess;
        public byte*                pName;
    }

    public unsafe struct VkFenceGetWin32HandleInfoKHR
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkFence                        fence;
        public VkExternalFenceHandleTypeFlags handleType;
    }

    public unsafe struct VkImportMemoryWin32HandleInfoNV
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleType;
        public HANDLE                            handle;
    }

    public unsafe struct VkExportMemoryWin32HandleInfoNV
    {
        public VkStructureType      sType;
        public void*                pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint                 dwAccess;
    }
}