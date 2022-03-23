#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkAmdBufferMarker;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_buffer_marker - device extension (nr. 180) - author 'AMD' [platform '' | contact 'Daniel Rakos @drakos-amd']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_buffer_marker.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_buffer_marker.html</a>
/// </summary>
/// <remarks>
///     specialuse: devtools
/// </remarks>
[VkSpecialuse("devtools")]
public static unsafe class VkAmdBufferMarker
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_BUFFER_MARKER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_BUFFER_MARKER_EXTENSION_NAME = "VK_AMD_buffer_marker";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_BUFFER_MARKER_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_BUFFER_MARKER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_BUFFER_MARKER_EXTENSION_NAME_UTF8_NT = "\u4b56\u415f\u444d\u425f\u4655\u4546\u5f52\u414d\u4b52\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdWriteBufferMarkerAMD - Execute a pipelined write of a marker value into a buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteBufferMarkerAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteBufferMarkerAMD.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pipelineStage">
    ///     pipelineStage is a VkPipelineStageFlagBits value specifying the pipeline stage whose
    ///     completion triggers the marker write.
    /// </param>
    /// <param name="dstBuffer">dstBuffer is the buffer where the marker will be written to.</param>
    /// <param name="dstOffset">dstOffset is the byte offset into the buffer where the marker will be written to.</param>
    /// <param name="marker">marker is the 32-bit value of the marker.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPipelineStageFlagBits /*pipelineStage*/,
        VkBuffer /*dstBuffer*/,
        VkDeviceSize /*dstOffset*/,
        uint /*marker*/,
        void> vkCmdWriteBufferMarkerAMD = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdWriteBufferMarkerAMD</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkBuffer, VkDeviceSize, uint, void>* pvkCmdWriteBufferMarkerAMD = &vkCmdWriteBufferMarkerAMD)
        {
            *pvkCmdWriteBufferMarkerAMD = (delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkBuffer, VkDeviceSize, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5764\u6972\u6574\u7542\u6666\u7265\u614d\u6b72\u7265\u4d41\u0044");
        }
    }
}