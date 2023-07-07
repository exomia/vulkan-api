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
///     VkImageFormatProperties2 - Structure specifying an image format properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageFormatProperties2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageFormatProperties2.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatProperties2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext is NULL or a pointer to a structure extending this structure. The pNext chain of
    ///     VkImageFormatProperties2 is used to allow the specification of additional capabilities to be returned from
    ///     vkGetPhysicalDeviceImageFormatProperties2.
    /// </summary>
    public void* pNext;

    /// <summary>imageFormatProperties is a VkImageFormatProperties structure in which capabilities are returned.</summary>
    public VkImageFormatProperties imageFormatProperties;
}