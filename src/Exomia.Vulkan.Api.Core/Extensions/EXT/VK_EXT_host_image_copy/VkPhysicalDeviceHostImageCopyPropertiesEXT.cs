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
///     VkPhysicalDeviceHostImageCopyPropertiesEXT - Structure enumerating image layouts supported by an implementation for
///     host memory copies -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceHostImageCopyPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceHostImageCopyPropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceHostImageCopyPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     copySrcLayoutCount is an integer related to the number of image layouts for host copies from images available
    ///     or queried, as described below.
    /// </summary>
    public uint copySrcLayoutCount;

    /// <summary>
    ///     pCopySrcLayouts is a pointer to an array of VkImageLayout in which supported image layouts for use with host
    ///     copy operations from images are returned.
    /// </summary>
    public VkImageLayout* pCopySrcLayouts;

    /// <summary>
    ///     copyDstLayoutCount is an integer related to the number of image layouts for host copies to images available or
    ///     queried, as described below.
    /// </summary>
    public uint copyDstLayoutCount;

    /// <summary>
    ///     pCopyDstLayouts is a pointer to an array of VkImageLayout in which supported image layouts for use with host
    ///     copy operations to images are returned.
    /// </summary>
    public VkImageLayout* pCopyDstLayouts;

    /// <summary>
    ///     optimalTilingLayoutUUID is an array of VK_UUID_SIZEuint8_t values representing a universally unique identifier
    ///     for the implementation&#8217;s swizzling layout of images created with VK_IMAGE_TILING_OPTIMAL.
    /// </summary>
    public fixed byte optimalTilingLayoutUUID[(int)VK_UUID_SIZE];

    /// <summary>
    ///     identicalMemoryTypeRequirements indicates that specifying the VK_IMAGE_USAGE_HOST_TRANSFER_BIT_EXT flag in
    ///     VkImageCreateInfo::usage does not affect the memory type requirements of the image.
    /// </summary>
    public VkBool32 identicalMemoryTypeRequirements;
}