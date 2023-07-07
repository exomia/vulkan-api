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
///     VkPipelineViewportStateCreateInfo - Structure specifying parameters of a newly created pipeline viewport
///     state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportStateCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkPipelineViewportStateCreateFlags flags;

    /// <summary>viewportCount is the number of viewports used by the pipeline.</summary>
    public uint viewportCount;

    /// <summary>
    ///     pViewports is a pointer to an array of VkViewportstructures, defining the viewport transforms. If the viewport
    ///     state is dynamic, this member is ignored.
    /// </summary>
    public VkViewport* pViewports;

    /// <summary>scissorCount is the number of scissors and must match the number of viewports.</summary>
    public uint scissorCount;

    /// <summary>
    ///     pScissors is a pointer to an array of VkRect2D structures defining the rectangular bounds of the scissor for
    ///     the corresponding viewport. If the scissor state is dynamic, this member is ignored.
    /// </summary>
    public VkRect2D* pScissors;
}