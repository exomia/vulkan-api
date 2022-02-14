#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvMeshShader;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_mesh_shader - device extension (nr. 203) - author 'NV' [platform '' | contact 'Christoph Kubisch
///     @pixeljetstream']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_mesh_shader.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_mesh_shader.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
public static unsafe class VkNvMeshShader
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_MESH_SHADER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_MESH_SHADER_EXTENSION_NAME = "VK_NV_mesh_shader";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_MESH_SHADER_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_MESH_SHADER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_MESH_SHADER_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u454d\u4853\u535f\u4148\u4544\u5f52\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdDrawMeshTasksNV - Draw mesh task work items -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="taskCount">
    ///     taskCount is the number of local workgroups to dispatch in the X dimension. Y and Z dimension
    ///     are implicitly set to one.
    /// </param>
    /// <param name="firstTask">firstTask is the X component of the first workgroup ID.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*taskCount*/,
        uint /*firstTask*/,
        void> vkCmdDrawMeshTasksNV = null;

    /// <summary>
    ///     vkCmdDrawMeshTasksIndirectNV - Issue an indirect mesh tasks draw into a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectNV.html</a>
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
        void> vkCmdDrawMeshTasksIndirectNV = null;

    /// <summary>
    ///     vkCmdDrawMeshTasksIndirectCountNV - Perform an indirect mesh tasks draw with the draw count sourced from a
    ///     buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountNV.html
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
        void> vkCmdDrawMeshTasksIndirectCountNV = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with in fallback case. </param>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance, VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, uint, void>* pvkCmdDrawMeshTasksNV = &vkCmdDrawMeshTasksNV)
        {
            *pvkCmdDrawMeshTasksNV = (delegate*<VkCommandBuffer, uint, uint, void>)Core.Vk.GetVkFunction(instance, device, "\u6b76\u6d43\u4464\u6172\u4d77\u7365\u5468\u7361\u736b\u564e\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void>* pvkCmdDrawMeshTasksIndirectNV = &vkCmdDrawMeshTasksIndirectNV)
        {
            *pvkCmdDrawMeshTasksIndirectNV = (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6d43\u4464\u6172\u4d77\u7365\u5468\u7361\u736b\u6e49\u6964\u6572\u7463\u564e\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>* pvkCmdDrawMeshTasksIndirectCountNV = &vkCmdDrawMeshTasksIndirectCountNV)
        {
            *pvkCmdDrawMeshTasksIndirectCountNV = (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6d43\u4464\u6172\u4d77\u7365\u5468\u7361\u736b\u6e49\u6964\u6572\u7463\u6f43\u6e75\u4e74\u0056");
        }
    }
}