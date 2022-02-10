#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtMultiDraw;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_multi_draw - device extension (nr. 393) - author 'EXT' [platform '' | contact 'Mike Blumenkrantz @zmike']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_multi_draw.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_multi_draw.html</a>
/// </summary>
public static unsafe class VkExtMultiDraw
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_MULTI_DRAW_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_MULTI_DRAW_EXTENSION_NAME = "VK_EXT_multi_draw";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_MULTI_DRAW_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_MULTI_DRAW_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_MULTI_DRAW_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u4d5f\u4c55\u4954\u445f\u4152\u5f57\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdDrawMultiEXT - Draw primitives -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMultiEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMultiEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="drawCount">drawCount is the number of draws to execute, and can be zero.</param>
    /// <param name="pVertexInfo">
    ///     pVertexInfo is a pointer to an array of VkMultiDrawInfoEXTwith vertex information to be
    ///     drawn.
    /// </param>
    /// <param name="instanceCount">instanceCount is the number of instances to draw.</param>
    /// <param name="firstInstance">firstInstance is the instance ID of the first instance to draw.</param>
    /// <param name="stride">stride is the byte stride between consecutive elements of pVertexInfo.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*drawCount*/,
        VkMultiDrawInfoEXT* /*pVertexInfo*/,
        uint /*instanceCount*/,
        uint /*firstInstance*/,
        uint /*stride*/,
        void> vkCmdDrawMultiEXT = null;

    /// <summary>
    ///     vkCmdDrawMultiIndexedEXT - Draw primitives -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMultiIndexedEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMultiIndexedEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="drawCount">drawCount is the number of draws to execute, and can be zero.</param>
    /// <param name="pIndexInfo">
    ///     pIndexInfo is a pointer to an array of VkMultiDrawIndexedInfoEXT with index information to be
    ///     drawn.
    /// </param>
    /// <param name="instanceCount">instanceCount is the number of instances to draw.</param>
    /// <param name="firstInstance">firstInstance is the instance ID of the first instance to draw.</param>
    /// <param name="stride">stride is the byte stride between consecutive elements of pIndexInfo.</param>
    /// <param name="pVertexOffset">
    ///     pVertexOffset is NULL or a pointer to the value added to the vertex index before indexing
    ///     into the vertex buffer. When specified, VkMultiDrawIndexedInfoEXT::offset is ignored.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*drawCount*/,
        VkMultiDrawIndexedInfoEXT* /*pIndexInfo*/,
        uint /*instanceCount*/,
        uint /*firstInstance*/,
        uint /*stride*/,
        int* /*pVertexOffset*/,
        void> vkCmdDrawMultiIndexedEXT = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void>* pvkCmdDrawMultiEXT = &vkCmdDrawMultiEXT)
        {
            *pvkCmdDrawMultiEXT =
                (delegate*<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u4464\u6172\u4d77\u6c75\u6974\u5845\u0054");
        }
        fixed (delegate*<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void>* pvkCmdDrawMultiIndexedEXT = &vkCmdDrawMultiIndexedEXT)
        {
            *pvkCmdDrawMultiIndexedEXT = (delegate*<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6172\u4d77\u6c75\u6974\u6e49\u6564\u6578\u4564\u5458\u0000");
        }
    }
}