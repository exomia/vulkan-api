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
///     VkPresentTimesInfoGOOGLE - The earliest time each image should be presented -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentTimesInfoGOOGLE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentTimesInfoGOOGLE.html</a>
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
public unsafe struct VkPresentTimesInfoGOOGLE
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>swapchainCount is the number of swapchains being presented to by this command.</summary>
    public uint swapchainCount;

    /// <summary>
    ///     pTimes is NULL or a pointer to an array of VkPresentTimeGOOGLE elements with swapchainCount entries. If not
    ///     NULL, each element of pTimes contains the earliest time to present the image corresponding to the entry in the
    ///     VkPresentInfoKHR::pImageIndices array.
    /// </summary>
    public VkPresentTimeGOOGLE* pTimes;
}