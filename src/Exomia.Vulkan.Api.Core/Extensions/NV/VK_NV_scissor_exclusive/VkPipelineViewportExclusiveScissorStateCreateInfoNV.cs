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
///     VkPipelineViewportExclusiveScissorStateCreateInfoNV - Structure specifying parameters controlling exclusive scissor
///     testing -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportExclusiveScissorStateCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportExclusiveScissorStateCreateInfoNV.html
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
public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>exclusiveScissorCount is the number of exclusive scissor rectangles.</summary>
    public uint exclusiveScissorCount;

    /// <summary>pExclusiveScissors is a pointer to an array of VkRect2Dstructures defining exclusive scissor rectangles.</summary>
    public VkRect2D* pExclusiveScissors;
}