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
///     VkImageStencilUsageCreateInfo - Specify separate usage flags for the stencil aspect of a depth-stencil image
///     -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageStencilUsageCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageStencilUsageCreateInfo.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageCreateInfo,VkPhysicalDeviceImageFormatInfo2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageCreateInfo,VkPhysicalDeviceImageFormatInfo2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageStencilUsageCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stencilUsage is a bitmask of VkImageUsageFlagBits describing the intended usage of the stencil aspect of the
    ///     image.
    /// </summary>
    public VkImageUsageFlags stencilUsage;
}