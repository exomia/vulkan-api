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
///     VkFilterCubicImageViewImageFormatPropertiesEXT - Structure for querying cubic filtering capabilities of an image
///     view type -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFilterCubicImageViewImageFormatPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFilterCubicImageViewImageFormatPropertiesEXT.html
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
public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     filterCubic tells if image format, image type and image view type can be used with cubic filtering. This field
    ///     is set by the implementation. User-specified value is ignored.
    /// </summary>
    public VkBool32 filterCubic;

    /// <summary>
    ///     filterCubicMinmax tells if image format, image type and image view type can be used with cubic filtering and
    ///     minmax filtering. This field is set by the implementation. User-specified value is ignored.
    /// </summary>
    public VkBool32 filterCubicMinmax;
}