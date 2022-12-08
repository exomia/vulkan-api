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
///     VkSurfacePresentScalingCapabilitiesEXT - Structure describing the presentation scaling capabilities of the surface
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfacePresentScalingCapabilitiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfacePresentScalingCapabilitiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSurfaceCapabilities2KHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSurfaceCapabilities2KHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfacePresentScalingCapabilitiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     supportedPresentScaling is a bitmask of VkPresentScalingFlagBitsEXT representing the scaling methods supported
    ///     by the surface, or 0 if application-defined scaling is not supported.
    /// </summary>
    public VkPresentScalingFlagsEXT supportedPresentScaling;

    /// <summary>
    ///     supportedPresentGravityX is a bitmask of VkPresentGravityFlagBitsEXT representing the X-axis pixel gravity
    ///     supported by the surface, or 0 if Vulkan-defined pixel gravity is not supported for the X axis.
    /// </summary>
    public VkPresentGravityFlagsEXT supportedPresentGravityX;

    /// <summary>
    ///     supportedPresentGravityY is a bitmask of VkPresentGravityFlagBitsEXT representing the Y-axis pixel gravity
    ///     supported by the surface, or 0 if Vulkan-defined pixel gravity is not supported for the Y axis.
    /// </summary>
    public VkPresentGravityFlagsEXT supportedPresentGravityY;

    /// <summary>
    ///     minScaledImageExtent contains the smallest valid swapchain extent for the surface on the specified device when
    ///     one of the scaling methods specified in supportedPresentScaling is used, or the special value (0xFFFFFFFF,
    ///     0xFFFFFFFF) indicating that the surface size will be determined by the extent of a swapchain targeting the surface.
    ///     The width and height of the extent will each be smaller than or equal to the corresponding width and height of
    ///     VkSurfaceCapabilitiesKHR::minImageExtent.
    /// </summary>
    public VkExtent2D minScaledImageExtent;

    /// <summary>
    ///     maxScaledImageExtent contains the largest valid swapchain extent for the surface on the specified device when
    ///     one of the scaling methods specified in supportedPresentScaling is used, or the special value described above for
    ///     minScaledImageExtent. The width and height of the extent will each be greater than or equal to the corresponding
    ///     width and height of VkSurfaceCapabilitiesKHR::maxImageExtent.
    /// </summary>
    public VkExtent2D maxScaledImageExtent;
}