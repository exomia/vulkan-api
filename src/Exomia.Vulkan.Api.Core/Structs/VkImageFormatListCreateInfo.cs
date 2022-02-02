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
///     VkImageFormatListCreateInfo - Specify that an image can: be used with a particular set of formats -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageFormatListCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageFormatListCreateInfo.html</a>
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
public unsafe struct VkImageFormatListCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>viewFormatCount is the number of entries in the pViewFormatsarray.</summary>
    public uint viewFormatCount;

    /// <summary>
    ///     pViewFormats is a pointer to an array of VkFormat values specifying all formats which can be used when
    ///     creating views of this image.
    /// </summary>
    public VkFormat* pViewFormats;
}