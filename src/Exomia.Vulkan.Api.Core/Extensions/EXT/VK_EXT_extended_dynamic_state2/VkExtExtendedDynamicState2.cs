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
///     VK_EXT_extended_dynamic_state2 - device extension (nr. 378) - author 'EXT' [platform '' | contact 'Vikram Kushwaha
///     @vkushwaha-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_extended_dynamic_state2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_extended_dynamic_state2.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_extended_dynamic_state2.html#_deprecation_state")]
public static unsafe class VkExtExtendedDynamicState2
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME = "VK_EXT_extended_dynamic_state2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u455f\u5458\u4e45\u4544\u5f44\u5944\u414e\u494d\u5f43\u5453\u5441\u5f45\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetPatchControlPointsEXT - Specify the number of control points per patch dynamically for a command
    ///     buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPatchControlPointsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPatchControlPointsEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="patchControlPoints">patchControlPoints specifies the number of control points per patch.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*patchControlPoints*/,
        void> vkCmdSetPatchControlPointsEXT = null;

    /// vkCmdSetRasterizerDiscardEnableEXT alias for vkCmdSetRasterizerDiscardEnable
    /// <summary>
    ///     vkCmdSetRasterizerDiscardEnable - Control whether primitives are discarded before the rasterization stage
    ///     dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnableEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnableEXT.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*rasterizerDiscardEnable*/,
        void> vkCmdSetRasterizerDiscardEnableEXT = null;

    /// vkCmdSetDepthBiasEnableEXT alias for vkCmdSetDepthBiasEnable
    /// <summary>
    ///     vkCmdSetDepthBiasEnable - Control whether to bias fragment depth values dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnableEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthBiasEnable*/,
        void> vkCmdSetDepthBiasEnableEXT = null;

    /// <summary>
    ///     vkCmdSetLogicOpEXT - Select which logical operation to apply for blend state dynamically for a command buffer
    ///     -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="logicOp">logicOp specifies the logical operation to apply for blend state.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkLogicOp /*logicOp*/,
        void> vkCmdSetLogicOpEXT = null;

    /// vkCmdSetPrimitiveRestartEnableEXT alias for vkCmdSetPrimitiveRestartEnable
    /// <summary>
    ///     vkCmdSetPrimitiveRestartEnable - Set primitive assembly restart state dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnableEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnableEXT.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*primitiveRestartEnable*/,
        void> vkCmdSetPrimitiveRestartEnableEXT = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, void>* pvkCmdSetPatchControlPointsEXT = &vkCmdSetPatchControlPointsEXT)
        {
            *pvkCmdSetPatchControlPointsEXT = (delegate*<VkCommandBuffer, uint, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6150\u6374\u4368\u6e6f\u7274\u6c6f\u6f50\u6e69\u7374\u5845\u0054");
        }
        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetRasterizerDiscardEnableEXT = &vkCmdSetRasterizerDiscardEnableEXT)
        {
            *pvkCmdSetRasterizerDiscardEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6152\u7473\u7265\u7a69\u7265\u6944\u6373\u7261\u4564\u616e\u6c62\u4565\u5458\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthBiasEnableEXT = &vkCmdSetDepthBiasEnableEXT)
        {
            *pvkCmdSetDepthBiasEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4268\u6169\u4573\u616e\u6c62\u4565\u5458\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkLogicOp, void>* pvkCmdSetLogicOpEXT = &vkCmdSetLogicOpEXT)
        {
            *pvkCmdSetLogicOpEXT = (delegate*<VkCommandBuffer, VkLogicOp, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6f4c\u6967\u4f63\u4570\u5458\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetPrimitiveRestartEnableEXT = &vkCmdSetPrimitiveRestartEnableEXT)
        {
            *pvkCmdSetPrimitiveRestartEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7250\u6d69\u7469\u7669\u5265\u7365\u6174\u7472\u6e45\u6261\u656c\u5845\u0054");
        }
    }
}