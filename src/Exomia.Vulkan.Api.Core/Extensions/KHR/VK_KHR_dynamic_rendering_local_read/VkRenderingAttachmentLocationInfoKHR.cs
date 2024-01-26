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
///     VkRenderingAttachmentLocationInfoKHR - Structure specifying attachment locations -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentLocationInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentLocationInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkGraphicsPipelineCreateInfo,VkCommandBufferInheritanceInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGraphicsPipelineCreateInfo,VkCommandBufferInheritanceInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingAttachmentLocationInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>colorAttachmentCount is the number of elements in pColorAttachmentLocations.</summary>
    public uint colorAttachmentCount;

    /// <summary>
    ///     pColorAttachmentLocations is a pointer to an array of colorAttachmentCount uint32_t values defining remapped
    ///     locations for color attachments.
    /// </summary>
    public uint* pColorAttachmentLocations;
}