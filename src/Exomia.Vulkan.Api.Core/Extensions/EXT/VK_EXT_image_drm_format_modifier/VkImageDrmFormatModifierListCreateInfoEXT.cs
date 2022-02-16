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
///     VkImageDrmFormatModifierListCreateInfoEXT - Specify that an image must be created with a DRM format modifier from
///     the provided list -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageDrmFormatModifierListCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageDrmFormatModifierListCreateInfoEXT.html
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
public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>drmFormatModifierCount is the length of the pDrmFormatModifiers array.</summary>
    public uint drmFormatModifierCount;

    /// <summary>pDrmFormatModifiers is a pointer to an array of Linux DRM format modifiers.</summary>
    public ulong* pDrmFormatModifiers;
}