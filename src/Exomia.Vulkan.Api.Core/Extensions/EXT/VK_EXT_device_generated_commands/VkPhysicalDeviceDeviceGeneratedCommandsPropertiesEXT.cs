#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT - Structure describing push descriptor limits that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary> maxIndirectPipelineCount is the maximum number of pipelines passed to vkCreateIndirectExecutionSetEXT.</summary>
    public uint maxIndirectPipelineCount;

    /// <summary>
    ///     maxIndirectShaderObjectCount is the maximum number of shader objects passed to
    ///     vkCreateIndirectExecutionSetEXT. If this value is zero, binding shader objects indirectly is not supported.
    /// </summary>
    public uint maxIndirectShaderObjectCount;

    /// <summary>
    ///     maxIndirectSequenceCount is the maximum number of sequences in VkGeneratedCommandsInfoEXT and in
    ///     VkGeneratedCommandsMemoryRequirementsInfoEXT.
    /// </summary>
    public uint maxIndirectSequenceCount;

    /// <summary>maxIndirectCommandsTokenCount is the maximum number of tokens in VkIndirectCommandsLayoutCreateInfoEXT.</summary>
    public uint maxIndirectCommandsTokenCount;

    /// <summary>maxIndirectCommandsTokenOffset is the maximum offset in VkIndirectCommandsLayoutTokenEXT.</summary>
    public uint maxIndirectCommandsTokenOffset;

    /// <summary>maxIndirectCommandsIndirectStride is the maximum stream stride in VkIndirectCommandsLayoutCreateInfoEXT.</summary>
    public uint maxIndirectCommandsIndirectStride;

    /// <summary>supportedIndirectCommandsInputModes indicates the supported input modes.</summary>
    public VkIndirectCommandsInputModeFlagsEXT supportedIndirectCommandsInputModes;

    /// <summary>
    ///     supportedIndirectCommandsShaderStages indicates the stages which can be used to generate indirect commands.
    ///     Implementations are required to support, at minimum: VK_SHADER_STAGE_VERTEX_BIT, VK_SHADER_STAGE_FRAGMENT_BIT,
    ///     VK_SHADER_STAGE_COMPUTE_BIT.
    /// </summary>
    public VkShaderStageFlags supportedIndirectCommandsShaderStages;

    /// <summary>
    ///     supportedIndirectCommandsShaderStagesPipelineBinding indicates the stages which can be used within indirect
    ///     execution sets for indirectly binding shader stages using pipelines.
    /// </summary>
    public VkShaderStageFlags supportedIndirectCommandsShaderStagesPipelineBinding;

    /// <summary>
    ///     supportedIndirectCommandsShaderStagesShaderBinding indicates the stages which can be used within indirect
    ///     execution sets for indirectly binding shader stages using shader objects.
    /// </summary>
    public VkShaderStageFlags supportedIndirectCommandsShaderStagesShaderBinding;

    /// <summary>
    ///     deviceGeneratedCommandsTransformFeedback indicates whether the implementation supports interactions with
    ///     VK_EXT_transform_feedback for pipelines not created with VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_EXT.
    /// </summary>
    public VkBool32 deviceGeneratedCommandsTransformFeedback;

    /// <summary>
    ///     deviceGeneratedCommandsMultiDrawIndirectCount indicates whether the implementation supports COUNT variants of
    ///     multi-draw indirect tokens.
    /// </summary>
    public VkBool32 deviceGeneratedCommandsMultiDrawIndirectCount;
}