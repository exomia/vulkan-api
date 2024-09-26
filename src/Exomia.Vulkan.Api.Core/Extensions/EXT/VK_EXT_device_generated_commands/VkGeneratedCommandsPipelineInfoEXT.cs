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
///     VkGeneratedCommandsPipelineInfoEXT - Structure specifying a pipeline for use with indirect command
///     preprocessing -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsPipelineInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsPipelineInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkGeneratedCommandsInfoEXT,VkGeneratedCommandsMemoryRequirementsInfoEXT</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGeneratedCommandsInfoEXT,VkGeneratedCommandsMemoryRequirementsInfoEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsPipelineInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GENERATED_COMMANDS_PIPELINE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>pipeline is a valid pipeline object.</summary>
    public VkPipeline pipeline;
}