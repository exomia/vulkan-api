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
///     VkImageCreateInfo - Structure specifying the parameters of a newly created image object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkImageCreateFlagBits describing additional parameters of the image.</summary>
    public VkImageCreateFlags flags;

    /// <summary>
    ///     imageType is a VkImageType value specifying the basic dimensionality of the image. Layers in array textures do
    ///     not count as a dimension for the purposes of the image type.
    /// </summary>
    public VkImageType imageType;

    /// <summary>format is a VkFormat describing the format and type of the texel blocks that will be contained in the image.</summary>
    public VkFormat format;

    /// <summary>extent is a VkExtent3D describing the number of data elements in each dimension of the base level.</summary>
    public VkExtent3D extent;

    /// <summary>mipLevels describes the number of levels of detail available for minified sampling of the image.</summary>
    public uint mipLevels;

    /// <summary>arrayLayers is the number of layers in the image.</summary>
    public uint arrayLayers;

    /// <summary>samples is a VkSampleCountFlagBits value specifying the number of samples per texel.</summary>
    public VkSampleCountFlagBits samples;

    /// <summary>tiling is a VkImageTiling value specifying the tiling arrangement of the texel blocks in memory.</summary>
    public VkImageTiling tiling;

    /// <summary>usage is a bitmask of VkImageUsageFlagBits describing the intended usage of the image.</summary>
    public VkImageUsageFlags usage;

    /// <summary>
    ///     sharingMode is a VkSharingMode value specifying the sharing mode of the image when it will be accessed by
    ///     multiple queue families.
    /// </summary>
    public VkSharingMode sharingMode;

    /// <summary>queueFamilyIndexCount is the number of entries in the pQueueFamilyIndices array.</summary>
    public uint queueFamilyIndexCount;

    /// <summary>
    ///     pQueueFamilyIndices is a pointer to an array of queue families that will access this image. It is ignored if
    ///     sharingMode is not VK_SHARING_MODE_CONCURRENT.
    /// </summary>
    public uint* pQueueFamilyIndices;

    /// <summary>
    ///     initialLayout is a VkImageLayout value specifying the initial VkImageLayout of all image subresources of the
    ///     image. See Image Layouts.
    /// </summary>
    public VkImageLayout initialLayout;
}