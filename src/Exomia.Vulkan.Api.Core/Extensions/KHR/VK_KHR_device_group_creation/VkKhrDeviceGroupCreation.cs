#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrDeviceGroupCreation;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_device_group_creation - instance extension (nr. 71) - author 'KHR' [platform '' | contact 'Jeff Bolz
///     @jeffbolznv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_device_group_creation.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_device_group_creation.html</a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_device_group_creation.html#_deprecation_state")]
public static unsafe class VkKhrDeviceGroupCreation
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME = "VK_KHR_device_group_creation";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u445f\u5645\u4349\u5f45\u5247\u554f\u5f50\u5243\u4145\u4954\u4e4f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     VK_MAX_DEVICE_GROUP_SIZE - Length of a physical device handle array -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DEVICE_GROUP_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DEVICE_GROUP_SIZE.html</a>
    /// </summary>
    /// <remarks> VK_MAX_DEVICE_GROUP_SIZE_KHR alias for VK_MAX_DEVICE_GROUP_SIZE_KHR. </remarks>
    public const uint VK_MAX_DEVICE_GROUP_SIZE_KHR = VK_MAX_DEVICE_GROUP_SIZE;

    /// vkEnumeratePhysicalDeviceGroupsKHR alias for vkEnumeratePhysicalDeviceGroups
    /// <summary>
    ///     vkEnumeratePhysicalDeviceGroups - Enumerates groups of physical devices that can be used to create a single
    ///     logical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceGroupsKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceGroupsKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkInstance /*instance*/,
        uint* /*pPhysicalDeviceGroupCount*/,
        VkPhysicalDeviceGroupProperties* /*pPhysicalDeviceGroupProperties*/,
        VkResult> vkEnumeratePhysicalDeviceGroupsKHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkEnumeratePhysicalDeviceGroupsKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult>* pvkEnumeratePhysicalDeviceGroupsKHR = &vkEnumeratePhysicalDeviceGroupsKHR)
        {
            *pvkEnumeratePhysicalDeviceGroupsKHR = (delegate*<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6e45\u6d75\u7265\u7461\u5065\u7968\u6973\u6163\u446c\u7665\u6369\u4765\u6f72\u7075\u4b73\u5248\u0000");
        }
    }
}