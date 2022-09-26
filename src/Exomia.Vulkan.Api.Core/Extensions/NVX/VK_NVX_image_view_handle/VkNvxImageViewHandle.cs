#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvxImageViewHandle;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NVX_image_view_handle - device extension (nr. 31) - author 'NVX' [platform '' | contact 'Eric Werness @ewerness-nv']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NVX_image_view_handle.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NVX_image_view_handle.html </a>
/// </summary>
public static unsafe class VkNvxImageViewHandle
{
    /// <summary> The spec version. </summary>
    public const uint VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME = "VK_NVX_image_view_handle";

    /// <summary> An UTF8 null terminated version of <see cref="VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5856\u495f\u414d\u4547\u565f\u4549\u5f57\u4148\u444e\u454c\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetImageViewHandleNVX - Get the handle for an image view for a specific descriptor type -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageViewHandleNVX.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageViewHandleNVX.html </a>
    /// </summary>
    /// <param name="device"> device is the logical device that owns the image view. </param>
    /// <param name="pInfo"> pInfo describes the image view to query and type of handle. </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImageViewHandleInfoNVX* /*pInfo*/,
        uint> vkGetImageViewHandleNVX = null;

    /// <summary>
    ///     vkGetImageViewAddressNVX - Get the device address of an image view -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageViewAddressNVX.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageViewAddressNVX.html </a>
    /// </summary>
    /// <param name="device"> device is the logical device that owns the image view. </param>
    /// <param name="imageView"> imageView is a handle to the image view. </param>
    /// <param name="pProperties"> pProperties contains the device address and size when the call returns. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term><description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_UNKNOWN </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImageView /*imageView*/,
        VkImageViewAddressPropertiesNVX* /*pProperties*/,
        VkResult> vkGetImageViewAddressNVX = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkGetImageViewHandleNVX </description>
    ///         </item>
    ///         <item>
    ///             <description> vkGetImageViewAddressNVX </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkImageViewHandleInfoNVX*, uint>* pvkGetImageViewHandleNVX = &vkGetImageViewHandleNVX)
        {
            *pvkGetImageViewHandleNVX = (delegate*<VkDevice, VkImageViewHandleInfoNVX*, uint>)GetVkFunction(device, "\u6b76\u6547\u4974\u616d\u6567\u6956\u7765\u6148\u646e\u656c\u564e\u0058");
        }

        fixed (delegate*<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult>* pvkGetImageViewAddressNVX = &vkGetImageViewAddressNVX)
        {
            *pvkGetImageViewAddressNVX = (delegate*<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4974\u616d\u6567\u6956\u7765\u6441\u7264\u7365\u4e73\u5856\u0000");
        }
    }
}