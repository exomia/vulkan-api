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
///     VkRenderingFragmentShadingRateAttachmentInfoKHR - Structure specifying fragment shading rate attachment information
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingFragmentShadingRateAttachmentInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingFragmentShadingRateAttachmentInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkRenderingInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderingInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>imageView is the image view that will be used as a fragment shading rate attachment.</summary>
    public VkImageView imageView;

    /// <summary>imageLayout is the layout that imageView will be in during rendering.</summary>
    public VkImageLayout imageLayout;

    /// <summary>shadingRateAttachmentTexelSize specifies the number of pixels corresponding to each texel in imageView.</summary>
    public VkExtent2D shadingRateAttachmentTexelSize;
}