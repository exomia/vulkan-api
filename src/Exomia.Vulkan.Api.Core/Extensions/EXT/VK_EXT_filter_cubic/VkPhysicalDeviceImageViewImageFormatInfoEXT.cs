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
///     VkPhysicalDeviceImageViewImageFormatInfoEXT - Structure for providing image view type -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageViewImageFormatInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageViewImageFormatInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkPhysicalDeviceImageFormatInfo2 </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceImageFormatInfo2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> imageViewType is a VkImageViewType value specifying the type of the image view. </summary>
    public VkImageViewType imageViewType;
}