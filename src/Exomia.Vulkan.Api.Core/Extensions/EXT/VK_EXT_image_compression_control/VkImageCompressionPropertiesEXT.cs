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
///     VkImageCompressionPropertiesEXT - Compression properties of an image -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCompressionPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCompressionPropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkImageFormatProperties2,VkSurfaceFormat2KHR,VkSubresourceLayout2EXT</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageFormatProperties2,VkSurfaceFormat2KHR,VkSubresourceLayout2EXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCompressionPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     imageCompressionFlags returns a value describing the compression controls that apply to the image. The value
    ///     will be either VK_IMAGE_COMPRESSION_DEFAULT_EXT to indicate no fixed-rate compression,
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT to indicate fixed-rate compression, or
    ///     VK_IMAGE_COMPRESSION_DISABLED_EXT to indicate no compression.
    /// </summary>
    public VkImageCompressionFlagsEXT imageCompressionFlags;

    /// <summary>
    ///     imageCompressionFixedRateFlags returns a VkImageCompressionFixedRateFlagsEXT value describing the compression
    ///     rates that apply to the specified aspect of the image.
    /// </summary>
    public VkImageCompressionFixedRateFlagsEXT imageCompressionFixedRateFlags;
}