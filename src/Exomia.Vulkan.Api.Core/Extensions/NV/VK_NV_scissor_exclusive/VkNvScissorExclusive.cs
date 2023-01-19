#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvScissorExclusive;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_scissor_exclusive - device extension (nr. 206) - author 'NV' [platform '' | contact 'Pat Brown @nvpbrown']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_scissor_exclusive.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_scissor_exclusive.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
public static unsafe class VkNvScissorExclusive
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME = "VK_NV_scissor_exclusive";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4353\u5349\u4f53\u5f52\u5845\u4c43\u5355\u5649\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetExclusiveScissorNV - Set exclusive scissor rectangles dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetExclusiveScissorNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetExclusiveScissorNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstExclusiveScissor">
    ///     firstExclusiveScissor is the index of the first exclusive scissor rectangle whose
    ///     state is updated by the command.
    /// </param>
    /// <param name="exclusiveScissorCount">
    ///     exclusiveScissorCount is the number of exclusive scissor rectangles updated by the
    ///     command.
    /// </param>
    /// <param name="pExclusiveScissors">
    ///     pExclusiveScissors is a pointer to an array of VkRect2Dstructures defining exclusive
    ///     scissor rectangles.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstExclusiveScissor*/,
        uint /*exclusiveScissorCount*/,
        VkRect2D* /*pExclusiveScissors*/,
        void> vkCmdSetExclusiveScissorNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetExclusiveScissorNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, uint, VkRect2D*, void>* pvkCmdSetExclusiveScissorNV = &vkCmdSetExclusiveScissorNV)
        {
            *pvkCmdSetExclusiveScissorNV = (delegate*<VkCommandBuffer, uint, uint, VkRect2D*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7845\u6c63\u7375\u7669\u5365\u6963\u7373\u726f\u564e\u0000");
        }
    }
}