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
///     VkSurfaceCapabilities2KHR - Structure describing capabilities of a surface -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceCapabilities2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceCapabilities2KHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceCapabilities2KHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     surfaceCapabilities is a VkSurfaceCapabilitiesKHR structure describing the capabilities of the specified
    ///     surface.
    /// </summary>
    public VkSurfaceCapabilitiesKHR surfaceCapabilities;
}