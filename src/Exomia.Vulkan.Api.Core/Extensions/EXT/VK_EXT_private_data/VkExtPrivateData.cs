#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtPrivateData;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_private_data - device extension (nr. 296) - author 'NV' [platform '' | contact 'Matthew Rusch @mattruschnv']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_private_data.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_private_data.html</a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_private_data.html#_deprecation_state")]
public static unsafe class VkExtPrivateData
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_PRIVATE_DATA_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_PRIVATE_DATA_EXTENSION_NAME = "VK_EXT_private_data";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_PRIVATE_DATA_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_PRIVATE_DATA_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_PRIVATE_DATA_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u505f\u4952\u4156\u4554\u445f\u5441\u5f41\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkCreatePrivateDataSlotEXT alias for vkCreatePrivateDataSlot
    /// <summary>
    ///     vkCreatePrivateDataSlot - Create a slot for private data storage -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePrivateDataSlotEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePrivateDataSlotEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPrivateDataSlotCreateInfo* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkPrivateDataSlot* /*pPrivateDataSlot*/,
        VkResult> vkCreatePrivateDataSlotEXT = null;

    /// vkDestroyPrivateDataSlotEXT alias for vkDestroyPrivateDataSlot
    /// <summary>
    ///     vkDestroyPrivateDataSlot - Destroy a private data slot -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPrivateDataSlotEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPrivateDataSlotEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPrivateDataSlot /*privateDataSlot*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyPrivateDataSlotEXT = null;

    /// vkSetPrivateDataEXT alias for vkSetPrivateData
    /// <summary>
    ///     vkSetPrivateData - Associate data with a Vulkan object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetPrivateDataEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetPrivateDataEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkObjectType /*objectType*/,
        ulong /*objectHandle*/,
        VkPrivateDataSlot /*privateDataSlot*/,
        ulong /*data*/,
        VkResult> vkSetPrivateDataEXT = null;

    /// vkGetPrivateDataEXT alias for vkGetPrivateData
    /// <summary>
    ///     vkGetPrivateData - Retrieve data associated with a Vulkan object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPrivateDataEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPrivateDataEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkObjectType /*objectType*/,
        ulong /*objectHandle*/,
        VkPrivateDataSlot /*privateDataSlot*/,
        ulong* /*pData*/,
        void> vkGetPrivateDataEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreatePrivateDataSlotEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyPrivateDataSlotEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkSetPrivateDataEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPrivateDataEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult>* pvkCreatePrivateDataSlotEXT = &vkCreatePrivateDataSlotEXT)
        {
            *pvkCreatePrivateDataSlotEXT = (delegate*<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u7250\u7669\u7461\u4465\u7461\u5361\u6f6c\u4574\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void>* pvkDestroyPrivateDataSlotEXT = &vkDestroyPrivateDataSlotEXT)
        {
            *pvkDestroyPrivateDataSlotEXT = (delegate*<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u5079\u6972\u6176\u6574\u6144\u6174\u6c53\u746f\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult>* pvkSetPrivateDataEXT = &vkSetPrivateDataEXT)
        {
            *pvkSetPrivateDataEXT =
                (delegate*<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult>)Core.Vk.GetVkFunction(device, "\u6b76\u6553\u5074\u6972\u6176\u6574\u6144\u6174\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void>* pvkGetPrivateDataEXT = &vkGetPrivateDataEXT)
        {
            *pvkGetPrivateDataEXT =
                (delegate*<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6547\u5074\u6972\u6176\u6574\u6144\u6174\u5845\u0054");
        }
    }
}