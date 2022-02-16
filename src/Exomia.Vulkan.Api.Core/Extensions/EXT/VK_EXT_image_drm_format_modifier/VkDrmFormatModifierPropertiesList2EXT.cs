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
///     VkDrmFormatModifierPropertiesList2EXT - Structure specifying the list of DRM format modifiers supported for a
///     format -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrmFormatModifierPropertiesList2EXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrmFormatModifierPropertiesList2EXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkFormatProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkFormatProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierPropertiesList2EXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     drmFormatModifierCount is an inout parameter related to the number of modifiers compatible with the format, as
    ///     described below.
    /// </summary>
    public uint drmFormatModifierCount;

    /// <summary>
    ///     pDrmFormatModifierProperties is either NULL or a pointer to an array of VkDrmFormatModifierProperties2EXT
    ///     structures.
    /// </summary>
    public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
}