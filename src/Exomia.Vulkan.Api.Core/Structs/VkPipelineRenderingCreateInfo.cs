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
///     VkPipelineRenderingCreateInfo - Structure specifying attachment formats -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRenderingCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRenderingCreateInfo.html</a>
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
public unsafe struct VkPipelineRenderingCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>viewMask is the viewMask used for rendering.</summary>
    public uint viewMask;

    /// <summary>colorAttachmentCount is the number of entries in pColorAttachmentFormats</summary>
    public uint colorAttachmentCount;

    /// <summary>
    ///     pColorAttachmentFormats is a pointer to an array of VkFormatvalues defining the format of color attachments
    ///     used in this pipeline.
    /// </summary>
    public VkFormat* pColorAttachmentFormats;

    /// <summary>depthAttachmentFormat is a VkFormat value defining the format of the depth attachment used in this pipeline.</summary>
    public VkFormat depthAttachmentFormat;

    /// <summary>
    ///     stencilAttachmentFormat is a VkFormat value defining the format of the stencil attachment used in this
    ///     pipeline.
    /// </summary>
    public VkFormat stencilAttachmentFormat;
}