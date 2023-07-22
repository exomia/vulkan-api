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
///     VkHostImageCopyDevicePerformanceQueryEXT - Struct containing information about optimality of device access -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHostImageCopyDevicePerformanceQueryEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHostImageCopyDevicePerformanceQueryEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageFormatProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageFormatProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHostImageCopyDevicePerformanceQueryEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     optimalDeviceAccess returns VK_TRUE if use of host image copy has no adverse effect on device access
    ///     performance, compared to an image that is created with exact same creation parameters, and bound to the same
    ///     VkDeviceMemory, except that VK_IMAGE_USAGE_HOST_TRANSFER_BIT_EXT is replaced with VK_IMAGE_USAGE_TRANSFER_SRC_BIT
    ///     and VK_IMAGE_USAGE_TRANSFER_DST_BIT.
    /// </summary>
    public VkBool32 optimalDeviceAccess;

    /// <summary>
    ///     identicalMemoryLayout returns VK_TRUE if use of host image copy has no impact on memory layout compared to an
    ///     image that is created with exact same creation parameters, and bound to the same VkDeviceMemory, except that
    ///     VK_IMAGE_USAGE_HOST_TRANSFER_BIT_EXT is replaced with VK_IMAGE_USAGE_TRANSFER_SRC_BIT and
    ///     VK_IMAGE_USAGE_TRANSFER_DST_BIT.
    /// </summary>
    public VkBool32 identicalMemoryLayout;
}