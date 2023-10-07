#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrVideoDecodeQueue;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_video_decode_queue - device extension (nr. 25) - author 'KHR' [platform '' | contact 'jake.beju@amd.com']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_decode_queue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_decode_queue.html</a>
/// </summary>
[VkDepends("VK_KHR_video_queue+VK_KHR_synchronization2")]
[VkDeviceExt]
public static unsafe class VkKhrVideoDecodeQueue
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_VIDEO_DECODE_QUEUE_SPEC_VERSION = 7;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_VIDEO_DECODE_QUEUE_EXTENSION_NAME = "VK_KHR_video_decode_queue";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_VIDEO_DECODE_QUEUE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_VIDEO_DECODE_QUEUE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_VIDEO_DECODE_QUEUE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u565f\u4449\u4f45\u445f\u4345\u444f\u5f45\u5551\u5545\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdDecodeVideoKHR - Launch a video decode operation -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDecodeVideoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDecodeVideoKHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to record the command.</param>
    /// <param name="pDecodeInfo">
    ///     pDecodeInfo is a pointer to a VkVideoDecodeInfoKHR structure specifying the parameters of the
    ///     video decode operations.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkVideoDecodeInfoKHR* /*pDecodeInfo*/,
        void> vkCmdDecodeVideoKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdDecodeVideoKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkVideoDecodeInfoKHR*, void>* pvkCmdDecodeVideoKHR = &vkCmdDecodeVideoKHR)
        {
            *pvkCmdDecodeVideoKHR = (delegate*<VkCommandBuffer, VkVideoDecodeInfoKHR*, void>)GetVkFunction(device, "\u6b76\u6d43\u4464\u6365\u646f\u5665\u6469\u6f65\u484b\u0052");
        }
    }
}