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
///     VkPipelineColorBlendStateCreateInfo - Structure specifying parameters of a newly created pipeline color blend state
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendStateCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendStateCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineColorBlendStateCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     flags is a bitmask of VkPipelineColorBlendStateCreateFlagBits specifying additional color blending
    ///     information.
    /// </summary>
    public VkPipelineColorBlendStateCreateFlags flags;

    /// <summary>logicOpEnable controls whether to apply Logical Operations.</summary>
    public VkBool32 logicOpEnable;

    /// <summary>logicOp selects which logical operation to apply.</summary>
    public VkLogicOp logicOp;

    /// <summary>attachmentCount is the number of VkPipelineColorBlendAttachmentState elements in pAttachments.</summary>
    public uint attachmentCount;

    /// <summary>
    ///     pAttachments is a pointer to an array of VkPipelineColorBlendAttachmentState structures defining blend state
    ///     for each color attachment.
    /// </summary>
    public VkPipelineColorBlendAttachmentState* pAttachments;

    /// <summary>
    ///     blendConstants is a pointer to an array of four values used as the R, G, B, and A components of the blend
    ///     constant that are used in blending, depending on the blend factor.
    /// </summary>
    public fixed float blendConstants[4];
}