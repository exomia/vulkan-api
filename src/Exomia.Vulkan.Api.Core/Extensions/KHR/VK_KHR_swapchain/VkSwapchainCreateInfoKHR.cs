#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkSwapchainCreateInfoKHR - Structure specifying parameters of a newly created swapchain object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainCreateInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkSwapchainCreateFlagBitsKHRindicating parameters of the swapchain creation.</summary>
    public VkSwapchainCreateFlagsKHR flags;

    /// <summary>
    ///     surface is the surface onto which the swapchain will present images. If the creation succeeds, the swapchain
    ///     becomes associated with surface.
    /// </summary>
    public VkSurfaceKHR surface;

    /// <summary>
    ///     minImageCount is the minimum number of presentable images that the application needs. The implementation will
    ///     either create the swapchain with at least that many images, or it will fail to create the swapchain.
    /// </summary>
    public uint minImageCount;

    /// <summary>imageFormat is a VkFormat value specifying the format the swapchain image(s) will be created with.</summary>
    public VkFormat imageFormat;

    /// <summary>imageColorSpace is a VkColorSpaceKHR value specifying the way the swapchain interprets image data.</summary>
    public VkColorSpaceKHR imageColorSpace;

    /// <summary>
    ///     imageExtent is the size (in pixels) of the swapchain image(s). The behavior is platform-dependent if the image
    ///     extent does not match the surface&#8217;s currentExtent as returned by
    ///     vkGetPhysicalDeviceSurfaceCapabilitiesKHR.NoteOn some platforms, it is normal that maxImageExtent may become (0,
    ///     0), for example when the window is minimized. In such a case, it is not possible to create a swapchain due to the
    ///     Valid Usage requirements.
    /// </summary>
    public VkExtent2D imageExtent;

    /// <summary>
    ///     imageArrayLayers is the number of views in a multiview/stereo surface. For non-stereoscopic-3D applications,
    ///     this value is 1.
    /// </summary>
    public uint imageArrayLayers;

    /// <summary>
    ///     imageUsage is a bitmask of VkImageUsageFlagBits describing the intended usage of the (acquired) swapchain
    ///     images.
    /// </summary>
    public VkImageUsageFlags imageUsage;

    /// <summary>imageSharingMode is the sharing mode used for the image(s) of the swapchain.</summary>
    public VkSharingMode imageSharingMode;

    /// <summary>
    ///     queueFamilyIndexCount is the number of queue families having access to the image(s) of the swapchain when
    ///     imageSharingMode is VK_SHARING_MODE_CONCURRENT.
    /// </summary>
    public uint queueFamilyIndexCount;

    /// <summary>
    ///     pQueueFamilyIndices is a pointer to an array of queue family indices having access to the images(s) of the
    ///     swapchain when imageSharingMode is VK_SHARING_MODE_CONCURRENT.
    /// </summary>
    public uint* pQueueFamilyIndices;

    /// <summary>
    ///     preTransform is a VkSurfaceTransformFlagBitsKHR value describing the transform, relative to the presentation
    ///     engine&#8217;s natural orientation, applied to the image content prior to presentation. If it does not match the
    ///     currentTransform value returned by vkGetPhysicalDeviceSurfaceCapabilitiesKHR, the presentation engine will
    ///     transform the image content as part of the presentation operation.
    /// </summary>
    public VkSurfaceTransformFlagBitsKHR preTransform;

    /// <summary>
    ///     compositeAlpha is a VkCompositeAlphaFlagBitsKHR value indicating the alpha compositing mode to use when this
    ///     surface is composited together with other surfaces on certain window systems.
    /// </summary>
    public VkCompositeAlphaFlagBitsKHR compositeAlpha;

    /// <summary>
    ///     presentMode is the presentation mode the swapchain will use. A swapchain&#8217;s present mode determines how
    ///     incoming present requests will be processed and queued internally.
    /// </summary>
    public VkPresentModeKHR presentMode;

    /// <summary>
    ///     clipped specifies whether the Vulkan implementation is allowed to discard rendering operations that affect
    ///     regions of the surface that are not visible.If set to VK_TRUE, the presentable images associated with the swapchain
    ///     may not own all of their pixels. Pixels in the presentable images that correspond to regions of the target surface
    ///     obscured by another window on the desktop, or subject to some other clipping mechanism will have undefined content
    ///     when read back. Fragment shaders may not execute for these pixels, and thus any side effects they would have had
    ///     will not occur. Setting VK_TRUE does not guarantee any clipping will occur, but allows more efficient presentation
    ///     methods to be used on some platforms.If set to VK_FALSE, presentable images associated with the swapchain will own
    ///     all of the pixels they contain.NoteApplications should set this value to VK_TRUE if they do not expect to read back
    ///     the content of presentable images before presenting them or after reacquiring them, and if their fragment shaders
    ///     do not have any side effects that require them to run for all pixels in the presentable image.
    /// </summary>
    public VkBool32 clipped;

    /// <summary>
    ///     oldSwapchain is VK_NULL_HANDLE, or the existing non-retired swapchain currently associated with surface.
    ///     Providing a valid oldSwapchain may aid in the resource reuse, and also allows the application to still present any
    ///     images that are already acquired from it.
    /// </summary>
    public VkSwapchainKHR oldSwapchain;
}