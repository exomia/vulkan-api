using System;
using Exomia.Vulkan.Api.Windows.Native;

namespace Exomia.Vulkan.Api.Windows
{

    using HANDLE = IntPtr;
    public unsafe struct VkWin32SurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public IntPtr hinstance;
        public IntPtr hwnd;
    };

    public unsafe struct VkImportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public IntPtr handle;
        public char* name;
    }

    public unsafe struct VkExportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public char* name;
    }


    public unsafe struct VkMemoryWin32HandlePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
    }
    public unsafe struct VkMemoryGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
    }

    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeouts;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
    }

    public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlags flags;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public HANDLE handle;
        public char* name;
    }

    public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public char* name;
    }

    public unsafe struct VkD3D12FenceSubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreValuesCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValuesCount;
        public ulong* pSignalSemaphoreValues;
    }

    public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
    }
    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeoutMilliseconds;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
    }


    public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFullScreenExclusiveEXT fullScreenExclusive;
    }

    public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public bool fullScreenExclusiveSupported;
    }

    public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr hmonitor;
    }


    public unsafe struct VkImportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlags flags;
        public VkExternalFenceHandleTypeFlags handleType;
        public HANDLE handle;
        public char* name;
    }

    public unsafe struct VkExportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public char* name;
    }

    public unsafe struct VkFenceGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlags handleType;
    }

    public unsafe struct VkImportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleType;
        public HANDLE handle;
    }

    public unsafe struct VkExportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
    }


  
}
