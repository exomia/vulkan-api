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
///     VkSurfaceProtectedCapabilitiesKHR - Structure describing capability of a surface to be protected -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceProtectedCapabilitiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceProtectedCapabilitiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkSurfaceCapabilities2KHR </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSurfaceCapabilities2KHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceProtectedCapabilitiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> supportsProtected specifies whether a protected swapchain created from VkPhysicalDeviceSurfaceInfo2KHR::surface for a particular windowing system can be displayed on screen or not. If supportsProtected is VK_TRUE, then creation of swapchains with the VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR flag set must be supported for surface. </summary>
    public VkBool32 supportsProtected;
}