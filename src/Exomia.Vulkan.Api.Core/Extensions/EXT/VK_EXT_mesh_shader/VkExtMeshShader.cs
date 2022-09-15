#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtMeshShader;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_mesh_shader - device extension (nr. 329) - author 'EXT' [platform '' | contact 'Christoph Kubisch
///     @pixeljetstream']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_mesh_shader.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_mesh_shader.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2,VK_KHR_spirv_1_4")]
public static unsafe class VkExtMeshShader
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_MESH_SHADER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_MESH_SHADER_EXTENSION_NAME = "VK_EXT_mesh_shader";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_MESH_SHADER_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_MESH_SHADER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_MESH_SHADER_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u4d5f\u5345\u5f48\u4853\u4441\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdDrawMeshTasksEXT - Draw mesh task work items -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="groupCountX">groupCountX is the number of local workgroups to dispatch in the X dimension.</param>
    /// <param name="groupCountY">groupCountY is the number of local workgroups to dispatch in the Y dimension.</param>
    /// <param name="groupCountZ">groupCountZ is the number of local workgroups to dispatch in the Z dimension.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*groupCountX*/,
        uint /*groupCountY*/,
        uint /*groupCountZ*/,
        void> vkCmdDrawMeshTasksEXT = null;

    /// <summary>
    ///     vkCmdDrawMeshTasksIndirectEXT - Issue an indirect mesh tasks draw into a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="buffer">buffer is the buffer containing draw parameters.</param>
    /// <param name="offset">offset is the byte offset into buffer where parameters begin.</param>
    /// <param name="drawCount">drawCount is the number of draws to execute, and can be zero.</param>
    /// <param name="stride">stride is the byte stride between successive sets of draw parameters.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBuffer /*buffer*/,
        VkDeviceSize /*offset*/,
        uint /*drawCount*/,
        uint /*stride*/,
        void> vkCmdDrawMeshTasksIndirectEXT = null;

    /// <summary>
    ///     vkCmdDrawMeshTasksIndirectCountEXT - Perform an indirect mesh tasks draw with the draw count sourced from a
    ///     buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="buffer">buffer is the buffer containing draw parameters.</param>
    /// <param name="offset">offset is the byte offset into buffer where parameters begin.</param>
    /// <param name="countBuffer">countBuffer is the buffer containing the draw count.</param>
    /// <param name="countBufferOffset">countBufferOffset is the byte offset into countBuffer where the draw count begins.</param>
    /// <param name="maxDrawCount">
    ///     maxDrawCount specifies the maximum number of draws that will be executed. The actual number
    ///     of executed draw calls is the minimum of the count specified in countBuffer and maxDrawCount.
    /// </param>
    /// <param name="stride">stride is the byte stride between successive sets of draw parameters.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBuffer /*buffer*/,
        VkDeviceSize /*offset*/,
        VkBuffer /*countBuffer*/,
        VkDeviceSize /*countBufferOffset*/,
        uint /*maxDrawCount*/,
        uint /*stride*/,
        void> vkCmdDrawMeshTasksIndirectCountEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdDrawMeshTasksEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDrawMeshTasksIndirectEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDrawMeshTasksIndirectCountEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, uint, uint, void>* pvkCmdDrawMeshTasksEXT = &vkCmdDrawMeshTasksEXT)
        {
            *pvkCmdDrawMeshTasksEXT = (delegate*<VkCommandBuffer, uint, uint, uint, void>)GetVkFunction(device, "\u6b76\u6d43\u4464\u6172\u4d77\u7365\u5468\u7361\u736b\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void>* pvkCmdDrawMeshTasksIndirectEXT = &vkCmdDrawMeshTasksIndirectEXT)
        {
            *pvkCmdDrawMeshTasksIndirectEXT = (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6172\u4d77\u7365\u5468\u7361\u736b\u6e49\u6964\u6572\u7463\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>* pvkCmdDrawMeshTasksIndirectCountEXT = &vkCmdDrawMeshTasksIndirectCountEXT)
        {
            *pvkCmdDrawMeshTasksIndirectCountEXT = (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6172\u4d77\u7365\u5468\u7361\u736b\u6e49\u6964\u6572\u7463\u6f43\u6e75\u4574\u5458\u0000");
        }
    }
}