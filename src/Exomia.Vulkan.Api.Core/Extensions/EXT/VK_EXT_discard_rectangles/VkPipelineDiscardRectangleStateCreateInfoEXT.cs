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
///     VkPipelineDiscardRectangleStateCreateInfoEXT - Structure specifying discard rectangle -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDiscardRectangleStateCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDiscardRectangleStateCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkGraphicsPipelineCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGraphicsPipelineCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;

    /// <summary>
    ///     discardRectangleMode is a VkDiscardRectangleModeEXT value determining whether the discard rectangle test is
    ///     inclusive or exclusive.
    /// </summary>
    public VkDiscardRectangleModeEXT discardRectangleMode;

    /// <summary>discardRectangleCount is the number of discard rectangles to use.</summary>
    public uint discardRectangleCount;

    /// <summary>pDiscardRectangles is a pointer to an array of VkRect2Dstructures defining discard rectangles.</summary>
    public VkRect2D* pDiscardRectangles;
}