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
///     VkPipelineCoverageModulationStateCreateInfoNV - Structure specifying parameters controlling coverage modulation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCoverageModulationStateCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCoverageModulationStateCreateInfoNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPipelineMultisampleStateCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPipelineMultisampleStateCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkPipelineCoverageModulationStateCreateFlagsNV flags;

    /// <summary>coverageModulationMode is a VkCoverageModulationModeNV value controlling which color components are modulated.</summary>
    public VkCoverageModulationModeNV coverageModulationMode;

    /// <summary>
    ///     coverageModulationTableEnable controls whether the modulation factor is looked up from a table in
    ///     pCoverageModulationTable.
    /// </summary>
    public VkBool32 coverageModulationTableEnable;

    /// <summary>coverageModulationTableCount is the number of elements in pCoverageModulationTable.</summary>
    public uint coverageModulationTableCount;

    /// <summary>
    ///     pCoverageModulationTable is a table of modulation factors containing a value for each number of covered
    ///     samples.
    /// </summary>
    public float* pCoverageModulationTable;
}