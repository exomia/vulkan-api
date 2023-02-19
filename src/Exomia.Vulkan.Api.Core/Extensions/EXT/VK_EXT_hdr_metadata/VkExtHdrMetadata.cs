#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtHdrMetadata;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_hdr_metadata - device extension (nr. 106) - author 'GOOGLE' [platform '' | contact 'Courtney
///     Goeltzenleuchter @courtney-g']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_hdr_metadata.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_hdr_metadata.html</a>
/// </summary>
[VkDepends("VK_KHR_swapchain")]
public static unsafe class VkExtHdrMetadata
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_HDR_METADATA_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_HDR_METADATA_EXTENSION_NAME = "VK_EXT_hdr_metadata";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_HDR_METADATA_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_HDR_METADATA_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_HDR_METADATA_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u485f\u5244\u4d5f\u5445\u4441\u5441\u5f41\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkSetHdrMetadataEXT - Set Hdr metadata -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetHdrMetadataEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetHdrMetadataEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device where the swapchain(s) were created.</param>
    /// <param name="swapchainCount">swapchainCount is the number of swapchains included in pSwapchains.</param>
    /// <param name="pSwapchains">pSwapchains is a pointer to an array of swapchainCountVkSwapchainKHR handles.</param>
    /// <param name="pMetadata">pMetadata is a pointer to an array of swapchainCountVkHdrMetadataEXT structures.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        uint /*swapchainCount*/,
        VkSwapchainKHR* /*pSwapchains*/,
        VkHdrMetadataEXT* /*pMetadata*/,
        void> vkSetHdrMetadataEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkSetHdrMetadataEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void>* pvkSetHdrMetadataEXT = &vkSetHdrMetadataEXT)
        {
            *pvkSetHdrMetadataEXT = (delegate*<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void>)GetVkFunction(device, "\u6b76\u6553\u4874\u7264\u654d\u6174\u6164\u6174\u5845\u0054");
        }
    }
}