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
///     VkPresentIdKHR - The list of presentation identifiers -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentIdKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentIdKHR.html</a>
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
public unsafe struct VkPresentIdKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PRESENT_ID_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>swapchainCount is the number of swapchains being presented to the vkQueuePresentKHR command.</summary>
    public uint swapchainCount;

    /// <summary>
    ///     pPresentIds is NULL or a pointer to an array of uint64_t with swapchainCount entries. If not NULL, each
    ///     non-zero value in pPresentIds specifies the present id to be associated with the presentation of the swapchain with
    ///     the same index in the vkQueuePresentKHR call.
    /// </summary>
    public ulong* pPresentIds;
}