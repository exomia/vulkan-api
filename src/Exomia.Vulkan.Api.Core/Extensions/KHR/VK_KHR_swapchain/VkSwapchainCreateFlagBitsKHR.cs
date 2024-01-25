#region License

// Copyright (c) 2018-2024, exomia
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
///     VkSwapchainCreateFlagBitsKHR - Bitmask controlling swapchain creation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainCreateFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainCreateFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkSwapchainCreateFlagBitsKHR
{
    /// <summary>
    ///     VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR specifies that images created from the swapchain (i.e.
    ///     with the swapchainmember of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageSwapchainCreateInfoKHR.html">VkImageSwapchainCreateInfoKHR</a>
    ///     set to this swapchain&#8217;s handle) must use VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT.
    /// </summary>
    VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = 0x1,

    /// <summary>VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR specifies that images created from the swapchain are protected images.</summary>
    VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR specifies that the images of the swapchain can be used to create a
    ///     VkImageView with a different format than what the swapchain was created with. The list of allowed image view
    ///     formats is specified by adding a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageFormatListCreateInfo.html">VkImageFormatListCreateInfo</a>
    ///     structure to the pNext chain of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainCreateInfoKHR.html">VkSwapchainCreateInfoKHR</a>
    ///     . In addition, this flag also specifies that the swapchain can be created with usage flags that are not supported
    ///     for the format the swapchain is created with but are supported for at least one of the allowed image view formats.
    /// </summary>
    VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT specifies     that the implementation may defer
    ///     allocation of memory associated with     each swapchain image until its index is to be returned from
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImageKHR.html">vkAcquireNextImageKHR</a>
    ///     or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImage2KHR.html">vkAcquireNextImage2KHR</a>
    ///     for the first time.
    /// </summary>
    VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT = 0x8
}