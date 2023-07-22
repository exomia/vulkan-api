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
///     VkImageToMemoryCopyEXT - Structure specifying an image to host memory copy operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageToMemoryCopyEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageToMemoryCopyEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageToMemoryCopyEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>pHostPointer is the host memory address which is the destination of the copy.</summary>
    public void* pHostPointer;

    /// <summary>
    ///     memoryRowLength and memoryImageHeight specify in texels a subregion of a larger two- or three-dimensional
    ///     image in host memory, and control the addressing calculations. If either of these values is zero, that aspect of
    ///     the host memory is considered to be tightly packed according to the imageExtent.
    /// </summary>
    public uint memoryRowLength;

    /// <summary>
    ///     memoryRowLength and memoryImageHeight specify in texels a subregion of a larger two- or three-dimensional
    ///     image in host memory, and control the addressing calculations. If either of these values is zero, that aspect of
    ///     the host memory is considered to be tightly packed according to the imageExtent.
    /// </summary>
    public uint memoryImageHeight;

    /// <summary>
    ///     imageSubresource is a VkImageSubresourceLayers used to specify the specific image subresources of the image
    ///     used for the source or destination image data.
    /// </summary>
    public VkImageSubresourceLayers imageSubresource;

    /// <summary>imageOffset selects the initial x, y, z offsets in texels of the sub-region of the source image data.</summary>
    public VkOffset3D imageOffset;

    /// <summary>imageExtent is the size in texels of the image to copy in width, height and depth.</summary>
    public VkExtent3D imageExtent;
}