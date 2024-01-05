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
///     VkPipelineRasterizationLineStateCreateInfoEXT - Structure specifying parameters of a newly created pipeline line
///     rasterization state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationLineStateCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationLineStateCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPipelineRasterizationStateCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPipelineRasterizationStateCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>lineRasterizationMode is a VkLineRasterizationModeEXT value selecting the style of line rasterization.</summary>
    public VkLineRasterizationModeEXT lineRasterizationMode;

    /// <summary>stippledLineEnable enables stippled line rasterization.</summary>
    public VkBool32 stippledLineEnable;

    /// <summary>lineStippleFactor is the repeat factor used in stippled line rasterization.</summary>
    public uint lineStippleFactor;

    /// <summary>lineStipplePattern is the bit pattern used in stippled line rasterization.</summary>
    public ushort lineStipplePattern;
}