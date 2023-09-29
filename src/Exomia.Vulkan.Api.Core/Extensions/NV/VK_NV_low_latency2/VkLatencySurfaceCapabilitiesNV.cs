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
///     VkLatencySurfaceCapabilitiesNV - Structure describing surface optimized presentation modes for use with low
///     latency mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencySurfaceCapabilitiesNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencySurfaceCapabilitiesNV.html</a>
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
public unsafe struct VkLatencySurfaceCapabilitiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_LATENCY_SURFACE_CAPABILITIES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>presentModeCount is the number of presentation modes provided.</summary>
    public uint presentModeCount;

    /// <summary>
    ///     pPresentModes is list of presentation modes optimized for use with low latency mode with presentModeCount
    ///     entries.
    /// </summary>
    public VkPresentModeKHR* pPresentModes;
}