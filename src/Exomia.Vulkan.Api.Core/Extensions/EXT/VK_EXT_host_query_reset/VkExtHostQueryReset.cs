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
///     VK_EXT_host_query_reset - device extension (nr. 262) - author 'EXT' [platform '' | contact 'Bas Nieuwenhuizen
///     @BNieuwenhuizen']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_host_query_reset.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_host_query_reset.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[Obsolete("promoted to VK_VERSION_1_2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_host_query_reset.html#_deprecation_state")]
public static unsafe class VkExtHostQueryReset
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_HOST_QUERY_RESET_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME = "VK_EXT_host_query_reset";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u485f\u534f\u5f54\u5551\u5245\u5f59\u4552\u4553\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkResetQueryPoolEXT alias for vkResetQueryPool
    /// <summary>
    ///     vkResetQueryPool - Reset queries in a query pool -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetQueryPoolEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetQueryPoolEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkQueryPool /*queryPool*/,
        uint /*firstQuery*/,
        uint /*queryCount*/,
        void> vkResetQueryPoolEXT = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkQueryPool, uint, uint, void>* pvkResetQueryPoolEXT = &vkResetQueryPoolEXT)
        {
            *pvkResetQueryPoolEXT = (delegate*<VkDevice, VkQueryPool, uint, uint, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6552\u6573\u5174\u6575\u7972\u6f50\u6c6f\u5845\u0054");
        }
    }
}