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
///     VkImageDrmFormatModifierExplicitCreateInfoEXT - Specify that an image be created with the provided DRM format
///     modifier and explicit memory layout -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageDrmFormatModifierExplicitCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageDrmFormatModifierExplicitCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>drmFormatModifier is the Linux DRM format modifier with which the image will be created.</summary>
    public ulong drmFormatModifier;

    /// <summary>
    ///     drmFormatModifierPlaneCount is the number of memory planes in the image (as reported by
    ///     VkDrmFormatModifierPropertiesEXT) as well as the length of the pPlaneLayouts array.
    /// </summary>
    public uint drmFormatModifierPlaneCount;

    /// <summary>
    ///     pPlaneLayouts is a pointer to an array of VkSubresourceLayout structures describing the image&#8217;s memory
    ///     planes.
    /// </summary>
    public VkSubresourceLayout* pPlaneLayouts;
}