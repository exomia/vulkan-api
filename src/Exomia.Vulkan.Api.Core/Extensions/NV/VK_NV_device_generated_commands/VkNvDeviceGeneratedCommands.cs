#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvDeviceGeneratedCommands;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_device_generated_commands - device extension (nr. 278) - author 'NV' [platform '' | contact 'Christoph
///     Kubisch @pixeljetstream']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_device_generated_commands.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_device_generated_commands.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_buffer_device_address")]
public static unsafe class VkNvDeviceGeneratedCommands
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION = 3;

    /// <summary> The extension name. </summary>
    public const string VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME = "VK_NV_device_generated_commands";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4544\u4956\u4543\u475f\u4e45\u5245\u5441\u4445\u435f\u4d4f\u414d\u444e\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetGeneratedCommandsMemoryRequirementsNV - Retrieve the buffer allocation requirements for generated commands -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetGeneratedCommandsMemoryRequirementsNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetGeneratedCommandsMemoryRequirementsNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the buffer.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkGeneratedCommandsMemoryRequirementsInfoNV structure containing parameters
    ///     required for the memory requirements query.
    /// </param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirements2structure in which the
    ///     memory requirements of the buffer object are returned.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkGeneratedCommandsMemoryRequirementsInfoNV* /*pInfo*/,
        VkMemoryRequirements2* /*pMemoryRequirements*/,
        void> vkGetGeneratedCommandsMemoryRequirementsNV = null;

    /// <summary>
    ///     vkCmdPreprocessGeneratedCommandsNV - Performs preprocessing for generated commands -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer which does the preprocessing.</param>
    /// <param name="pGeneratedCommandsInfo">
    ///     pGeneratedCommandsInfo is a pointer to a VkGeneratedCommandsInfoNV structure
    ///     containing parameters affecting the preprocessing step.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkGeneratedCommandsInfoNV* /*pGeneratedCommandsInfo*/,
        void> vkCmdPreprocessGeneratedCommandsNV = null;

    /// <summary>
    ///     vkCmdExecuteGeneratedCommandsNV - Generate and execute commands on the device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="isPreprocessed">
    ///     isPreprocessed represents whether the input data has already been preprocessed on the
    ///     device. If it is VK_FALSE this command will implicitly trigger the preprocessing step, otherwise not.
    /// </param>
    /// <param name="pGeneratedCommandsInfo">
    ///     pGeneratedCommandsInfo is a pointer to a VkGeneratedCommandsInfoNV structure
    ///     containing parameters affecting the generation of commands.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*isPreprocessed*/,
        VkGeneratedCommandsInfoNV* /*pGeneratedCommandsInfo*/,
        void> vkCmdExecuteGeneratedCommandsNV = null;

    /// <summary>
    ///     vkCmdBindPipelineShaderGroupNV - Bind a pipeline object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindPipelineShaderGroupNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindPipelineShaderGroupNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the pipeline will be bound to.</param>
    /// <param name="pipelineBindPoint">
    ///     pipelineBindPoint is a VkPipelineBindPoint value specifying the bind point to which the
    ///     pipeline will be bound.
    /// </param>
    /// <param name="pipeline">pipeline is the pipeline to be bound.</param>
    /// <param name="groupIndex">groupIndex is the shader group to be bound.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPipelineBindPoint /*pipelineBindPoint*/,
        VkPipeline /*pipeline*/,
        uint /*groupIndex*/,
        void> vkCmdBindPipelineShaderGroupNV = null;

    /// <summary>
    ///     vkCreateIndirectCommandsLayoutNV - Create an indirect command layout object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectCommandsLayoutNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectCommandsLayoutNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the indirect command layout.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkIndirectCommandsLayoutCreateInfoNV structure containing
    ///     parameters affecting creation of the indirect command layout.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pIndirectCommandsLayout">
    ///     pIndirectCommandsLayout is a pointer to a VkIndirectCommandsLayoutNV handle in
    ///     which the resulting indirect command layout is returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkIndirectCommandsLayoutCreateInfoNV* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkIndirectCommandsLayoutNV* /*pIndirectCommandsLayout*/,
        VkResult> vkCreateIndirectCommandsLayoutNV = null;

    /// <summary>
    ///     vkDestroyIndirectCommandsLayoutNV - Destroy an indirect commands layout -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectCommandsLayoutNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectCommandsLayoutNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the layout.</param>
    /// <param name="indirectCommandsLayout">indirectCommandsLayout is the layout to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkIndirectCommandsLayoutNV /*indirectCommandsLayout*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyIndirectCommandsLayoutNV = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void>* pvkGetGeneratedCommandsMemoryRequirementsNV =
                   &vkGetGeneratedCommandsMemoryRequirementsNV)
        {
            *pvkGetGeneratedCommandsMemoryRequirementsNV = (delegate*<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4774\u6e65\u7265\u7461\u6465\u6f43\u6d6d\u6e61\u7364\u654d\u6f6d\u7972\u6552\u7571\u7269\u6d65\u6e65\u7374\u564e\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void>* pvkCmdPreprocessGeneratedCommandsNV = &vkCmdPreprocessGeneratedCommandsNV)
        {
            *pvkCmdPreprocessGeneratedCommandsNV = (delegate*<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5064\u6572\u7270\u636f\u7365\u4773\u6e65\u7265\u7461\u6465\u6f43\u6d6d\u6e61\u7364\u564e\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkBool32, VkGeneratedCommandsInfoNV*, void>* pvkCmdExecuteGeneratedCommandsNV = &vkCmdExecuteGeneratedCommandsNV)
        {
            *pvkCmdExecuteGeneratedCommandsNV = (delegate*<VkCommandBuffer, VkBool32, VkGeneratedCommandsInfoNV*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4564\u6578\u7563\u6574\u6547\u656e\u6172\u6574\u4364\u6d6f\u616d\u646e\u4e73\u0056");
        }
        fixed (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void>* pvkCmdBindPipelineShaderGroupNV = &vkCmdBindPipelineShaderGroupNV)
        {
            *pvkCmdBindPipelineShaderGroupNV = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u5064\u7069\u6c65\u6e69\u5365\u6168\u6564\u4772\u6f72\u7075\u564e\u0000");
        }
        fixed (delegate*<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult>* pvkCreateIndirectCommandsLayoutNV =
                   &vkCreateIndirectCommandsLayoutNV)
        {
            *pvkCreateIndirectCommandsLayoutNV = (delegate*<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6e49\u6964\u6572\u7463\u6f43\u6d6d\u6e61\u7364\u614c\u6f79\u7475\u564e\u0000");
        }
        fixed (delegate*<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void>* pvkDestroyIndirectCommandsLayoutNV = &vkDestroyIndirectCommandsLayoutNV)
        {
            *pvkDestroyIndirectCommandsLayoutNV = (delegate*<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void>)GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u4979\u646e\u7269\u6365\u4374\u6d6f\u616d\u646e\u4c73\u7961\u756f\u4e74\u0056");
        }
    }
}