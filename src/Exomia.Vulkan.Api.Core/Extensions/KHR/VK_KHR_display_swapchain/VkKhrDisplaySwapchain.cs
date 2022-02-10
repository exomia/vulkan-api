#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrDisplaySwapchain;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_display_swapchain - device extension (nr. 4) - author 'KHR' [platform '' | contact 'James Jones @cubanismo']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_display_swapchain.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_display_swapchain.html</a>
/// </summary>
[VkRequires("VK_KHR_swapchain,VK_KHR_display")]
public static unsafe class VkKhrDisplaySwapchain
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION = 10;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME = "VK_KHR_display_swapchain";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u445f\u5349\u4c50\u5941\u535f\u4157\u4350\u4148\u4e49\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCreateSharedSwapchainsKHR - Create multiple swapchains that share presentable images -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSharedSwapchainsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSharedSwapchainsKHR.html</a>
    /// </summary>
    /// <param name="device">device is the device to create the swapchains for.</param>
    /// <param name="swapchainCount">swapchainCount is the number of swapchains to create.</param>
    /// <param name="pCreateInfos">
    ///     pCreateInfos is a pointer to an array of VkSwapchainCreateInfoKHR structures specifying the
    ///     parameters of the created swapchains.
    /// </param>
    /// <param name="pAllocator">
    ///     pAllocator is the allocator used for host memory allocated for the swapchain objects when
    ///     there is no more specific allocator available (see Memory Allocation).
    /// </param>
    /// <param name="pSwapchains">
    ///     pSwapchains is a pointer to an array of VkSwapchainKHRhandles in which the created swapchain
    ///     objects will be returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INCOMPATIBLE_DISPLAY_KHR,VK_ERROR_DEVICE_LOST,VK_ERROR_SURFACE_LOST_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        uint /*swapchainCount*/,
        VkSwapchainCreateInfoKHR* /*pCreateInfos*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkSwapchainKHR* /*pSwapchains*/,
        VkResult> vkCreateSharedSwapchainsKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, uint, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult>* pvkCreateSharedSwapchainsKHR = &vkCreateSharedSwapchainsKHR)
        {
            *pvkCreateSharedSwapchainsKHR = (delegate*<VkDevice, uint, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6853\u7261\u6465\u7753\u7061\u6863\u6961\u736e\u484b\u0052");
        }
    }
}