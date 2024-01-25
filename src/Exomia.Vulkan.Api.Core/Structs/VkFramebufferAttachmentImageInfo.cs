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
///     VkFramebufferAttachmentImageInfo - Structure specifying parameters of an image that will be used with a
///     framebuffer -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferAttachmentImageInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferAttachmentImageInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferAttachmentImageInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     flags is a bitmask of VkImageCreateFlagBits, matching the value of VkImageCreateInfo::flags used to create an
    ///     image that will be used with this framebuffer.
    /// </summary>
    public VkImageCreateFlags flags;

    /// <summary>
    ///     usage is a bitmask of VkImageUsageFlagBits, matching the value of VkImageCreateInfo::usage used to create an
    ///     image used with this framebuffer.
    /// </summary>
    public VkImageUsageFlags usage;

    /// <summary>width is the width of the image view used for rendering.</summary>
    public uint width;

    /// <summary>height is the height of the image view used for rendering.</summary>
    public uint height;

    /// <summary>layerCount is the number of array layers of the image view used for rendering.</summary>
    public uint layerCount;

    /// <summary>
    ///     viewFormatCount is the number of entries in the pViewFormatsarray, matching the value of
    ///     VkImageFormatListCreateInfo::viewFormatCount used to create an image used with this framebuffer.
    /// </summary>
    public uint viewFormatCount;

    /// <summary>
    ///     pViewFormats is a pointer to an array of VkFormat values specifying all of the formats which can be used when
    ///     creating views of the image, matching the value of VkImageFormatListCreateInfo::pViewFormats used to create an
    ///     image used with this framebuffer.
    /// </summary>
    public VkFormat* pViewFormats;
}