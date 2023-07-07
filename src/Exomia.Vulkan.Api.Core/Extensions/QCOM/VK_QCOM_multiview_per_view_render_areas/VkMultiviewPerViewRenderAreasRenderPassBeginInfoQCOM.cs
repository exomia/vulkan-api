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
///     VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM - Set the multiview per view render areas for a render pass
///     instance -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkRenderPassBeginInfo,VkRenderingInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderPassBeginInfo,VkRenderingInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>perViewRenderAreaCount is the number of elements in the pPerViewRenderAreas array.</summary>
    public uint perViewRenderAreaCount;

    /// <summary>pPerViewRenderAreas is a pointer to an array of VkRect2Dstructures defining the render area for each view.</summary>
    public VkRect2D* pPerViewRenderAreas;
}