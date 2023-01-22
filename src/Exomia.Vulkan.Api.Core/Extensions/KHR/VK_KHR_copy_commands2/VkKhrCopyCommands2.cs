#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrCopyCommands2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_copy_commands2 - device extension (nr. 338) - author 'KHR' [platform '' | contact 'Jeff Leger @jackohound']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_copy_commands2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_copy_commands2.html</a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_copy_commands2.html#_deprecation_state")]
public static unsafe class VkKhrCopyCommands2
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_COPY_COMMANDS_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME = "VK_KHR_copy_commands2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u435f\u504f\u5f59\u4f43\u4d4d\u4e41\u5344\u325f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// vkCmdCopyBuffer2KHR alias for vkCmdCopyBuffer2
    /// <summary>
    ///     vkCmdCopyBuffer2 - Copy data between buffer regions -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyBufferInfo2* /*pCopyBufferInfo*/,
        void> vkCmdCopyBuffer2KHR = null;

    /// vkCmdCopyImage2KHR alias for vkCmdCopyImage2
    /// <summary>
    ///     vkCmdCopyImage2 - Copy data between images -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyImageInfo2* /*pCopyImageInfo*/,
        void> vkCmdCopyImage2KHR = null;

    /// vkCmdCopyBufferToImage2KHR alias for vkCmdCopyBufferToImage2
    /// <summary>
    ///     vkCmdCopyBufferToImage2 - Copy data from a buffer into an image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyBufferToImageInfo2* /*pCopyBufferToImageInfo*/,
        void> vkCmdCopyBufferToImage2KHR = null;

    /// vkCmdCopyImageToBuffer2KHR alias for vkCmdCopyImageToBuffer2
    /// <summary>
    ///     vkCmdCopyImageToBuffer2 - Copy image data into a buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCopyImageToBufferInfo2* /*pCopyImageToBufferInfo*/,
        void> vkCmdCopyImageToBuffer2KHR = null;

    /// vkCmdBlitImage2KHR alias for vkCmdBlitImage2
    /// <summary>
    ///     vkCmdBlitImage2 - Copy regions of an image, potentially performing format conversion, -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBlitImageInfo2* /*pBlitImageInfo*/,
        void> vkCmdBlitImage2KHR = null;

    /// vkCmdResolveImage2KHR alias for vkCmdResolveImage2
    /// <summary>
    ///     vkCmdResolveImage2 - Resolve regions of an image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkResolveImageInfo2* /*pResolveImageInfo*/,
        void> vkCmdResolveImage2KHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdCopyBuffer2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdCopyImage2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdCopyBufferToImage2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdCopyImageToBuffer2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBlitImage2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdResolveImage2KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkCopyBufferInfo2*, void>* pvkCmdCopyBuffer2KHR = &vkCmdCopyBuffer2KHR)
        {
            *pvkCmdCopyBuffer2KHR = (delegate*<VkCommandBuffer, VkCopyBufferInfo2*, void>)GetVkFunction(device, "\u6b76\u6d43\u4364\u706f\u4279\u6675\u6566\u3272\u484b\u0052");
        }

        fixed (delegate*<VkCommandBuffer, VkCopyImageInfo2*, void>* pvkCmdCopyImage2KHR = &vkCmdCopyImage2KHR)
        {
            *pvkCmdCopyImage2KHR = (delegate*<VkCommandBuffer, VkCopyImageInfo2*, void>)GetVkFunction(device, "\u6b76\u6d43\u4364\u706f\u4979\u616d\u6567\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkCopyBufferToImageInfo2*, void>* pvkCmdCopyBufferToImage2KHR = &vkCmdCopyBufferToImage2KHR)
        {
            *pvkCmdCopyBufferToImage2KHR = (delegate*<VkCommandBuffer, VkCopyBufferToImageInfo2*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4364\u706f\u4279\u6675\u6566\u5472\u496f\u616d\u6567\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkCopyImageToBufferInfo2*, void>* pvkCmdCopyImageToBuffer2KHR = &vkCmdCopyImageToBuffer2KHR)
        {
            *pvkCmdCopyImageToBuffer2KHR = (delegate*<VkCommandBuffer, VkCopyImageToBufferInfo2*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4364\u706f\u4979\u616d\u6567\u6f54\u7542\u6666\u7265\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBlitImageInfo2*, void>* pvkCmdBlitImage2KHR = &vkCmdBlitImage2KHR)
        {
            *pvkCmdBlitImage2KHR = (delegate*<VkCommandBuffer, VkBlitImageInfo2*, void>)GetVkFunction(device, "\u6b76\u6d43\u4264\u696c\u4974\u616d\u6567\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkResolveImageInfo2*, void>* pvkCmdResolveImage2KHR = &vkCmdResolveImage2KHR)
        {
            *pvkCmdResolveImage2KHR = (delegate*<VkCommandBuffer, VkResolveImageInfo2*, void>)GetVkFunction(device, "\u6b76\u6d43\u5264\u7365\u6c6f\u6576\u6d49\u6761\u3265\u484b\u0052");
        }
    }
}