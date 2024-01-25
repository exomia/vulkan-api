#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvDeviceGeneratedCommandsCompute;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_device_generated_commands_compute - device extension (nr. 429) - author 'NV' [platform '' | contact 'Vikram
///     Kushwaha @vkushwaha-nv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_device_generated_commands_compute.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_device_generated_commands_compute.html
///     </a>
/// </summary>
[VkDepends("VK_NV_device_generated_commands")]
[VkDeviceExt]
public static unsafe class VkNvDeviceGeneratedCommandsCompute
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_EXTENSION_NAME = "VK_NV_device_generated_commands_compute";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4544\u4956\u4543\u475f\u4e45\u5245\u5441\u4445\u435f\u4d4f\u414d\u444e\u5f53\u4f43\u504d\u5455\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetPipelineIndirectMemoryRequirementsNV - Get the memory requirements for the compute indirect pipeline -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineIndirectMemoryRequirementsNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineIndirectMemoryRequirementsNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the buffer.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a VkComputePipelineCreateInfo structure specifying the creation parameters of
    ///     the compute pipeline whose memory requirements are being queried.
    /// </param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirements2structure in which the
    ///     requested pipeline&#8217;s memory requirements are returned.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkComputePipelineCreateInfo* /*pCreateInfo*/,
        VkMemoryRequirements2* /*pMemoryRequirements*/,
        void> vkGetPipelineIndirectMemoryRequirementsNV = null;

    /// <summary>
    ///     vkCmdUpdatePipelineIndirectBufferNV - Update the indirect compute pipeline's metadata -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdUpdatePipelineIndirectBufferNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdUpdatePipelineIndirectBufferNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pipelineBindPoint">
    ///     pipelineBindPoint is a VkPipelineBindPoint value specifying the type of pipeline whose
    ///     metadata will be saved.
    /// </param>
    /// <param name="pipeline">pipeline is the pipeline whose metadata will be saved.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPipelineBindPoint /*pipelineBindPoint*/,
        VkPipeline /*pipeline*/,
        void> vkCmdUpdatePipelineIndirectBufferNV = null;

    /// <summary>
    ///     vkGetPipelineIndirectDeviceAddressNV - Get pipeline's 64-bit device address -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineIndirectDeviceAddressNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineIndirectDeviceAddressNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device on which the pipeline was created.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkPipelineIndirectDeviceAddressInfoNV structure specifying the pipeline to
    ///     retrieve the address for.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineIndirectDeviceAddressInfoNV* /*pInfo*/,
        VkDeviceAddress> vkGetPipelineIndirectDeviceAddressNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPipelineIndirectMemoryRequirementsNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdUpdatePipelineIndirectBufferNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPipelineIndirectDeviceAddressNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void>* pvkGetPipelineIndirectMemoryRequirementsNV = &vkGetPipelineIndirectMemoryRequirementsNV)
        {
            *pvkGetPipelineIndirectMemoryRequirementsNV = (delegate*<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7069\u6c65\u6e69\u4965\u646e\u7269\u6365\u4d74\u6d65\u726f\u5279\u7165\u6975\u6572\u656d\u746e\u4e73\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>* pvkCmdUpdatePipelineIndirectBufferNV = &vkCmdUpdatePipelineIndirectBufferNV)
        {
            *pvkCmdUpdatePipelineIndirectBufferNV = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5564\u6470\u7461\u5065\u7069\u6c65\u6e69\u4965\u646e\u7269\u6365\u4274\u6675\u6566\u4e72\u0056");
        }

        fixed (delegate*<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, VkDeviceAddress>* pvkGetPipelineIndirectDeviceAddressNV = &vkGetPipelineIndirectDeviceAddressNV)
        {
            *pvkGetPipelineIndirectDeviceAddressNV = (delegate*<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, VkDeviceAddress>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7069\u6c65\u6e69\u4965\u646e\u7269\u6365\u4474\u7665\u6369\u4165\u6464\u6572\u7373\u564e\u0000");
        }
    }
}