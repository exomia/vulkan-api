#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtConditionalRendering;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_conditional_rendering - device extension (nr. 82) - author 'NV' [platform '' | contact 'Vikram Kushwaha
///     @vkushwaha']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_conditional_rendering.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_conditional_rendering.html</a>
/// </summary>
public static unsafe class VkExtConditionalRendering
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME = "VK_EXT_conditional_rendering";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u435f\u4e4f\u4944\u4954\u4e4f\u4c41\u525f\u4e45\u4544\u4952\u474e\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdBeginConditionalRenderingEXT - Define the beginning of a conditional rendering block -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginConditionalRenderingEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginConditionalRenderingEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which this command will be recorded.</param>
    /// <param name="pConditionalRenderingBegin">
    ///     pConditionalRenderingBegin is a pointer to a
    ///     VkConditionalRenderingBeginInfoEXT structure specifying parameters of conditional rendering.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkConditionalRenderingBeginInfoEXT* /*pConditionalRenderingBegin*/,
        void> vkCmdBeginConditionalRenderingEXT = null;

    /// <summary>
    ///     vkCmdEndConditionalRenderingEXT - Define the end of a conditional rendering block -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndConditionalRenderingEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndConditionalRenderingEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which this command will be recorded.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        void> vkCmdEndConditionalRenderingEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdBeginConditionalRenderingEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdEndConditionalRenderingEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void>* pvkCmdBeginConditionalRenderingEXT = &vkCmdBeginConditionalRenderingEXT)
        {
            *pvkCmdBeginConditionalRenderingEXT = (delegate*<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6765\u6e69\u6f43\u646e\u7469\u6f69\u616e\u526c\u6e65\u6564\u6972\u676e\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, void>* pvkCmdEndConditionalRenderingEXT = &vkCmdEndConditionalRenderingEXT)
        {
            *pvkCmdEndConditionalRenderingEXT = (delegate*<VkCommandBuffer, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u4564\u646e\u6f43\u646e\u7469\u6f69\u616e\u526c\u6e65\u6564\u6972\u676e\u5845\u0054");
        }
    }
}