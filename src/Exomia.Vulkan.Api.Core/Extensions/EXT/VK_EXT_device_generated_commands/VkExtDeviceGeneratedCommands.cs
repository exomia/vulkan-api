#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDeviceGeneratedCommands;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_device_generated_commands - device extension (nr. 573) - author 'EXT' [platform '' | contact 'Mike
///     Blumenkrantz @zmike']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_device_generated_commands.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_device_generated_commands.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_buffer_device_address+VK_KHR_maintenance5")]
[VkDeviceExt]
public static unsafe class VkExtDeviceGeneratedCommands
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DEVICE_GENERATED_COMMANDS_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME = "VK_EXT_device_generated_commands";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u445f\u5645\u4349\u5f45\u4547\u454e\u4152\u4554\u5f44\u4f43\u4d4d\u4e41\u5344\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetGeneratedCommandsMemoryRequirementsEXT - Retrieve the buffer allocation requirements for generated commands -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetGeneratedCommandsMemoryRequirementsEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetGeneratedCommandsMemoryRequirementsEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the buffer.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkGeneratedCommandsMemoryRequirementsInfoEXT structure containing
    ///     parameters required for the memory requirements query.
    /// </param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirements2structure in which the
    ///     memory requirements of the buffer object are returned.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkGeneratedCommandsMemoryRequirementsInfoEXT* /*pInfo*/,
        VkMemoryRequirements2* /*pMemoryRequirements*/,
        void> vkGetGeneratedCommandsMemoryRequirementsEXT = null;

    /// <summary>
    ///     vkCmdPreprocessGeneratedCommandsEXT - Performs preprocessing for generated commands -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer which does the preprocessing.</param>
    /// <param name="pGeneratedCommandsInfo">
    ///     pGeneratedCommandsInfo is a pointer to a VkGeneratedCommandsInfoEXT structure
    ///     containing parameters affecting the preprocessing step.
    /// </param>
    /// <param name="stateCommandBuffer">
    ///     stateCommandBuffer is a command buffer from which to snapshot current states affecting
    ///     the preprocessing step. When a graphics command action token is used, graphics state is snapshotted. When a compute
    ///     action command token is used, compute state is snapshotted. When a ray tracing action command token is used, ray
    ///     tracing state is snapshotted. It can be deleted at any time after this command has been recorded.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkGeneratedCommandsInfoEXT* /*pGeneratedCommandsInfo*/,
        VkCommandBuffer /*stateCommandBuffer*/,
        void> vkCmdPreprocessGeneratedCommandsEXT = null;

    /// <summary>
    ///     vkCmdExecuteGeneratedCommandsEXT - Generate and execute commands on the device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="isPreprocessed">
    ///     isPreprocessed represents whether the input data has already been preprocessed on the
    ///     device. If it is VK_FALSE this command will implicitly trigger the preprocessing step, otherwise not.
    /// </param>
    /// <param name="pGeneratedCommandsInfo">
    ///     pGeneratedCommandsInfo is a pointer to a VkGeneratedCommandsInfoEXT structure
    ///     containing parameters affecting the generation of commands.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*isPreprocessed*/,
        VkGeneratedCommandsInfoEXT* /*pGeneratedCommandsInfo*/,
        void> vkCmdExecuteGeneratedCommandsEXT = null;

    /// <summary>
    ///     vkCreateIndirectCommandsLayoutEXT - Create an indirect command layout object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectCommandsLayoutEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectCommandsLayoutEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the indirect command layout.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkIndirectCommandsLayoutCreateInfoEXT structure containing
    ///     parameters affecting creation of the indirect command layout.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pIndirectCommandsLayout">
    ///     pIndirectCommandsLayout is a pointer to a VkIndirectCommandsLayoutEXT handle in
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
        VkIndirectCommandsLayoutCreateInfoEXT* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkIndirectCommandsLayoutEXT* /*pIndirectCommandsLayout*/,
        VkResult> vkCreateIndirectCommandsLayoutEXT = null;

    /// <summary>
    ///     vkDestroyIndirectCommandsLayoutEXT - Destroy an indirect commands layout -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectCommandsLayoutEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectCommandsLayoutEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the layout.</param>
    /// <param name="indirectCommandsLayout">indirectCommandsLayout is the layout to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkIndirectCommandsLayoutEXT /*indirectCommandsLayout*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyIndirectCommandsLayoutEXT = null;

    /// <summary>
    ///     vkCreateIndirectExecutionSetEXT - Create an indirect execution set -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectExecutionSetEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectExecutionSetEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the indirect execution set.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkIndirectExecutionSetCreateInfoEXT structure containing
    ///     parameters affecting creation of the indirect execution set.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pIndirectExecutionSet">
    ///     pIndirectExecutionSet is a pointer to a VkIndirectExecutionSetEXT handle in which
    ///     the resulting indirect execution set is returned.
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
        VkIndirectExecutionSetCreateInfoEXT* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkIndirectExecutionSetEXT* /*pIndirectExecutionSet*/,
        VkResult> vkCreateIndirectExecutionSetEXT = null;

    /// <summary>
    ///     vkDestroyIndirectExecutionSetEXT - Destroy an indirect execution set -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectExecutionSetEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectExecutionSetEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the indirect execution set.</param>
    /// <param name="indirectExecutionSet">indirectExecutionSet is the indirect execution set to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkIndirectExecutionSetEXT /*indirectExecutionSet*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyIndirectExecutionSetEXT = null;

    /// <summary>
    ///     vkUpdateIndirectExecutionSetPipelineEXT - Update the contents of an indirect execution set -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateIndirectExecutionSetPipelineEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateIndirectExecutionSetPipelineEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the indirect execution set.</param>
    /// <param name="indirectExecutionSet">indirectExecutionSet is the indirect execution set being updated.</param>
    /// <param name="executionSetWriteCount">executionSetWriteCount is the number of elements in the pExecutionSetWrites array.</param>
    /// <param name="pExecutionSetWrites">
    ///     pExecutionSetWrites is a pointer to an array of
    ///     VkWriteIndirectExecutionSetPipelineEXT structures describing the elements to update.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkIndirectExecutionSetEXT /*indirectExecutionSet*/,
        uint /*executionSetWriteCount*/,
        VkWriteIndirectExecutionSetPipelineEXT* /*pExecutionSetWrites*/,
        void> vkUpdateIndirectExecutionSetPipelineEXT = null;

    /// <summary>
    ///     vkUpdateIndirectExecutionSetShaderEXT - Update the contents of an indirect execution set -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateIndirectExecutionSetShaderEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateIndirectExecutionSetShaderEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the indirect execution set.</param>
    /// <param name="indirectExecutionSet">indirectExecutionSet is the indirect execution set being updated.</param>
    /// <param name="executionSetWriteCount">executionSetWriteCount is the number of elements in the pExecutionSetWrites array.</param>
    /// <param name="pExecutionSetWrites">
    ///     pExecutionSetWrites is a pointer to an array of VkWriteIndirectExecutionSetShaderEXT
    ///     structures describing the elements to update.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkIndirectExecutionSetEXT /*indirectExecutionSet*/,
        uint /*executionSetWriteCount*/,
        VkWriteIndirectExecutionSetShaderEXT* /*pExecutionSetWrites*/,
        void> vkUpdateIndirectExecutionSetShaderEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetGeneratedCommandsMemoryRequirementsEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdPreprocessGeneratedCommandsEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdExecuteGeneratedCommandsEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCreateIndirectCommandsLayoutEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyIndirectCommandsLayoutEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCreateIndirectExecutionSetEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyIndirectExecutionSetEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkUpdateIndirectExecutionSetPipelineEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkUpdateIndirectExecutionSetShaderEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoEXT*, VkMemoryRequirements2*, void>* pvkGetGeneratedCommandsMemoryRequirementsEXT =
            &vkGetGeneratedCommandsMemoryRequirementsEXT)
        {
            *pvkGetGeneratedCommandsMemoryRequirementsEXT = (delegate*<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoEXT*, VkMemoryRequirements2*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4774\u6e65\u7265\u7461\u6465\u6f43\u6d6d\u6e61\u7364\u654d\u6f6d\u7972\u6552\u7571\u7269\u6d65\u6e65\u7374\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkGeneratedCommandsInfoEXT*, VkCommandBuffer, void>* pvkCmdPreprocessGeneratedCommandsEXT = &vkCmdPreprocessGeneratedCommandsEXT)
        {
            *pvkCmdPreprocessGeneratedCommandsEXT = (delegate*<VkCommandBuffer, VkGeneratedCommandsInfoEXT*, VkCommandBuffer, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5064\u6572\u7270\u636f\u7365\u4773\u6e65\u7265\u7461\u6465\u6f43\u6d6d\u6e61\u7364\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, VkGeneratedCommandsInfoEXT*, void>* pvkCmdExecuteGeneratedCommandsEXT = &vkCmdExecuteGeneratedCommandsEXT)
        {
            *pvkCmdExecuteGeneratedCommandsEXT = (delegate*<VkCommandBuffer, VkBool32, VkGeneratedCommandsInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4564\u6578\u7563\u6574\u6547\u656e\u6172\u6574\u4364\u6d6f\u616d\u646e\u4573\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkIndirectCommandsLayoutCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectCommandsLayoutEXT*, VkResult>* pvkCreateIndirectCommandsLayoutEXT =
            &vkCreateIndirectCommandsLayoutEXT)
        {
            *pvkCreateIndirectCommandsLayoutEXT = (delegate*<VkDevice, VkIndirectCommandsLayoutCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectCommandsLayoutEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6e49\u6964\u6572\u7463\u6f43\u6d6d\u6e61\u7364\u614c\u6f79\u7475\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkIndirectCommandsLayoutEXT, VkAllocationCallbacks*, void>* pvkDestroyIndirectCommandsLayoutEXT = &vkDestroyIndirectCommandsLayoutEXT)
        {
            *pvkDestroyIndirectCommandsLayoutEXT = (delegate*<VkDevice, VkIndirectCommandsLayoutEXT, VkAllocationCallbacks*, void>)GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u4979\u646e\u7269\u6365\u4374\u6d6f\u616d\u646e\u4c73\u7961\u756f\u4574\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkIndirectExecutionSetCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectExecutionSetEXT*, VkResult>* pvkCreateIndirectExecutionSetEXT =
            &vkCreateIndirectExecutionSetEXT)
        {
            *pvkCreateIndirectExecutionSetEXT = (delegate*<VkDevice, VkIndirectExecutionSetCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectExecutionSetEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6e49\u6964\u6572\u7463\u7845\u6365\u7475\u6f69\u536e\u7465\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkIndirectExecutionSetEXT, VkAllocationCallbacks*, void>* pvkDestroyIndirectExecutionSetEXT = &vkDestroyIndirectExecutionSetEXT)
        {
            *pvkDestroyIndirectExecutionSetEXT = (delegate*<VkDevice, VkIndirectExecutionSetEXT, VkAllocationCallbacks*, void>)GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u4979\u646e\u7269\u6365\u4574\u6578\u7563\u6974\u6e6f\u6553\u4574\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetPipelineEXT*, void>* pvkUpdateIndirectExecutionSetPipelineEXT = &vkUpdateIndirectExecutionSetPipelineEXT)
        {
            *pvkUpdateIndirectExecutionSetPipelineEXT = (delegate*<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetPipelineEXT*, void>)GetVkFunction(
                device, "\u6b76\u7055\u6164\u6574\u6e49\u6964\u6572\u7463\u7845\u6365\u7475\u6f69\u536e\u7465\u6950\u6570\u696c\u656e\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetShaderEXT*, void>* pvkUpdateIndirectExecutionSetShaderEXT = &vkUpdateIndirectExecutionSetShaderEXT)
        {
            *pvkUpdateIndirectExecutionSetShaderEXT = (delegate*<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetShaderEXT*, void>)GetVkFunction(
                device, "\u6b76\u7055\u6164\u6574\u6e49\u6964\u6572\u7463\u7845\u6365\u7475\u6f69\u536e\u7465\u6853\u6461\u7265\u5845\u0054");
        }
    }
}