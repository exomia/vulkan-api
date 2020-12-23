using System;

namespace Exomia.Vulkan.Api.Windows
{
    using HANDLE = IntPtr;

    public unsafe delegate VkResult PFN_vkCreateWin32SurfaceKHR(
        VkInstance instance,
        VkWin32SurfaceCreateInfoKHR* pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkSurfaceKHR* pSurface);

    public unsafe delegate bool PFN_vkGetPhysicalDeviceWin32PresentationSupportKHR(
        VkPhysicalDevice physicalDevice,
        uint queueFamilyIndex);

    public unsafe delegate VkResult PFN_vkGetMemoryWin32HandleKHR(
        VkDevice device,
        VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        IntPtr* pHandle);

    public unsafe delegate VkResult PFN_vkGetMemoryWin32HandlePropertiesKHR(
        VkDevice device,
        VkExternalMemoryHandleTypeFlags handleType,
        IntPtr handle,
        VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);

    public unsafe delegate VkResult GetPhysicalDeviceSurfacePresentModes2EXT(
        VkPhysicalDevice physicalDevice,
        VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
        uint* pPresentModeCount,
        VkPresentModeKHR* pPresentModes);

    public unsafe delegate VkResult AcquireFullScreenExclusiveModeEXT(
        VkDevice device,
        VkSwapchainKHR swapchain);
    
    public unsafe delegate VkResult ReleaseFullScreenExclusiveModeEXT(
        VkDevice device,
        VkSwapchainKHR swapchain);
    
    public unsafe delegate VkResult GetDeviceGroupSurfacePresentModes2EXT(
        VkDevice device,
        VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
        VkDeviceGroupPresentModeFlagsKHR* pModes);
    
    public unsafe delegate VkResult ImportSemaphoreWin32HandleKHR(
        VkDevice device,
        VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
    
    public unsafe delegate VkResult GetSemaphoreWin32HandleKHR(
        VkDevice device,
        VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        HANDLE* pHandle);
    
    public unsafe delegate VkResult ImportFenceWin32HandleKHR(
        VkDevice device,
        VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);
    
    public unsafe delegate VkResult GetFenceWin32HandleKHR(
        VkDevice device,
        VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo,
        HANDLE* pHandle);
    
    public unsafe delegate VkResult GetMemoryWin32HandleNV(
        VkDevice device,
        VkDeviceMemory memory,
        VkExternalMemoryHandleTypeFlagsNV handleType,
        HANDLE* pHandle);
}
