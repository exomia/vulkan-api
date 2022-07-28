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
///     VkDisplayNativeHdrSurfaceCapabilitiesAMD - Structure describing display native HDR specific capabilities of a
///     surface -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayNativeHdrSurfaceCapabilitiesAMD.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayNativeHdrSurfaceCapabilitiesAMD.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSurfaceCapabilities2KHR</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSurfaceCapabilities2KHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     localDimmingSupport specifies whether the surface supports local dimming. If this is VK_TRUE,
    ///     VkSwapchainDisplayNativeHdrCreateInfoAMDcan be used to explicitly enable or disable local dimming for the surface.
    ///     Local dimming may also be overridden by vkSetLocalDimmingAMDduring the lifetime of the swapchain.
    /// </summary>
    public VkBool32 localDimmingSupport;
}