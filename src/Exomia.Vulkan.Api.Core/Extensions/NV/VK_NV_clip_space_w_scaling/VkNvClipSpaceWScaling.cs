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
///     VK_NV_clip_space_w_scaling - device extension (nr. 88) - author 'NV' [platform '' | contact 'Eric Werness
///     @ewerness-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_clip_space_w_scaling.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_clip_space_w_scaling.html</a>
/// </summary>
public static unsafe class VkNvClipSpaceWScaling
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME = "VK_NV_clip_space_w_scaling";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4c43\u5049\u535f\u4150\u4543\u575f\u535f\u4143\u494c\u474e\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdSetViewportWScalingNV - Set the viewport W scaling dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWScalingNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWScalingNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstViewport">
    ///     firstViewport is the index of the first viewport whose parameters are updated by the
    ///     command.
    /// </param>
    /// <param name="viewportCount">viewportCount is the number of viewports whose parameters are updated by the command.</param>
    /// <param name="pViewportWScalings">
    ///     pViewportWScalings is a pointer to an array of VkViewportWScalingNV structures
    ///     specifying viewport parameters.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstViewport*/,
        uint /*viewportCount*/,
        VkViewportWScalingNV* /*pViewportWScalings*/,
        void> vkCmdSetViewportWScalingNV = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void>* pvkCmdSetViewportWScalingNV = &vkCmdSetViewportWScalingNV)
        {
            *pvkCmdSetViewportWScalingNV = (delegate*<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6956\u7765\u6f70\u7472\u5357\u6163\u696c\u676e\u564e\u0000");
        }
    }
}