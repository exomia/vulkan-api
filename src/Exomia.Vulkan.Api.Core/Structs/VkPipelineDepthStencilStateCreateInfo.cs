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
///     VkPipelineDepthStencilStateCreateInfo - Structure specifying parameters of a newly created pipeline depth stencil
///     state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineDepthStencilStateCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     flags is a bitmask of VkPipelineDepthStencilStateCreateFlagBits specifying additional depth/stencil state
    ///     information.
    /// </summary>
    public VkPipelineDepthStencilStateCreateFlags flags;

    /// <summary>depthTestEnable controls whether depth testingis enabled.</summary>
    public VkBool32 depthTestEnable;

    /// <summary>
    ///     depthWriteEnable controls whether depth writes are enabled when depthTestEnable is VK_TRUE. Depth writes are
    ///     always disabled when depthTestEnable is VK_FALSE.
    /// </summary>
    public VkBool32 depthWriteEnable;

    /// <summary>depthCompareOp is the comparison operator used in the depth test.</summary>
    public VkCompareOp depthCompareOp;

    /// <summary>depthBoundsTestEnable controls whether depth bounds testing is enabled.</summary>
    public VkBool32 depthBoundsTestEnable;

    /// <summary>stencilTestEnable controls whether stencil testing is enabled.</summary>
    public VkBool32 stencilTestEnable;

    /// <summary>front and back control the parameters of the stencil test.</summary>
    public VkStencilOpState front;

    /// <summary>front and back control the parameters of the stencil test.</summary>
    public VkStencilOpState back;

    /// <summary>minDepthBounds is the minimum depth bound used in the depth bounds test.</summary>
    public float minDepthBounds;

    /// <summary>maxDepthBounds is the maximum depth bound used in the depth bounds test.</summary>
    public float maxDepthBounds;
}