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
///     VK_KHR_dynamic_rendering - device extension (nr. 45) - author 'KHR' [platform '' | contact 'Tobias Hector @tobski']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_dynamic_rendering.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_dynamic_rendering.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_dynamic_rendering.html#_deprecation_state")]
public static unsafe class VkKhrDynamicRendering
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DYNAMIC_RENDERING_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DYNAMIC_RENDERING_EXTENSION_NAME = "VK_KHR_dynamic_rendering";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DYNAMIC_RENDERING_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DYNAMIC_RENDERING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DYNAMIC_RENDERING_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u445f\u4e59\u4d41\u4349\u525f\u4e45\u4544\u4952\u474e\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// vkCmdBeginRenderingKHR alias for vkCmdBeginRendering
    /// <summary>
    ///     vkCmdBeginRendering - Begin a dynamic render pass instance -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderingKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderingKHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkRenderingInfo* /*pRenderingInfo*/,
        void> vkCmdBeginRenderingKHR = null;

    /// vkCmdEndRenderingKHR alias for vkCmdEndRendering
    /// <summary>
    ///     vkCmdEndRendering - End a dynamic render pass instance -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderingKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderingKHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        void> vkCmdEndRenderingKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkRenderingInfo*, void>* pvkCmdBeginRenderingKHR = &vkCmdBeginRenderingKHR)
        {
            *pvkCmdBeginRenderingKHR = (delegate*<VkCommandBuffer, VkRenderingInfo*, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u4264\u6765\u6e69\u6552\u646e\u7265\u6e69\u4b67\u5248\u0000");
        }
        fixed (delegate*<VkCommandBuffer, void>* pvkCmdEndRenderingKHR = &vkCmdEndRenderingKHR)
        {
            *pvkCmdEndRenderingKHR = (delegate*<VkCommandBuffer, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u4564\u646e\u6552\u646e\u7265\u6e69\u4b67\u5248\u0000");
        }
    }
}