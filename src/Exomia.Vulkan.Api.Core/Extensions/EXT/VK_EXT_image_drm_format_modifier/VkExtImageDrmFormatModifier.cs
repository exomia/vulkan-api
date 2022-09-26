#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtImageDrmFormatModifier;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_image_drm_format_modifier - device extension (nr. 159) - author 'EXT' [platform '' | contact 'Chad Versace @chadversary']
///     <br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_drm_format_modifier.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_drm_format_modifier.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_bind_memory2,VK_KHR_get_physical_device_properties2,VK_KHR_image_format_list,VK_KHR_sampler_ycbcr_conversion")]
public static unsafe class VkExtImageDrmFormatModifier
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME = "VK_EXT_image_drm_format_modifier";

    /// <summary> An UTF8 null terminated version of <see cref="VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u495f\u414d\u4547\u445f\u4d52\u465f\u524f\u414d\u5f54\u4f4d\u4944\u4946\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetImageDrmFormatModifierPropertiesEXT - Returns an image's DRM format modifier -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageDrmFormatModifierPropertiesEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageDrmFormatModifierPropertiesEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the logical device that owns the image. </param>
    /// <param name="image"> image is the queried image. </param>
    /// <param name="pProperties"> pProperties is a pointer to a VkImageDrmFormatModifierPropertiesEXT structure in which properties of the image&#8217;s DRM format modifier are returned. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term><description> VK_ERROR_OUT_OF_HOST_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImage /*image*/,
        VkImageDrmFormatModifierPropertiesEXT* /*pProperties*/,
        VkResult> vkGetImageDrmFormatModifierPropertiesEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkGetImageDrmFormatModifierPropertiesEXT </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult>* pvkGetImageDrmFormatModifierPropertiesEXT = &vkGetImageDrmFormatModifierPropertiesEXT)
        {
            *pvkGetImageDrmFormatModifierPropertiesEXT = (delegate*<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4974\u616d\u6567\u7244\u466d\u726f\u616d\u4d74\u646f\u6669\u6569\u5072\u6f72\u6570\u7472\u6569\u4573\u5458\u0000");
        }
    }
}