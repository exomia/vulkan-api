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
///     VkPresentRegionsKHR - Structure hint of rectangular regions changed by vkQueuePresentKHR -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentRegionsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentRegionsKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPresentInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPresentInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentRegionsKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>swapchainCount is the number of swapchains being presented to by this command.</summary>
    public uint swapchainCount;

    /// <summary>
    ///     pRegions is NULL or a pointer to an array of VkPresentRegionKHR elements with swapchainCount entries. If not
    ///     NULL, each element of pRegions contains the region that has changed since the last present to the swapchain in the
    ///     corresponding entry in the VkPresentInfoKHR::pSwapchains array.
    /// </summary>
    public VkPresentRegionKHR* pRegions;
}