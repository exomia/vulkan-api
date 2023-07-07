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
///     VkImageViewSlicedCreateInfoEXT - Specify the subset of 3D slices of an image view -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewSlicedCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewSlicedCreateInfoEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageViewCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageViewCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewSlicedCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>sliceOffset is the Z-offset for the first 3D slice accessible to the image view.</summary>
    public uint sliceOffset;

    /// <summary>sliceCount is the number of 3D slices accessible to the image view.</summary>
    public uint sliceCount;
}