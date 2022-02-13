#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_tooling_info - device extension (nr. 246) - author 'EXT' [platform '' | contact 'Tobias Hector @tobski']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_tooling_info.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_tooling_info.html</a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_tooling_info.html#_deprecation_state")]
public static unsafe class VkExtToolingInfo
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_TOOLING_INFO_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_TOOLING_INFO_EXTENSION_NAME = "VK_EXT_tooling_info";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_TOOLING_INFO_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_TOOLING_INFO_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_TOOLING_INFO_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u545f\u4f4f\u494c\u474e\u495f\u464e\u5f4f\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkGetPhysicalDeviceToolPropertiesEXT alias for vkGetPhysicalDeviceToolProperties
    /// <summary>
    ///     vkGetPhysicalDeviceToolProperties - Reports properties of tools active on the specified physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceToolPropertiesEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceToolPropertiesEXT.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        uint* /*pToolCount*/,
        VkPhysicalDeviceToolProperties* /*pToolProperties*/,
        VkResult> vkGetPhysicalDeviceToolPropertiesEXT = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult>* pvkGetPhysicalDeviceToolPropertiesEXT = &vkGetPhysicalDeviceToolPropertiesEXT)
        {
            *pvkGetPhysicalDeviceToolPropertiesEXT = (delegate*<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5465\u6f6f\u506c\u6f72\u6570\u7472\u6569\u4573\u5458\u0000");
        }
    }
}