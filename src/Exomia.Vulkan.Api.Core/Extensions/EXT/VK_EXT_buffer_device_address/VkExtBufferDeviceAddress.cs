#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtBufferDeviceAddress;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_buffer_device_address - device extension (nr. 245) - author 'NV' [platform '' | contact 'Jeff Bolz
///     @jeffbolznv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_buffer_device_address.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_buffer_device_address.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[Obsolete(
    "deprecated by VK_KHR_buffer_device_address", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_buffer_device_address.html#_deprecation_state")]
public static unsafe class VkExtBufferDeviceAddress
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME = "VK_EXT_buffer_device_address";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u425f\u4655\u4546\u5f52\u4544\u4956\u4543\u415f\u4444\u4552\u5353\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// vkGetBufferDeviceAddressEXT alias for vkGetBufferDeviceAddress
    /// <summary>
    ///     vkGetBufferDeviceAddress - Query an address of a buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddressEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddressEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkBufferDeviceAddressInfo* /*pInfo*/,
        VkDeviceAddress> vkGetBufferDeviceAddressEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetBufferDeviceAddressEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress>* pvkGetBufferDeviceAddressEXT = &vkGetBufferDeviceAddressEXT)
        {
            *pvkGetBufferDeviceAddressEXT = (delegate*<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress>)GetVkFunction(
                device, "\u6b76\u6547\u4274\u6675\u6566\u4472\u7665\u6369\u4165\u6464\u6572\u7373\u5845\u0054");
        }
    }
}