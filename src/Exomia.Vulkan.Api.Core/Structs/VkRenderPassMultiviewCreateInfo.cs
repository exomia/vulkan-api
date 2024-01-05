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
///     VkRenderPassMultiviewCreateInfo - Structure containing multiview information for all subpasses -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassMultiviewCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassMultiviewCreateInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkRenderPassCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderPassCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassMultiviewCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>subpassCount is zero or the number of subpasses in the render pass.</summary>
    public uint subpassCount;

    /// <summary>
    ///     pViewMasks is a pointer to an array of subpassCount view masks, where each mask is a bitfield of view indices
    ///     describing which views rendering is broadcast to in each subpass, when multiview is enabled. If subpassCount is
    ///     zero, each view mask is treated as zero.
    /// </summary>
    public uint* pViewMasks;

    /// <summary>dependencyCount is zero or the number of dependencies in the render pass.</summary>
    public uint dependencyCount;

    /// <summary>
    ///     pViewOffsets is a pointer to an array of dependencyCountview offsets, one for each dependency. If
    ///     dependencyCount is zero, each dependency&#8217;s view offset is treated as zero. Each view offset controls which
    ///     views in the source subpass the views in the destination subpass depend on.
    /// </summary>
    public int* pViewOffsets;

    /// <summary>correlationMaskCount is zero or the number of correlation masks.</summary>
    public uint correlationMaskCount;

    /// <summary>
    ///     pCorrelationMasks is a pointer to an array of correlationMaskCount view masks indicating sets of views that
    ///     maybe more efficient to render concurrently.
    /// </summary>
    public uint* pCorrelationMasks;
}