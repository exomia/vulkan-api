#region License

// Copyright (c) 2018-2022, exomia
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
///     VkGeneratedCommandsMemoryRequirementsInfoNV - Structure specifying parameters for the reservation of preprocess
///     buffer space -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsMemoryRequirementsInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsMemoryRequirementsInfoNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pipelineBindPoint is the VkPipelineBindPoint of the pipeline that this buffer memory is intended to be used
    ///     with during the execution.
    /// </summary>
    public VkPipelineBindPoint pipelineBindPoint;

    /// <summary>pipeline is the VkPipeline that this buffer memory is intended to be used with during the execution.</summary>
    public VkPipeline pipeline;

    /// <summary>indirectCommandsLayout is the VkIndirectCommandsLayoutNVthat this buffer memory is intended to be used with.</summary>
    public VkIndirectCommandsLayoutNV indirectCommandsLayout;

    /// <summary>
    ///     maxSequencesCount is the maximum number of sequences that this buffer memory in combination with the other
    ///     state provided can be used with.
    /// </summary>
    public uint maxSequencesCount;
}