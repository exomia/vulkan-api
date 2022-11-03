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
///     VkCopyMemoryToImageIndirectCommandNV - Structure specifying indirect buffer image copy operation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToImageIndirectCommandNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToImageIndirectCommandNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkCopyMemoryToImageIndirectCommandNV
{
    /// <summary>srcAddress is the starting address of the source host or device memory to copy from.</summary>
    public VkDeviceAddress srcAddress;

    /// <summary>
    ///     bufferRowLength and bufferImageHeight specify in texels a subregion of a larger two- or three-dimensional
    ///     image in buffer memory, and control the addressing calculations. If either of these values is zero, that aspect of
    ///     the buffer memory is considered to be tightly packed according to the imageExtent.
    /// </summary>
    public uint bufferRowLength;

    /// <summary>
    ///     bufferRowLength and bufferImageHeight specify in texels a subregion of a larger two- or three-dimensional
    ///     image in buffer memory, and control the addressing calculations. If either of these values is zero, that aspect of
    ///     the buffer memory is considered to be tightly packed according to the imageExtent.
    /// </summary>
    public uint bufferImageHeight;

    /// <summary>
    ///     imageSubresource is a VkImageSubresourceLayers used to specify the specific image subresources of the image
    ///     used for the destination image data, which must match the values specified in pImageSubresources parameter of
    ///     vkCmdCopyMemoryToImageIndirectNV during command recording.
    /// </summary>
    public VkImageSubresourceLayers imageSubresource;

    /// <summary>imageOffset selects the initial x, y, z offsets in texels of the sub-region of the destination image data.</summary>
    public VkOffset3D imageOffset;

    /// <summary>imageExtent is the size in texels of the destination image in width, height and depth.</summary>
    public VkExtent3D imageExtent;
}