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
///     VkPipelineViewportWScalingStateCreateInfoNV - Structure specifying parameters of a newly created pipeline viewport
///     W scaling state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportWScalingStateCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportWScalingStateCreateInfoNV.html
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
public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>viewportWScalingEnable controls whether viewport W scaling is enabled.</summary>
    public VkBool32 viewportWScalingEnable;

    /// <summary>
    ///     viewportCount is the number of viewports used by W scaling, and must match the number of viewports in the
    ///     pipeline if viewport Wscaling is enabled.
    /// </summary>
    public uint viewportCount;

    /// <summary>
    ///     pViewportWScalings is a pointer to an array of VkViewportWScalingNV structures defining the W scaling
    ///     parameters for the corresponding viewports. If the viewport W scaling state is dynamic, this member is ignored.
    /// </summary>
    public VkViewportWScalingNV* pViewportWScalings;
}