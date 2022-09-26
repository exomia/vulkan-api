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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkBufferImageCopy2 - Structure specifying a buffer image copy operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferImageCopy2.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferImageCopy2.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferImageCopy2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> bufferOffset is the offset in bytes from the start of the buffer object where the image data is copied from or to. </summary>
    public VkDeviceSize bufferOffset;

    /// <summary> bufferRowLength and bufferImageHeight specify in texels a subregion of a larger two- or three-dimensional image in buffer memory, and control the addressing calculations. If either of these values is zero, that aspect of the buffer memory is considered to be tightly packed according to the imageExtent. </summary>
    public uint bufferRowLength;

    /// <summary> bufferRowLength and bufferImageHeight specify in texels a subregion of a larger two- or three-dimensional image in buffer memory, and control the addressing calculations. If either of these values is zero, that aspect of the buffer memory is considered to be tightly packed according to the imageExtent. </summary>
    public uint bufferImageHeight;

    /// <summary> imageSubresource is a VkImageSubresourceLayers used to specify the specific image subresources of the image used for the source or destination image data. </summary>
    public VkImageSubresourceLayers imageSubresource;

    /// <summary> imageOffset selects the initial x, y, z offsets in texels of the sub-region of the source or destination image data. </summary>
    public VkOffset3D imageOffset;

    /// <summary> imageExtent is the size in texels of the image to copy in width, height and depth. </summary>
    public VkExtent3D imageExtent;
}