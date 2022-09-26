#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VkBufferCollectionImageCreateInfoFUCHSIA - Create a VkBufferCollectionFUCHSIA-compatible VkImage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCollectionImageCreateInfoFUCHSIA.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCollectionImageCreateInfoFUCHSIA.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkImageCreateInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionImageCreateInfoFUCHSIA
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA;

    /// <summary> sType is the type of this structure </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure </summary>
    public void* pNext;

    /// <summary> collection is the VkBufferCollectionFUCHSIA handle </summary>
    public VkBufferCollectionFUCHSIA collection;

    /// <summary> index is the index of the buffer in the buffer collection from which the memory will be imported </summary>
    public uint index;
}