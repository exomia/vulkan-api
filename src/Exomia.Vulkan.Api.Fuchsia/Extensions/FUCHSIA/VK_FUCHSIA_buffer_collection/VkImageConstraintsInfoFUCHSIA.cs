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
///     VkImageConstraintsInfoFUCHSIA - Structure of image-based buffer collection constraints -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageConstraintsInfoFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageConstraintsInfoFUCHSIA.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageConstraintsInfoFUCHSIA
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>formatConstraintsCount is the number of elements in pFormatConstraints.</summary>
    public uint formatConstraintsCount;

    /// <summary>
    ///     pFormatConstraints is a pointer to an array of VkImageFormatConstraintsInfoFUCHSIA structures of size
    ///     formatConstraintsCount that is used to further constrain buffer collection format selection for image-based buffer
    ///     collections.
    /// </summary>
    public VkImageFormatConstraintsInfoFUCHSIA* pFormatConstraints;

    /// <summary>
    ///     bufferCollectionConstraints is a VkBufferCollectionConstraintsInfoFUCHSIA structure used to supply parameters
    ///     for the negotiation and allocation for buffer-based buffer collections.
    /// </summary>
    public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;

    /// <summary>
    ///     flags is a VkImageConstraintsInfoFlagBitsFUCHSIA value specifying hints about the type of memory Sysmem should
    ///     allocate for the buffer collection.
    /// </summary>
    public VkImageConstraintsInfoFlagsFUCHSIA flags;
}