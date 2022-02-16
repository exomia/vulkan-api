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
///     VkAttachmentSampleCountInfoAMD - Structure specifying command buffer inheritance info for dynamic render pass
///     instances -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentSampleCountInfoAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentSampleCountInfoAMD.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkCommandBufferInheritanceInfo,VkGraphicsPipelineCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkCommandBufferInheritanceInfo,VkGraphicsPipelineCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentSampleCountInfoAMD
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD;

    /// <summary>sType is the type of this structure</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure</summary>
    public void* pNext;

    /// <summary>colorAttachmentCount is the number of color attachments specified in a render pass instance.</summary>
    public uint colorAttachmentCount;

    /// <summary>
    ///     pColorAttachmentSamples is a pointer to an array of VkSampleCountFlagBits values defining the sample count of
    ///     color attachments.
    /// </summary>
    public VkSampleCountFlagBits* pColorAttachmentSamples;

    /// <summary>
    ///     depthStencilAttachmentSamples is a VkSampleCountFlagBitsvalue defining the sample count of a depth/stencil
    ///     attachment.
    /// </summary>
    public VkSampleCountFlagBits depthStencilAttachmentSamples;
}