#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrSharedPresentableImage;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_shared_presentable_image - device extension (nr. 112) - author 'KHR' [platform '' | contact 'Alon Or-bach
///     @alonorbach']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_shared_presentable_image.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_shared_presentable_image.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+(VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)")]
[VkDeviceExt]
public static unsafe class VkKhrSharedPresentableImage
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME = "VK_KHR_shared_presentable_image";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u535f\u4148\u4552\u5f44\u5250\u5345\u4e45\u4154\u4c42\u5f45\u4d49\u4741\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetSwapchainStatusKHR - Get a swapchain's status -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainStatusKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainStatusKHR.html</a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">swapchain is the swapchain to query.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_SUBOPTIMAL_KHR</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_OUT_OF_DATE_KHR,VK_ERROR_SURFACE_LOST_KHR,VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        VkResult> vkGetSwapchainStatusKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetSwapchainStatusKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkSwapchainKHR, VkResult>* pvkGetSwapchainStatusKHR = &vkGetSwapchainStatusKHR)
        {
            *pvkGetSwapchainStatusKHR = (delegate*<VkDevice, VkSwapchainKHR, VkResult>)GetVkFunction(device, "\u6b76\u6547\u5374\u6177\u6370\u6168\u6e69\u7453\u7461\u7375\u484b\u0052");
        }
    }
}