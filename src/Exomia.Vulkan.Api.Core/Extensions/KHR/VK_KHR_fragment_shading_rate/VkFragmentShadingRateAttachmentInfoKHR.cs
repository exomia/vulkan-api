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
///     VkFragmentShadingRateAttachmentInfoKHR - Structure specifying a fragment shading rate attachment for a subpass -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateAttachmentInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateAttachmentInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubpassDescription2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubpassDescription2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pFragmentShadingRateAttachment is NULL or a pointer to a VkAttachmentReference2 structure defining the
    ///     fragment shading rate attachment for this subpass.
    /// </summary>
    public VkAttachmentReference2* pFragmentShadingRateAttachment;

    /// <summary>
    ///     shadingRateAttachmentTexelSize specifies the size of the portion of the framebuffer corresponding to each
    ///     texel in pFragmentShadingRateAttachment.
    /// </summary>
    public VkExtent2D shadingRateAttachmentTexelSize;
}