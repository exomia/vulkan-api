#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtExtendedDynamicState;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_extended_dynamic_state - device extension (nr. 268) - author 'EXT' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_extended_dynamic_state.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_extended_dynamic_state.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_extended_dynamic_state.html#_deprecation_state")]
public static unsafe class VkExtExtendedDynamicState
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME = "VK_EXT_extended_dynamic_state";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u455f\u5458\u4e45\u4544\u5f44\u5944\u414e\u494d\u5f43\u5453\u5441\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkCmdSetCullModeEXT alias for vkCmdSetCullMode
    /// <summary>
    ///     vkCmdSetCullMode - Set cull mode dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullModeEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCullModeFlags /*cullMode*/,
        void> vkCmdSetCullModeEXT = null;

    /// vkCmdSetFrontFaceEXT alias for vkCmdSetFrontFace
    /// <summary>
    ///     vkCmdSetFrontFace - Set front face orientation dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFaceEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFaceEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkFrontFace /*frontFace*/,
        void> vkCmdSetFrontFaceEXT = null;

    /// vkCmdSetPrimitiveTopologyEXT alias for vkCmdSetPrimitiveTopology
    /// <summary>
    ///     vkCmdSetPrimitiveTopology - Set primitive topology state dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopologyEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopologyEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPrimitiveTopology /*primitiveTopology*/,
        void> vkCmdSetPrimitiveTopologyEXT = null;

    /// vkCmdSetViewportWithCountEXT alias for vkCmdSetViewportWithCount
    /// <summary>
    ///     vkCmdSetViewportWithCount - Set the viewport count and viewports dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCountEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCountEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*viewportCount*/,
        VkViewport* /*pViewports*/,
        void> vkCmdSetViewportWithCountEXT = null;

    /// vkCmdSetScissorWithCountEXT alias for vkCmdSetScissorWithCount
    /// <summary>
    ///     vkCmdSetScissorWithCount - Set the scissor count and scissor rectangular bounds dynamically for a command
    ///     buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCountEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCountEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*scissorCount*/,
        VkRect2D* /*pScissors*/,
        void> vkCmdSetScissorWithCountEXT = null;

    /// vkCmdBindVertexBuffers2EXT alias for vkCmdBindVertexBuffers2
    /// <summary>
    ///     vkCmdBindVertexBuffers2 - Bind vertex buffers to a command buffer and dynamically set strides -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2EXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2EXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstBinding*/,
        uint /*bindingCount*/,
        VkBuffer* /*pBuffers*/,
        VkDeviceSize* /*pOffsets*/,
        VkDeviceSize* /*pSizes*/,
        VkDeviceSize* /*pStrides*/,
        void> vkCmdBindVertexBuffers2EXT = null;

    /// vkCmdSetDepthTestEnableEXT alias for vkCmdSetDepthTestEnable
    /// <summary>
    ///     vkCmdSetDepthTestEnable - Set depth test enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnableEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthTestEnable*/,
        void> vkCmdSetDepthTestEnableEXT = null;

    /// vkCmdSetDepthWriteEnableEXT alias for vkCmdSetDepthWriteEnable
    /// <summary>
    ///     vkCmdSetDepthWriteEnable - Set depth write enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnableEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthWriteEnable*/,
        void> vkCmdSetDepthWriteEnableEXT = null;

    /// vkCmdSetDepthCompareOpEXT alias for vkCmdSetDepthCompareOp
    /// <summary>
    ///     vkCmdSetDepthCompareOp - Set depth comparison operator dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOpEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOpEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCompareOp /*depthCompareOp*/,
        void> vkCmdSetDepthCompareOpEXT = null;

    /// vkCmdSetDepthBoundsTestEnableEXT alias for vkCmdSetDepthBoundsTestEnable
    /// <summary>
    ///     vkCmdSetDepthBoundsTestEnable - Set depth bounds test enable dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnableEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnableEXT.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthBoundsTestEnable*/,
        void> vkCmdSetDepthBoundsTestEnableEXT = null;

    /// vkCmdSetStencilTestEnableEXT alias for vkCmdSetStencilTestEnable
    /// <summary>
    ///     vkCmdSetStencilTestEnable - Set stencil test enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnableEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*stencilTestEnable*/,
        void> vkCmdSetStencilTestEnableEXT = null;

    /// vkCmdSetStencilOpEXT alias for vkCmdSetStencilOp
    /// <summary>
    ///     vkCmdSetStencilOp - Set stencil operation dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOpEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOpEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkStencilFaceFlags /*faceMask*/,
        VkStencilOp /*failOp*/,
        VkStencilOp /*passOp*/,
        VkStencilOp /*depthFailOp*/,
        VkCompareOp /*compareOp*/,
        void> vkCmdSetStencilOpEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetCullModeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetFrontFaceEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetPrimitiveTopologyEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetViewportWithCountEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetScissorWithCountEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBindVertexBuffers2EXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthTestEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthWriteEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthCompareOpEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthBoundsTestEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetStencilTestEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetStencilOpEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkCullModeFlags, void>* pvkCmdSetCullModeEXT = &vkCmdSetCullModeEXT)
        {
            *pvkCmdSetCullModeEXT = (delegate*<VkCommandBuffer, VkCullModeFlags, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u7543\u6c6c\u6f4d\u6564\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkFrontFace, void>* pvkCmdSetFrontFaceEXT = &vkCmdSetFrontFaceEXT)
        {
            *pvkCmdSetFrontFaceEXT = (delegate*<VkCommandBuffer, VkFrontFace, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u7246\u6e6f\u4674\u6361\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkPrimitiveTopology, void>* pvkCmdSetPrimitiveTopologyEXT = &vkCmdSetPrimitiveTopologyEXT)
        {
            *pvkCmdSetPrimitiveTopologyEXT = (delegate*<VkCommandBuffer, VkPrimitiveTopology, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7250\u6d69\u7469\u7669\u5465\u706f\u6c6f\u676f\u4579\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkViewport*, void>* pvkCmdSetViewportWithCountEXT = &vkCmdSetViewportWithCountEXT)
        {
            *pvkCmdSetViewportWithCountEXT = (delegate*<VkCommandBuffer, uint, VkViewport*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6956\u7765\u6f70\u7472\u6957\u6874\u6f43\u6e75\u4574\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkRect2D*, void>* pvkCmdSetScissorWithCountEXT = &vkCmdSetScissorWithCountEXT)
        {
            *pvkCmdSetScissorWithCountEXT = (delegate*<VkCommandBuffer, uint, VkRect2D*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6353\u7369\u6f73\u5772\u7469\u4368\u756f\u746e\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void>* pvkCmdBindVertexBuffers2EXT = &vkCmdBindVertexBuffers2EXT)
        {
            *pvkCmdBindVertexBuffers2EXT = (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u5664\u7265\u6574\u4278\u6675\u6566\u7372\u4532\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthTestEnableEXT = &vkCmdSetDepthTestEnableEXT)
        {
            *pvkCmdSetDepthTestEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u5468\u7365\u4574\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthWriteEnableEXT = &vkCmdSetDepthWriteEnableEXT)
        {
            *pvkCmdSetDepthWriteEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u5768\u6972\u6574\u6e45\u6261\u656c\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkCompareOp, void>* pvkCmdSetDepthCompareOpEXT = &vkCmdSetDepthCompareOpEXT)
        {
            *pvkCmdSetDepthCompareOpEXT = (delegate*<VkCommandBuffer, VkCompareOp, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4368\u6d6f\u6170\u6572\u704f\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthBoundsTestEnableEXT = &vkCmdSetDepthBoundsTestEnableEXT)
        {
            *pvkCmdSetDepthBoundsTestEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4268\u756f\u646e\u5473\u7365\u4574\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetStencilTestEnableEXT = &vkCmdSetStencilTestEnableEXT)
        {
            *pvkCmdSetStencilTestEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7453\u6e65\u6963\u546c\u7365\u4574\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void>* pvkCmdSetStencilOpEXT = &vkCmdSetStencilOpEXT)
        {
            *pvkCmdSetStencilOpEXT =
                (delegate*<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void>)Core.Vk.GetVkFunction(
                    device, "\u6b76\u6d43\u5364\u7465\u7453\u6e65\u6963\u4f6c\u4570\u5458\u0000");
        }
    }
}