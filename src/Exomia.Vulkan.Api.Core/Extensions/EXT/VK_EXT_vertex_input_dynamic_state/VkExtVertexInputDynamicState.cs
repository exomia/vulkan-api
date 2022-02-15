#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtVertexInputDynamicState;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_vertex_input_dynamic_state - device extension (nr. 353) - author 'EXT' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_vertex_input_dynamic_state.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_vertex_input_dynamic_state.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
public static unsafe class VkExtVertexInputDynamicState
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME = "VK_EXT_vertex_input_dynamic_state";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u565f\u5245\u4554\u5f58\u4e49\u5550\u5f54\u5944\u414e\u494d\u5f43\u5453\u5441\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetVertexInputEXT - Set the vertex input state dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetVertexInputEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetVertexInputEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="vertexBindingDescriptionCount">
    ///     vertexBindingDescriptionCount is the number of vertex binding descriptions
    ///     provided in pVertexBindingDescriptions.
    /// </param>
    /// <param name="pVertexBindingDescriptions">
    ///     pVertexBindingDescriptions is a pointer to an array of
    ///     VkVertexInputBindingDescription2EXT structures.
    /// </param>
    /// <param name="vertexAttributeDescriptionCount">
    ///     vertexAttributeDescriptionCount is the number of vertex attribute
    ///     descriptions provided in pVertexAttributeDescriptions.
    /// </param>
    /// <param name="pVertexAttributeDescriptions">
    ///     pVertexAttributeDescriptions is a pointer to an array of
    ///     VkVertexInputAttributeDescription2EXT structures.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*vertexBindingDescriptionCount*/,
        VkVertexInputBindingDescription2EXT* /*pVertexBindingDescriptions*/,
        uint /*vertexAttributeDescriptionCount*/,
        VkVertexInputAttributeDescription2EXT* /*pVertexAttributeDescriptions*/,
        void> vkCmdSetVertexInputEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetVertexInputEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void>* pvkCmdSetVertexInputEXT = &vkCmdSetVertexInputEXT)
        {
            *pvkCmdSetVertexInputEXT = (delegate*<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6556\u7472\u7865\u6e49\u7570\u4574\u5458\u0000");
        }
    }
}