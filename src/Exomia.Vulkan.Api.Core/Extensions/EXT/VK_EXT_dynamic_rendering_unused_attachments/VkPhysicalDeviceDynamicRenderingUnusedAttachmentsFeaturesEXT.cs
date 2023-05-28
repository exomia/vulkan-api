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
///     VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT - Structure describing the dynamic rendering unused
///     attachment features that can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     dynamicRenderingUnusedAttachments indicates that the implementation supports binding graphics pipelines within
    ///     a render pass instance where any pipeline VkPipelineRenderingCreateInfo::pColorAttachmentFormatselement with a
    ///     format other than VK_FORMAT_UNDEFINED is allowed with a corresponding VkRenderingInfo::pColorAttachmentselement
    ///     with a imageView equal to VK_NULL_HANDLE, or any pipeline
    ///     VkPipelineRenderingCreateInfo::pColorAttachmentFormatselement with a VK_FORMAT_UNDEFINED format is allowed with a
    ///     corresponding VkRenderingInfo::pColorAttachments element with a non-VK_NULL_HANDLE imageView. Also a
    ///     VkPipelineRenderingCreateInfo::depthAttachmentFormatother than VK_FORMAT_UNDEFINED is allowed with a VK_NULL_HANDLE
    ///     VkRenderingInfo::pDepthAttachment, or a VkPipelineRenderingCreateInfo::depthAttachmentFormat of VK_FORMAT_UNDEFINED
    ///     is allowed with a non-VK_NULL_HANDLEVkRenderingInfo::pDepthAttachment. Also a
    ///     VkPipelineRenderingCreateInfo::stencilAttachmentFormat other than VK_FORMAT_UNDEFINED is allowed with a
    ///     VK_NULL_HANDLEVkRenderingInfo::pStencilAttachment, or a VkPipelineRenderingCreateInfo::stencilAttachmentFormat of
    ///     VK_FORMAT_UNDEFINED is allowed with a non-VK_NULL_HANDLEVkRenderingInfo::pStencilAttachment. In these cases any
    ///     writes to these attachments are discarded.
    /// </summary>
    public VkBool32 dynamicRenderingUnusedAttachments;
}