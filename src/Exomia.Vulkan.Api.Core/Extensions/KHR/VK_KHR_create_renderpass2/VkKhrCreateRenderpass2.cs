#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrCreateRenderpass2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_create_renderpass2 - device extension (nr. 110) - author '' [platform '' | contact 'Tobias Hector @tobias']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_create_renderpass2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_create_renderpass2.html</a>
/// </summary>
[VkRequires("VK_KHR_multiview,VK_KHR_maintenance2")]
[Obsolete("promoted to VK_VERSION_1_2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_create_renderpass2.html#_deprecation_state")]
public static unsafe class VkKhrCreateRenderpass2
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME = "VK_KHR_create_renderpass2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u435f\u4552\u5441\u5f45\u4552\u444e\u5245\u4150\u5353\u325f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// vkCreateRenderPass2KHR alias for vkCreateRenderPass2
    /// <summary>
    ///     vkCreateRenderPass2 - Create a new render pass object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkRenderPassCreateInfo2* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkRenderPass* /*pRenderPass*/,
        VkResult> vkCreateRenderPass2KHR = null;

    /// vkCmdBeginRenderPass2KHR alias for vkCmdBeginRenderPass2
    /// <summary>
    ///     vkCmdBeginRenderPass2 - Begin a new render pass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkRenderPassBeginInfo* /*pRenderPassBegin*/,
        VkSubpassBeginInfo* /*pSubpassBeginInfo*/,
        void> vkCmdBeginRenderPass2KHR = null;

    /// vkCmdNextSubpass2KHR alias for vkCmdNextSubpass2
    /// <summary>
    ///     vkCmdNextSubpass2 - Transition to the next subpass of a render pass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkSubpassBeginInfo* /*pSubpassBeginInfo*/,
        VkSubpassEndInfo* /*pSubpassEndInfo*/,
        void> vkCmdNextSubpass2KHR = null;

    /// vkCmdEndRenderPass2KHR alias for vkCmdEndRenderPass2
    /// <summary>
    ///     vkCmdEndRenderPass2 - End the current render pass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkSubpassEndInfo* /*pSubpassEndInfo*/,
        void> vkCmdEndRenderPass2KHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult>* pvkCreateRenderPass2KHR = &vkCreateRenderPass2KHR)
        {
            *pvkCreateRenderPass2KHR = (delegate*<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6552\u646e\u7265\u6150\u7373\u4b32\u5248\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void>* pvkCmdBeginRenderPass2KHR = &vkCmdBeginRenderPass2KHR)
        {
            *pvkCmdBeginRenderPass2KHR = (delegate*<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6765\u6e69\u6552\u646e\u7265\u6150\u7373\u4b32\u5248\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void>* pvkCmdNextSubpass2KHR = &vkCmdNextSubpass2KHR)
        {
            *pvkCmdNextSubpass2KHR = (delegate*<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u4e64\u7865\u5374\u6275\u6170\u7373\u4b32\u5248\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkSubpassEndInfo*, void>* pvkCmdEndRenderPass2KHR = &vkCmdEndRenderPass2KHR)
        {
            *pvkCmdEndRenderPass2KHR = (delegate*<VkCommandBuffer, VkSubpassEndInfo*, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u4564\u646e\u6552\u646e\u7265\u6150\u7373\u4b32\u5248\u0000");
        }
    }
}