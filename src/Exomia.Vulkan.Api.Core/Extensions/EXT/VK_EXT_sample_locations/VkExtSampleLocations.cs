#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtSampleLocations;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_sample_locations - device extension (nr. 144) - author 'AMD' [platform '' | contact 'Daniel Rakos
///     @drakos-amd']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_sample_locations.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_sample_locations.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
public static unsafe class VkExtSampleLocations
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME = "VK_EXT_sample_locations";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u535f\u4d41\u4c50\u5f45\u4f4c\u4143\u4954\u4e4f\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetSampleLocationsEXT - Set sample locations dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleLocationsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleLocationsEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pSampleLocationsInfo">pSampleLocationsInfo is the sample locations state to set.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkSampleLocationsInfoEXT* /*pSampleLocationsInfo*/,
        void> vkCmdSetSampleLocationsEXT = null;

    /// <summary>
    ///     vkGetPhysicalDeviceMultisamplePropertiesEXT - Report sample count specific multisampling capabilities of a physical
    ///     device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMultisamplePropertiesEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMultisamplePropertiesEXT.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the physical device from which to query the additional multisampling
    ///     capabilities.
    /// </param>
    /// <param name="samples">samples is a VkSampleCountFlagBits value specifying the sample count to query capabilities for.</param>
    /// <param name="pMultisampleProperties">
    ///     pMultisampleProperties is a pointer to a VkMultisamplePropertiesEXT structure in
    ///     which information about additional multisampling capabilities specific to the sample count is returned.
    /// </param>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkSampleCountFlagBits /*samples*/,
        VkMultisamplePropertiesEXT* /*pMultisampleProperties*/,
        void> vkGetPhysicalDeviceMultisamplePropertiesEXT = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkSampleLocationsInfoEXT*, void>* pvkCmdSetSampleLocationsEXT = &vkCmdSetSampleLocationsEXT)
        {
            *pvkCmdSetSampleLocationsEXT = (delegate*<VkCommandBuffer, VkSampleLocationsInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6153\u706d\u656c\u6f4c\u6163\u6974\u6e6f\u4573\u5458\u0000");
        }
        fixed (delegate*<VkPhysicalDevice, VkSampleCountFlagBits, VkMultisamplePropertiesEXT*, void>* pvkGetPhysicalDeviceMultisamplePropertiesEXT = &vkGetPhysicalDeviceMultisamplePropertiesEXT)
        {
            *pvkGetPhysicalDeviceMultisamplePropertiesEXT = (delegate*<VkPhysicalDevice, VkSampleCountFlagBits, VkMultisamplePropertiesEXT*, void>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4d65\u6c75\u6974\u6173\u706d\u656c\u7250\u706f\u7265\u6974\u7365\u5845\u0054");
        }
    }
}