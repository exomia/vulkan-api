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
///     VkHostImageLayoutTransitionInfoEXT - Structure specifying the parameters of a host-side image layout
///     transition -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHostImageLayoutTransitionInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHostImageLayoutTransitionInfoEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHostImageLayoutTransitionInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>image is a handle to the image affected by this layout transition.</summary>
    public VkImage image;

    /// <summary>oldLayout is the old layout in an image layout transition.</summary>
    public VkImageLayout oldLayout;

    /// <summary>newLayout is the new layout in an image layout transition.</summary>
    public VkImageLayout newLayout;

    /// <summary>
    ///     subresourceRange describes the image subresource range within image that is affected by this layout
    ///     transition.
    /// </summary>
    public VkImageSubresourceRange subresourceRange;
}