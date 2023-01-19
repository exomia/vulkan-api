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
namespace Exomia.Vulkan.Api.Metal;

/// <summary>
///     VkImportMetalTextureInfoEXT - Structure that identifies Metal MTLTexture objects to use when creating a
///     VkImage. -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMetalTextureInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMetalTextureInfoEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalTextureInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>plane indicates the plane of the VkImage that the id&lt;MTLTexture&gt; object should be attached to.</summary>
    public VkImageAspectFlagBits plane;

    /// <summary>mtlTexture is a the Metal id&lt;MTLTexture&gt; object that is to underlie the VkImage plane.</summary>
    public MTLTexture_id mtlTexture;
}