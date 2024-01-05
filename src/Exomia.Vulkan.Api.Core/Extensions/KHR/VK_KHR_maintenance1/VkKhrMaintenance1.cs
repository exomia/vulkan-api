#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrMaintenance1;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_maintenance1 - device extension (nr. 70) - author 'KHR' [platform '' | contact 'Piers Daniell @pdaniell-nv']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance1.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance1.html</a>
/// </summary>
[VkDeviceExt]
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance1.html#_deprecation_state")]
public static unsafe class VkKhrMaintenance1
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_MAINTENANCE_1_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_MAINTENANCE_1_EXTENSION_NAME = "VK_KHR_maintenance1";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_MAINTENANCE_1_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_MAINTENANCE_1_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_MAINTENANCE_1_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u4d5f\u4941\u544e\u4e45\u4e41\u4543\u315f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary> The spec version. </summary>
    public const uint VK_KHR_MAINTENANCE1_SPEC_VERSION = VK_KHR_MAINTENANCE_1_SPEC_VERSION;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_MAINTENANCE1_EXTENSION_NAME = VK_KHR_MAINTENANCE_1_EXTENSION_NAME;

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_MAINTENANCE1_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_MAINTENANCE1_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_MAINTENANCE1_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u4d5f\u4941\u544e\u4e45\u4e41\u4543\u5f31\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkTrimCommandPoolKHR alias for vkTrimCommandPool
    /// <summary>
    ///     vkTrimCommandPool - Trim a command pool -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkTrimCommandPoolKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkTrimCommandPoolKHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCommandPool /*commandPool*/,
        VkCommandPoolTrimFlags /*flags*/,
        void> vkTrimCommandPoolKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkTrimCommandPoolKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void>* pvkTrimCommandPoolKHR = &vkTrimCommandPoolKHR)
        {
            *pvkTrimCommandPoolKHR = (delegate*<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void>)GetVkFunction(device, "\u6b76\u7254\u6d69\u6f43\u6d6d\u6e61\u5064\u6f6f\u4b6c\u5248\u0000");
        }
    }
}