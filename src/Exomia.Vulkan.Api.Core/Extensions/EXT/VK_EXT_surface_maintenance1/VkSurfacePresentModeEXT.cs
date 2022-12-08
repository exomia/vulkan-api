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
///     VkSurfacePresentModeEXT - Structure describing present mode of a surface -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfacePresentModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfacePresentModeEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceSurfaceInfo2KHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceSurfaceInfo2KHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfacePresentModeEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>presentMode is the presentation mode the swapchain will use.</summary>
    public VkPresentModeKHR presentMode;
}