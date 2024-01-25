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
///     VkImageCompressionControlEXT - Specify image compression properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCompressionControlEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCompressionControlEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkImageCreateInfo,VkSwapchainCreateInfoKHR,VkPhysicalDeviceImageFormatInfo2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageCreateInfo,VkSwapchainCreateInfoKHR,VkPhysicalDeviceImageFormatInfo2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCompressionControlEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkImageCompressionFlagBitsEXTdescribing compression controls for the image.</summary>
    public VkImageCompressionFlagsEXT flags;

    /// <summary>compressionControlPlaneCount is the number of entries in the pFixedRateFlags array.</summary>
    public uint compressionControlPlaneCount;

    /// <summary>
    ///     pFixedRateFlags is NULL or a pointer to an array of VkImageCompressionFixedRateFlagsEXT bitfields describing
    ///     allowed fixed-rate compression rates of each image plane. It is ignored if flags does not include
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT.
    /// </summary>
    public VkImageCompressionFixedRateFlagsEXT* pFixedRateFlags;
}