#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkAmdDisplayNativeHdr;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_display_native_hdr - device extension (nr. 214) - author 'AMD' [platform '' | contact 'Matthaeus G. Chajdas
///     @anteru']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_display_native_hdr.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_display_native_hdr.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2,VK_KHR_get_surface_capabilities2,VK_KHR_swapchain")]
public static unsafe class VkAmdDisplayNativeHdr
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME = "VK_AMD_display_native_hdr";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u444d\u445f\u5349\u4c50\u5941\u4e5f\u5441\u5649\u5f45\u4448\u5f52\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkSetLocalDimmingAMD - Set Local Dimming -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetLocalDimmingAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetLocalDimmingAMD.html</a>
    /// </summary>
    /// <param name="device">device is the device associated with swapChain.</param>
    /// <param name="swapChain">swapChain handle to enable local dimming.</param>
    /// <param name="localDimmingEnable">localDimmingEnable specifies whether local dimming is enabled for the swapchain.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapChain*/,
        VkBool32 /*localDimmingEnable*/,
        void> vkSetLocalDimmingAMD = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkSetLocalDimmingAMD</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkSwapchainKHR, VkBool32, void>* pvkSetLocalDimmingAMD = &vkSetLocalDimmingAMD)
        {
            *pvkSetLocalDimmingAMD = (delegate*<VkDevice, VkSwapchainKHR, VkBool32, void>)GetVkFunction(device, "\u6b76\u6553\u4c74\u636f\u6c61\u6944\u6d6d\u6e69\u4167\u444d\u0000");
        }
    }
}