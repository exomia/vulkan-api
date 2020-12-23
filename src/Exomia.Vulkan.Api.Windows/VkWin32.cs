using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Exomia.Vulkan.Api.Windows
{
    using HANDLE = IntPtr;
    public static partial class VkWin32
    {
        private const string IMPORT = "vulkan-1";

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateWin32SurfaceKHR")]
        public unsafe static extern VkResult CreateWin32SurfaceKHR(
            VkInstance instance,
            VkWin32SurfaceCreateInfoKHR* pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkSurfaceKHR* pSurface);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceWin32PresentationSupportKHR")]
        public unsafe static extern bool GetPhysicalDeviceWin32PresentationSupportKHR(
            VkPhysicalDevice physicalDevice,
            uint queueFamilyIndex);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetMemoryWin32HandleKHR")]
        public unsafe static extern VkResult GetMemoryWin32HandleKHR(
            VkDevice device,
            VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo,
            HANDLE* pHandle);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR")]
        public unsafe static extern VkResult GetMemoryWin32HandlePropertiesKHR(
            VkDevice device,
            VkExternalMemoryHandleTypeFlags handleType,
            HANDLE handle,
            VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT")]
        public unsafe static extern VkResult GetPhysicalDeviceSurfacePresentModes2EXT(
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            uint* pPresentModeCount,
            VkPresentModeKHR* pPresentModes);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkAcquireFullScreenExclusiveModeEXT")]
        public static extern unsafe VkResult AcquireFullScreenExclusiveModeEXT(
            VkDevice device,
            VkSwapchainKHR swapchain);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkReleaseFullScreenExclusiveModeEXT")]
        public unsafe static extern VkResult ReleaseFullScreenExclusiveModeEXT(
            VkDevice device,
            VkSwapchainKHR swapchain);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT")]
        public unsafe static extern VkResult GetDeviceGroupSurfacePresentModes2EXT(
            VkDevice device,
            VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            VkDeviceGroupPresentModeFlagsKHR* pModes);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkImportSemaphoreWin32HandleKHR")]
        public unsafe static extern VkResult ImportSemaphoreWin32HandleKHR(
            VkDevice device,
            VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
        public unsafe static extern VkResult GetSemaphoreWin32HandleKHR(
            VkDevice device,
            VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo,
            HANDLE* pHandle);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkImportFenceWin32HandleKHR")]
        public unsafe static extern VkResult ImportFenceWin32HandleKHR(
            VkDevice device,
            VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetFenceWin32HandleKHR")]
        public unsafe static extern VkResult GetFenceWin32HandleKHR(
            VkDevice device,
            VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        HANDLE* pHandle);


        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetMemoryWin32HandleNV")]
        public unsafe static extern VkResult GetMemoryWin32HandleNV(
            VkDevice device,
            VkDeviceMemory memory,
            VkExternalMemoryHandleTypeFlagsNV handleType,
            HANDLE* pHandle);
    }
}
