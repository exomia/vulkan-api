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
///     VkDisplaySurfaceStereoCreateInfoNV - Structure specifying stereo parameters of a newly created display plane
///     surface object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplaySurfaceStereoCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplaySurfaceStereoCreateInfoNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkDisplaySurfaceCreateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkDisplaySurfaceCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplaySurfaceStereoCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DISPLAY_SURFACE_STEREO_CREATE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stereoType is a VkDisplaySurfaceStereoTypeNV value specifying the type of 3D stereo presentation the display
    ///     will be configured for.
    /// </summary>
    public VkDisplaySurfaceStereoTypeNV stereoType;
}