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
///     VkImageViewCreateInfo - Structure specifying parameters of a newly created image view -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkImageViewCreateFlagBits specifying additional parameters of the image view.</summary>
    public VkImageViewCreateFlags flags;

    /// <summary>image is a VkImage on which the view will be created.</summary>
    public VkImage image;

    /// <summary>viewType is a VkImageViewType value specifying the type of the image view.</summary>
    public VkImageViewType viewType;

    /// <summary>format is a VkFormat specifying the format and type used to interpret texel blocks of the image.</summary>
    public VkFormat format;

    /// <summary>
    ///     components is a VkComponentMapping structure specifying a remapping of color components (or of depth or
    ///     stencil components after they have been converted into color components).
    /// </summary>
    public VkComponentMapping components;

    /// <summary>
    ///     subresourceRange is a VkImageSubresourceRange structure selecting the set of mipmap levels and array layers to
    ///     be accessible to the view.
    /// </summary>
    public VkImageSubresourceRange subresourceRange;
}