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
///     VkSwapchainPresentFenceInfoEXT - Fences associated with a vkQueuePresentKHR operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainPresentFenceInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainPresentFenceInfoEXT.html</a>
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
public unsafe struct VkSwapchainPresentFenceInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>swapchainCount is the number of swapchains being presented to by this command.</summary>
    public uint swapchainCount;

    /// <summary>
    ///     pFences is a list of fences with swapchainCount entries. Each entry must be VK_NULL_HANDLE or the handle of a
    ///     fence to signal when the relevant operations on the associated swapchain have completed.
    /// </summary>
    public VkFence* pFences;
}