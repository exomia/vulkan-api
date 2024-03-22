#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtHostImageCopy;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_host_image_copy - device extension (nr. 271) - author 'EXT' [platform '' | contact 'Shahbaz Youssefi
///     @syoussefi']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_host_image_copy.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_host_image_copy.html</a>
/// </summary>
[VkDepends("((VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+VK_KHR_copy_commands2+VK_KHR_format_feature_flags2),VK_VERSION_1_3")]
[VkDeviceExt]
public static unsafe class VkExtHostImageCopy
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_HOST_IMAGE_COPY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_HOST_IMAGE_COPY_EXTENSION_NAME = "VK_EXT_host_image_copy";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_HOST_IMAGE_COPY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_HOST_IMAGE_COPY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_HOST_IMAGE_COPY_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u485f\u534f\u5f54\u4d49\u4741\u5f45\u4f43\u5950\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCopyMemoryToImageEXT - Copy data from host memory into an image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToImageEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToImageEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns pCopyMemoryToImageInfo-&gt;dstImage.</param>
    /// <param name="pCopyMemoryToImageInfo">
    ///     pCopyMemoryToImageInfo is a pointer to a VkCopyMemoryToImageInfoEXT structure
    ///     describing the copy parameters.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_MEMORY_MAP_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCopyMemoryToImageInfoEXT* /*pCopyMemoryToImageInfo*/,
        VkResult> vkCopyMemoryToImageEXT = null;

    /// <summary>
    ///     vkCopyImageToMemoryEXT - Copy image data into host memory -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyImageToMemoryEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyImageToMemoryEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns pCopyImageToMemoryInfo-&gt;srcImage.</param>
    /// <param name="pCopyImageToMemoryInfo">
    ///     pCopyImageToMemoryInfo is a pointer to a VkCopyImageToMemoryInfoEXT structure
    ///     describing the copy parameters.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_MEMORY_MAP_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCopyImageToMemoryInfoEXT* /*pCopyImageToMemoryInfo*/,
        VkResult> vkCopyImageToMemoryEXT = null;

    /// <summary>
    ///     vkCopyImageToImageEXT - Copy image data using the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyImageToImageEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCopyImageToImageEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns pCopyImageToMemoryInfo-&gt;srcImage.</param>
    /// <param name="pCopyImageToImageInfo">
    ///     pCopyImageToImageInfo is a pointer to a VkCopyImageToImageInfoEXT structure
    ///     describing the copy parameters.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_MEMORY_MAP_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCopyImageToImageInfoEXT* /*pCopyImageToImageInfo*/,
        VkResult> vkCopyImageToImageEXT = null;

    /// <summary>
    ///     vkTransitionImageLayoutEXT - Perform an image layout transition on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkTransitionImageLayoutEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkTransitionImageLayoutEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns pTransitions[i].image.</param>
    /// <param name="transitionCount">transitionCount is the number of image layout transitions to perform.</param>
    /// <param name="pTransitions">
    ///     pTransitions is a pointer to an array of VkHostImageLayoutTransitionInfoEXT structures
    ///     specifying the image and subresource ranges within them to transition.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_MEMORY_MAP_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        uint /*transitionCount*/,
        VkHostImageLayoutTransitionInfoEXT* /*pTransitions*/,
        VkResult> vkTransitionImageLayoutEXT = null;

    /// vkGetImageSubresourceLayout2EXT alias for vkGetImageSubresourceLayout2KHR
    /// <summary>
    ///     vkGetImageSubresourceLayout2KHR - Retrieve information about an image subresource -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2EXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2EXT.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImage /*image*/,
        VkImageSubresource2KHR* /*pSubresource*/,
        VkSubresourceLayout2KHR* /*pLayout*/,
        void> vkGetImageSubresourceLayout2EXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCopyMemoryToImageEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCopyImageToMemoryEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCopyImageToImageEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkTransitionImageLayoutEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetImageSubresourceLayout2EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkCopyMemoryToImageInfoEXT*, VkResult>* pvkCopyMemoryToImageEXT = &vkCopyMemoryToImageEXT)
        {
            *pvkCopyMemoryToImageEXT = (delegate*<VkDevice, VkCopyMemoryToImageInfoEXT*, VkResult>)GetVkFunction(device, "\u6b76\u6f43\u7970\u654d\u6f6d\u7972\u6f54\u6d49\u6761\u4565\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkCopyImageToMemoryInfoEXT*, VkResult>* pvkCopyImageToMemoryEXT = &vkCopyImageToMemoryEXT)
        {
            *pvkCopyImageToMemoryEXT = (delegate*<VkDevice, VkCopyImageToMemoryInfoEXT*, VkResult>)GetVkFunction(device, "\u6b76\u6f43\u7970\u6d49\u6761\u5465\u4d6f\u6d65\u726f\u4579\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkCopyImageToImageInfoEXT*, VkResult>* pvkCopyImageToImageEXT = &vkCopyImageToImageEXT)
        {
            *pvkCopyImageToImageEXT = (delegate*<VkDevice, VkCopyImageToImageInfoEXT*, VkResult>)GetVkFunction(device, "\u6b76\u6f43\u7970\u6d49\u6761\u5465\u496f\u616d\u6567\u5845\u0054");
        }

        fixed (delegate*<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult>* pvkTransitionImageLayoutEXT = &vkTransitionImageLayoutEXT)
        {
            *pvkTransitionImageLayoutEXT = (delegate*<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u7254\u6e61\u6973\u6974\u6e6f\u6d49\u6761\u4c65\u7961\u756f\u4574\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void>* pvkGetImageSubresourceLayout2EXT = &vkGetImageSubresourceLayout2EXT)
        {
            *pvkGetImageSubresourceLayout2EXT = (delegate*<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4974\u616d\u6567\u7553\u7262\u7365\u756f\u6372\u4c65\u7961\u756f\u3274\u5845\u0054");
        }
    }
}