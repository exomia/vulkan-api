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
///     VkCommandBufferInheritanceRenderingInfo - Structure specifying command buffer inheritance info for dynamic render
///     pass instances -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceRenderingInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceRenderingInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkCommandBufferInheritanceInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkCommandBufferInheritanceInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceRenderingInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkRenderingFlagBits used by the render pass instance.</summary>
    public VkRenderingFlags flags;

    /// <summary>viewMask is the view mask used for rendering.</summary>
    public uint viewMask;

    /// <summary>colorAttachmentCount is the number of color attachments specified in the render pass instance.</summary>
    public uint colorAttachmentCount;

    /// <summary>pColorAttachmentFormats is a pointer to an array of VkFormatvalues defining the format of color attachments.</summary>
    public VkFormat* pColorAttachmentFormats;

    /// <summary>depthAttachmentFormat is a VkFormat value defining the format of the depth attachment.</summary>
    public VkFormat depthAttachmentFormat;

    /// <summary>stencilAttachmentFormat is a VkFormat value defining the format of the stencil attachment.</summary>
    public VkFormat stencilAttachmentFormat;

    /// <summary>rasterizationSamples is a VkSampleCountFlagBits specifying the number of samples used in rasterization.</summary>
    public VkSampleCountFlagBits rasterizationSamples;
}