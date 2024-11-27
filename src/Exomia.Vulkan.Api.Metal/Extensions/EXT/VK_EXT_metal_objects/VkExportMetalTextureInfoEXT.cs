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
namespace Exomia.Vulkan.Api.Metal;

/// <summary>
///     VkExportMetalTextureInfoEXT - Structure that identifies a VkImage, VkImageView, or VkBufferView object and
///     corresponding Metal MTLTexture object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalTextureInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalTextureInfoEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkExportMetalObjectsInfoEXT</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkExportMetalObjectsInfoEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalTextureInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>image is VK_NULL_HANDLE or a VkImage.</summary>
    public VkImage image;

    /// <summary>imageView is VK_NULL_HANDLE or a VkImageView.</summary>
    public VkImageView imageView;

    /// <summary>bufferView is VK_NULL_HANDLE or a VkBufferView.</summary>
    public VkBufferView bufferView;

    /// <summary>plane specifies the plane of a multi-planar VkImage or VkImageView.</summary>
    public VkImageAspectFlagBits plane;

    /// <summary>
    ///     mtlTexture is the Metal id&lt;MTLTexture&gt; object underlying the VkImage, VkImageView, or VkBufferView
    ///     object in image, imageView, or bufferView, respectively, at the plane indicated in aspectMask. The implementation
    ///     will return the MTLTexture in this member, or it will return NULL if no MTLTexture could be found underlying the
    ///     VkImage, VkImageView, or VkBufferView object, at the plane indicated in aspectMask.
    /// </summary>
    public MTLTexture_id mtlTexture;
}