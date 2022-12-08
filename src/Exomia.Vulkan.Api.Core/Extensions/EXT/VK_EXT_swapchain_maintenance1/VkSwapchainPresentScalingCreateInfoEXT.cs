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
///     VkSwapchainPresentScalingCreateInfoEXT - Scaling behavior when presenting to the surface -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainPresentScalingCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainPresentScalingCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSwapchainCreateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSwapchainCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentScalingCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     scalingBehavior<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSwapchainPresentScalingCreateInfoEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSwapchainPresentScalingCreateInfoEXT
    ///     </a>
    /// </summary>
    public VkPresentScalingFlagsEXT scalingBehavior;

    /// <summary>
    ///     presentGravityX is 0 or the x-axis direction in which swapchain image pixels gravitate relative to the surface
    ///     when presentScalingdoes not result in a one-to-one pixel mapping between the scaled swapchain image and the
    ///     surface.
    /// </summary>
    public VkPresentGravityFlagsEXT presentGravityX;

    /// <summary>
    ///     presentGravityY is 0 or the y-axis direction in which swapchain image pixels gravitate relative to the surface
    ///     when presentScalingdoes not result in a one-to-one pixel mapping between the scaled swapchain image and the
    ///     surface.
    /// </summary>
    public VkPresentGravityFlagsEXT presentGravityY;
}