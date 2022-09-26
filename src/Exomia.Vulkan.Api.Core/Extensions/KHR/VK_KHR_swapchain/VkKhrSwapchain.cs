#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrSwapchain;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_swapchain - device extension (nr. 2) - author 'KHR' [platform '' | contact 'James Jones @cubanismo,Ian Elliott @ianelliottus']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_swapchain.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_swapchain.html </a>
/// </summary>
[VkRequires("VK_KHR_surface")]
public static unsafe class VkKhrSwapchain
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SWAPCHAIN_SPEC_VERSION = 70;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SWAPCHAIN_EXTENSION_NAME = "VK_KHR_swapchain";

    /// <summary> An UTF8 null terminated version of <see cref="VK_KHR_SWAPCHAIN_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SWAPCHAIN_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SWAPCHAIN_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u535f\u4157\u4350\u4148\u4e49\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCreateSwapchainKHR - Create a swapchain -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSwapchainKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSwapchainKHR.html </a>
    /// </summary>
    /// <param name="device"> device is the device to create the swapchain for. </param>
    /// <param name="pCreateInfo"> pCreateInfo is a pointer to a VkSwapchainCreateInfoKHRstructure specifying the parameters of the created swapchain. </param>
    /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the swapchain object when there is no more specific allocator available (see Memory Allocation). </param>
    /// <param name="pSwapchain"> pSwapchain is a pointer to a VkSwapchainKHR handle in which the created swapchain object will be returned. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_SURFACE_LOST_KHR,VK_ERROR_NATIVE_WINDOW_IN_USE_KHR,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_COMPRESSION_EXHAUSTED_EXT </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainCreateInfoKHR* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkSwapchainKHR* /*pSwapchain*/,
        VkResult> vkCreateSwapchainKHR = null;

    /// <summary>
    ///     vkDestroySwapchainKHR - Destroy a swapchain object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySwapchainKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySwapchainKHR.html </a>
    /// </summary>
    /// <param name="device"> device is the VkDevice associated with swapchain. </param>
    /// <param name="swapchain"> swapchain is the swapchain to destroy. </param>
    /// <param name="pAllocator"> pAllocator is the allocator used for host memory allocated for the swapchain object when there is no more specific allocator available (see Memory Allocation). </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroySwapchainKHR = null;

    /// <summary>
    ///     vkGetSwapchainImagesKHR - Obtain the array of presentable images associated with a swapchain -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainImagesKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainImagesKHR.html </a>
    /// </summary>
    /// <param name="device"> device is the device associated with swapchain. </param>
    /// <param name="swapchain"> swapchain is the swapchain to query. </param>
    /// <param name="pSwapchainImageCount"> pSwapchainImageCount is a pointer to an integer related to the number of presentable images available or queried, as described below. </param>
    /// <param name="pSwapchainImages"> pSwapchainImages is either NULL or a pointer to an array of VkImage handles. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS,VK_INCOMPLETE </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        uint* /*pSwapchainImageCount*/,
        VkImage* /*pSwapchainImages*/,
        VkResult> vkGetSwapchainImagesKHR = null;

    /// <summary>
    ///     vkAcquireNextImageKHR - Retrieve the index of the next available presentable image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImageKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImageKHR.html </a>
    /// </summary>
    /// <param name="device"> device is the device associated with swapchain. </param>
    /// <param name="swapchain"> swapchain is the non-retired swapchain from which an image is being acquired. </param>
    /// <param name="timeout"> timeout specifies how long the function waits, in nanoseconds, if no image is available. </param>
    /// <param name="semaphore"> semaphore is VK_NULL_HANDLE or a semaphore to signal. </param>
    /// <param name="fence"> fence is VK_NULL_HANDLE or a fence to signal. </param>
    /// <param name="pImageIndex"> pImageIndex is a pointer to a uint32_t in which the index of the next image to use (i.e. an index into the array of images returned by vkGetSwapchainImagesKHR) is returned. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term>
    ///             <description> VK_SUCCESS,VK_TIMEOUT,VK_NOT_READY,VK_SUBOPTIMAL_KHR </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_OUT_OF_DATE_KHR,VK_ERROR_SURFACE_LOST_KHR,VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        ulong /*timeout*/,
        VkSemaphore /*semaphore*/,
        VkFence /*fence*/,
        uint* /*pImageIndex*/,
        VkResult> vkAcquireNextImageKHR = null;

    /// <summary>
    ///     vkQueuePresentKHR - Queue an image for presentation -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueuePresentKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueuePresentKHR.html </a>
    /// </summary>
    /// <param name="queue"> queue is a queue that is capable of presentation to the target surface&#8217;s platform on the same device as the image&#8217;s swapchain. </param>
    /// <param name="pPresentInfo"> pPresentInfo is a pointer to a VkPresentInfoKHR structure specifying parameters of the presentation. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS,VK_SUBOPTIMAL_KHR </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_OUT_OF_DATE_KHR,VK_ERROR_SURFACE_LOST_KHR,VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkQueue /*queue*/,
        VkPresentInfoKHR* /*pPresentInfo*/,
        VkResult> vkQueuePresentKHR = null;

    /// <summary>
    ///     vkGetDeviceGroupPresentCapabilitiesKHR - Query present capabilities from other physical devices -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPresentCapabilitiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPresentCapabilitiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the logical device. </param>
    /// <param name="pDeviceGroupPresentCapabilities"> pDeviceGroupPresentCapabilities is a pointer to a VkDeviceGroupPresentCapabilitiesKHR structure in which the device&#8217;s capabilities are returned. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeviceGroupPresentCapabilitiesKHR* /*pDeviceGroupPresentCapabilities*/,
        VkResult> vkGetDeviceGroupPresentCapabilitiesKHR = null;

    /// <summary>
    ///     vkGetDeviceGroupSurfacePresentModesKHR - Query present capabilities for a surface -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the logical device. </param>
    /// <param name="surface"> surface is the surface. </param>
    /// <param name="pModes"> pModes is a pointer to a VkDeviceGroupPresentModeFlagsKHR in which the supported device group present modes for the surface are returned. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_SURFACE_LOST_KHR </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSurfaceKHR /*surface*/,
        VkDeviceGroupPresentModeFlagsKHR* /*pModes*/,
        VkResult> vkGetDeviceGroupSurfacePresentModesKHR = null;

    /// <summary>
    ///     vkGetPhysicalDevicePresentRectanglesKHR - Query present rectangles for a surface on a physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDevicePresentRectanglesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDevicePresentRectanglesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice"> physicalDevice is the physical device. </param>
    /// <param name="surface"> surface is the surface. </param>
    /// <param name="pRectCount"> pRectCount is a pointer to an integer related to the number of rectangles available or queried, as described below. </param>
    /// <param name="pRects"> pRects is either NULL or a pointer to an array of VkRect2Dstructures. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS,VK_INCOMPLETE </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkSurfaceKHR /*surface*/,
        uint* /*pRectCount*/,
        VkRect2D* /*pRects*/,
        VkResult> vkGetPhysicalDevicePresentRectanglesKHR = null;

    /// <summary>
    ///     vkAcquireNextImage2KHR - Retrieve the index of the next available presentable image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImage2KHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImage2KHR.html </a>
    /// </summary>
    /// <param name="device"> device is the device associated with swapchain. </param>
    /// <param name="pAcquireInfo"> pAcquireInfo is a pointer to a VkAcquireNextImageInfoKHRstructure containing parameters of the acquire. </param>
    /// <param name="pImageIndex"> pImageIndex is a pointer to a uint32_t that is set to the index of the next image to use. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term>
    ///             <description> VK_SUCCESS,VK_TIMEOUT,VK_NOT_READY,VK_SUBOPTIMAL_KHR </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_OUT_OF_DATE_KHR,VK_ERROR_SURFACE_LOST_KHR,VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAcquireNextImageInfoKHR* /*pAcquireInfo*/,
        uint* /*pImageIndex*/,
        VkResult> vkAcquireNextImage2KHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkCreateSwapchainKHR </description>
    ///         </item>
    ///         <item>
    ///             <description> vkDestroySwapchainKHR </description>
    ///         </item>
    ///         <item>
    ///             <description> vkGetSwapchainImagesKHR </description>
    ///         </item>
    ///         <item>
    ///             <description> vkAcquireNextImageKHR </description>
    ///         </item>
    ///         <item>
    ///             <description> vkQueuePresentKHR </description>
    ///         </item>
    ///         <item>
    ///             <description> vkGetDeviceGroupPresentCapabilitiesKHR </description>
    ///         </item>
    ///         <item>
    ///             <description> vkGetDeviceGroupSurfacePresentModesKHR </description>
    ///         </item>
    ///         <item>
    ///             <description> vkAcquireNextImage2KHR </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult>* pvkCreateSwapchainKHR = &vkCreateSwapchainKHR)
        {
            *pvkCreateSwapchainKHR = (delegate*<VkDevice, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u7753\u7061\u6863\u6961\u4b6e\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>* pvkDestroySwapchainKHR = &vkDestroySwapchainKHR)
        {
            *pvkDestroySwapchainKHR = (delegate*<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>)GetVkFunction(device, "\u6b76\u6544\u7473\u6f72\u5379\u6177\u6370\u6168\u6e69\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult>* pvkGetSwapchainImagesKHR = &vkGetSwapchainImagesKHR)
        {
            *pvkGetSwapchainImagesKHR =
                (delegate*<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult>)GetVkFunction(device, "\u6b76\u6547\u5374\u6177\u6370\u6168\u6e69\u6d49\u6761\u7365\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, uint*, VkResult>* pvkAcquireNextImageKHR = &vkAcquireNextImageKHR)
        {
            *pvkAcquireNextImageKHR = (delegate*<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, uint*, VkResult>)GetVkFunction(
                device, "\u6b76\u6341\u7571\u7269\u4e65\u7865\u4974\u616d\u6567\u484b\u0052");
        }

        fixed (delegate*<VkQueue, VkPresentInfoKHR*, VkResult>* pvkQueuePresentKHR = &vkQueuePresentKHR)
        {
            *pvkQueuePresentKHR = (delegate*<VkQueue, VkPresentInfoKHR*, VkResult>)GetVkFunction(device, "\u6b76\u7551\u7565\u5065\u6572\u6573\u746e\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult>* pvkGetDeviceGroupPresentCapabilitiesKHR = &vkGetDeviceGroupPresentCapabilitiesKHR)
        {
            *pvkGetDeviceGroupPresentCapabilitiesKHR = (delegate*<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4765\u6f72\u7075\u7250\u7365\u6e65\u4374\u7061\u6261\u6c69\u7469\u6569\u4b73\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult>* pvkGetDeviceGroupSurfacePresentModesKHR = &vkGetDeviceGroupSurfacePresentModesKHR)
        {
            *pvkGetDeviceGroupSurfacePresentModesKHR = (delegate*<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4765\u6f72\u7075\u7553\u6672\u6361\u5065\u6572\u6573\u746e\u6f4d\u6564\u4b73\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult>* pvkAcquireNextImage2KHR = &vkAcquireNextImage2KHR)
        {
            *pvkAcquireNextImage2KHR = (delegate*<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult>)GetVkFunction(
                device, "\u6b76\u6341\u7571\u7269\u4e65\u7865\u4974\u616d\u6567\u4b32\u5248\u0000");
        }
    }

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkGetPhysicalDevicePresentRectanglesKHR </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult>* pvkGetPhysicalDevicePresentRectanglesKHR = &vkGetPhysicalDevicePresentRectanglesKHR)
        {
            *pvkGetPhysicalDevicePresentRectanglesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5065\u6572\u6573\u746e\u6552\u7463\u6e61\u6c67\u7365\u484b\u0052");
        }
    }
}