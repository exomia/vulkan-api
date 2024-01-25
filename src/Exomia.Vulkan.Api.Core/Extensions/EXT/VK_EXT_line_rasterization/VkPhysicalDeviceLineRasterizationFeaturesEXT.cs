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
///     VkPhysicalDeviceLineRasterizationFeaturesEXT - Structure describing the line rasterization features that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLineRasterizationFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLineRasterizationFeaturesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary> rectangularLines indicates whether the implementation supports rectangular line rasterization.</summary>
    public VkBool32 rectangularLines;

    /// <summary> bresenhamLines indicates whether the implementation supports Bresenham-style line rasterization.</summary>
    public VkBool32 bresenhamLines;

    /// <summary> smoothLines indicates whether the implementation supports smooth line rasterization.</summary>
    public VkBool32 smoothLines;

    /// <summary>
    ///     stippledRectangularLinesindicates whether the implementation supports stippled line rasterization with
    ///     VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT lines.
    /// </summary>
    public VkBool32 stippledRectangularLines;

    /// <summary>
    ///     stippledBresenhamLinesindicates whether the implementation supports stippled line rasterization with
    ///     VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT lines.
    /// </summary>
    public VkBool32 stippledBresenhamLines;

    /// <summary>
    ///     stippledSmoothLines indicates whether the implementation supports stippled line rasterization with
    ///     VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT lines.
    /// </summary>
    public VkBool32 stippledSmoothLines;
}