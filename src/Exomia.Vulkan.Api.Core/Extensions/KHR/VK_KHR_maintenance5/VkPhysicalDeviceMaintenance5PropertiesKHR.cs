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
///     VkPhysicalDeviceMaintenance5PropertiesKHR - Structure describing various implementation-defined properties
///     introduced with VK_KHR_maintenance5 -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance5PropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance5PropertiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance5PropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     earlyFragmentMultisampleCoverageAfterSampleCounting is a boolean value indicating whether the fragment shading
    ///     and multisample coverage operations are performed after sample counting for fragment shaders with
    ///     EarlyFragmentTests execution mode.
    /// </summary>
    public VkBool32 earlyFragmentMultisampleCoverageAfterSampleCounting;

    /// <summary>
    ///     earlyFragmentSampleMaskTestBeforeSampleCounting is a boolean value indicating whether the sample mask test
    ///     operation is performed before sample counting for fragment shaders using the EarlyFragmentTestsexecution mode.
    /// </summary>
    public VkBool32 earlyFragmentSampleMaskTestBeforeSampleCounting;

    /// <summary>
    ///     depthStencilSwizzleOneSupport is a boolean indicating that depth/stencil texturing operations with
    ///     VK_COMPONENT_SWIZZLE_ONEhave defined behavior.
    /// </summary>
    public VkBool32 depthStencilSwizzleOneSupport;

    /// <summary>
    ///     polygonModePointSize is a boolean value indicating whether the point size of the final rasterization of
    ///     polygons with VK_POLYGON_MODE_POINT is controlled by PointSize.
    /// </summary>
    public VkBool32 polygonModePointSize;

    /// <summary>
    ///     nonStrictSinglePixelWideLinesUseParallelogram is a boolean value indicating whether non-strict lines with a
    ///     width of 1.0 are rasterized as parallelograms or using Bresenham&#8217;s algorithm.
    /// </summary>
    public VkBool32 nonStrictSinglePixelWideLinesUseParallelogram;

    /// <summary>
    ///     nonStrictWideLinesUseParallelogram is a boolean value indicating whether non-strict lines with a width greater
    ///     than 1.0 are rasterized as parallelograms or using Bresenham&#8217;s algorithm.
    /// </summary>
    public VkBool32 nonStrictWideLinesUseParallelogram;
}