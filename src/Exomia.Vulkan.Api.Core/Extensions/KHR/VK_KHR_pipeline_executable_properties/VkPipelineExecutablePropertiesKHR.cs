#region License

// Copyright (c) 2018-2023, exomia
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
///     VkPipelineExecutablePropertiesKHR - Structure describing a pipeline executable -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutablePropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutablePropertiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutablePropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stages is a bitmask of zero or more VkShaderStageFlagBitsindicating which shader stages (if any) were
    ///     principally used as inputs to compile this pipeline executable.
    /// </summary>
    public VkShaderStageFlags stages;

    /// <summary>
    ///     name is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which is a short
    ///     human readable name for this pipeline executable.
    /// </summary>
    public fixed byte name[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>
    ///     description is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which is a
    ///     human readable description for this pipeline executable.
    /// </summary>
    public fixed byte description[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>subgroupSize is the subgroup size with which this pipeline executable is dispatched.</summary>
    public uint subgroupSize;
}