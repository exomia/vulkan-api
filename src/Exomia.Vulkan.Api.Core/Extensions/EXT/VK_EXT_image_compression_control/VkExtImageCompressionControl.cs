#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtImageCompressionControl;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_image_compression_control - device extension (nr. 339) - author 'EXT' [platform '' | contact 'Jan-Harald
///     Fredriksen @janharaldfredriksen-arm']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_compression_control.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_compression_control.html
///     </a>
/// </summary>
public static unsafe class VkExtImageCompressionControl
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_IMAGE_COMPRESSION_CONTROL_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_IMAGE_COMPRESSION_CONTROL_EXTENSION_NAME = "VK_EXT_image_compression_control";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_IMAGE_COMPRESSION_CONTROL_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_IMAGE_COMPRESSION_CONTROL_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_IMAGE_COMPRESSION_CONTROL_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u495f\u414d\u4547\u435f\u4d4f\u5250\u5345\u4953\u4e4f\u435f\u4e4f\u5254\u4c4f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetImageSubresourceLayout2EXT - Retrieve information about an image subresource -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2EXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2EXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the image.</param>
    /// <param name="image">image is the image whose layout is being queried.</param>
    /// <param name="pSubresource">
    ///     pSubresource is a pointer to a VkImageSubresource2EXTstructure selecting a specific image
    ///     for the image subresource.
    /// </param>
    /// <param name="pLayout">pLayout is a pointer to a VkSubresourceLayout2EXT structure in which the layout is returned.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImage /*image*/,
        VkImageSubresource2EXT* /*pSubresource*/,
        VkSubresourceLayout2EXT* /*pLayout*/,
        void> vkGetImageSubresourceLayout2EXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetImageSubresourceLayout2EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkImage, VkImageSubresource2EXT*, VkSubresourceLayout2EXT*, void>* pvkGetImageSubresourceLayout2EXT = &vkGetImageSubresourceLayout2EXT)
        {
            *pvkGetImageSubresourceLayout2EXT = (delegate*<VkDevice, VkImage, VkImageSubresource2EXT*, VkSubresourceLayout2EXT*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4974\u616d\u6567\u7553\u7262\u7365\u756f\u6372\u4c65\u7961\u756f\u3274\u5845\u0054");
        }
    }
}