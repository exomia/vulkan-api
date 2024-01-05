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
///     VkPhysicalDeviceImageFormatInfo2 - Structure specifying image creation parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageFormatInfo2.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageFormatInfo2.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageFormatInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext is NULL or a pointer to a structure extending this structure. The pNext chain of
    ///     VkPhysicalDeviceImageFormatInfo2 is used to provide additional image parameters to
    ///     vkGetPhysicalDeviceImageFormatProperties2.
    /// </summary>
    public void* pNext;

    /// <summary>format is a VkFormat value indicating the image format, corresponding to VkImageCreateInfo::format.</summary>
    public VkFormat format;

    /// <summary>type is a VkImageType value indicating the image type, corresponding to VkImageCreateInfo::imageType.</summary>
    public VkImageType type;

    /// <summary>tiling is a VkImageTiling value indicating the image tiling, corresponding to VkImageCreateInfo::tiling.</summary>
    public VkImageTiling tiling;

    /// <summary>
    ///     usage is a bitmask of VkImageUsageFlagBits indicating the intended usage of the image, corresponding to
    ///     VkImageCreateInfo::usage.
    /// </summary>
    public VkImageUsageFlags usage;

    /// <summary>
    ///     flags is a bitmask of VkImageCreateFlagBits indicating additional parameters of the image, corresponding to
    ///     VkImageCreateInfo::flags.
    /// </summary>
    public VkImageCreateFlags flags;
}