#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDirectModeDisplay;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_direct_mode_display - instance extension (nr. 89) - author 'NV' [platform '' | contact 'James Jones
///     @cubanismo']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_direct_mode_display.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_direct_mode_display.html</a>
/// </summary>
[VkRequires("VK_KHR_display")]
public static unsafe class VkExtDirectModeDisplay
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME = "VK_EXT_direct_mode_display";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u445f\u5249\u4345\u5f54\u4f4d\u4544\u445f\u5349\u4c50\u5941\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkReleaseDisplayEXT - Release access to an acquired VkDisplayKHR -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseDisplayEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseDisplayEXT.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice The physical device the display is on.</param>
    /// <param name="display">display The display to release control of.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkDisplayKHR /*display*/,
        VkResult> vkReleaseDisplayEXT = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkDisplayKHR, VkResult>* pvkReleaseDisplayEXT = &vkReleaseDisplayEXT)
        {
            *pvkReleaseDisplayEXT = (delegate*<VkPhysicalDevice, VkDisplayKHR, VkResult>)Core.Vk.GetVkFunction(instance, "\u6b76\u6552\u656c\u7361\u4465\u7369\u6c70\u7961\u5845\u0054");
        }
    }
}