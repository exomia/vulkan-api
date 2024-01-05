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
///     VkDeviceImageSubresourceInfoKHR - Image creation information for querying subresource layout -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceImageSubresourceInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceImageSubresourceInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceImageSubresourceInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pCreateInfo is a pointer to a VkImageCreateInfo structure containing parameters affecting creation of the
    ///     image to query.
    /// </summary>
    public VkImageCreateInfo* pCreateInfo;

    /// <summary>
    ///     pSubresource pSubresource is a pointer to a VkImageSubresource2KHR structure selecting a specific image
    ///     subresource for the query.
    /// </summary>
    public VkImageSubresource2KHR* pSubresource;
}