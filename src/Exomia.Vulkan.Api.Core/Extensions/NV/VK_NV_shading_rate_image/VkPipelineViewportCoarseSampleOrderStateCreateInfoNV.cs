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
///     VkPipelineViewportCoarseSampleOrderStateCreateInfoNV - Structure specifying parameters controlling sample order in
///     coarse fragments -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportCoarseSampleOrderStateCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportCoarseSampleOrderStateCreateInfoNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPipelineViewportStateCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPipelineViewportStateCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>sampleOrderType specifies the mechanism used to order coverage samples in fragments larger than one pixel.</summary>
    public VkCoarseSampleOrderTypeNV sampleOrderType;

    /// <summary>customSampleOrderCount specifies the number of custom sample orderings to use when ordering coverage samples.</summary>
    public uint customSampleOrderCount;

    /// <summary>
    ///     pCustomSampleOrders is a pointer to an array of customSampleOrderCount VkCoarseSampleOrderCustomNVstructures,
    ///     each structure specifying the coverage sample order for a single combination of fragment area and coverage sample
    ///     count.
    /// </summary>
    public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
}