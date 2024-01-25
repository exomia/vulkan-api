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
///     VkPhysicalDeviceSparseImageFormatInfo2 - Structure specifying sparse image format inputs -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSparseImageFormatInfo2.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSparseImageFormatInfo2.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>format is the image format.</summary>
    public VkFormat format;

    /// <summary>type is the dimensionality of the image.</summary>
    public VkImageType type;

    /// <summary>samples is a VkSampleCountFlagBits value specifying the number of samples per texel.</summary>
    public VkSampleCountFlagBits samples;

    /// <summary>usage is a bitmask describing the intended usage of the image.</summary>
    public VkImageUsageFlags usage;

    /// <summary>tiling is the tiling arrangement of the texel blocks in memory.</summary>
    public VkImageTiling tiling;
}