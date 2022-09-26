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
///     VkPresentInfoKHR - Structure describing parameters of a queue presentation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentInfoKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentInfoKHR.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PRESENT_INFO_KHR;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> waitSemaphoreCount is the number of semaphores to wait for before issuing the present request. The number may be zero. </summary>
    public uint waitSemaphoreCount;

    /// <summary> pWaitSemaphores is NULL or a pointer to an array of VkSemaphore objects with waitSemaphoreCount entries, and specifies the semaphores to wait for before issuing the present request. </summary>
    public VkSemaphore* pWaitSemaphores;

    /// <summary> swapchainCount is the number of swapchains being presented to by this command. </summary>
    public uint swapchainCount;

    /// <summary> pSwapchains is a pointer to an array of VkSwapchainKHRobjects with swapchainCount entries. A given swapchain must not appear in this list more than once. </summary>
    public VkSwapchainKHR* pSwapchains;

    /// <summary> pImageIndices is a pointer to an array of indices into the array of each swapchain&#8217;s presentable images, with swapchainCountentries. Each entry in this array identifies the image to present on the corresponding entry in the pSwapchains array. </summary>
    public uint* pImageIndices;

    /// <summary> pResults is a pointer to an array of VkResult typed elements with swapchainCount entries. Applications that do not need per-swapchain results can use NULL for pResults. If non-NULL, each entry in pResults will be set to the VkResult for presenting the swapchain corresponding to the same index in pSwapchains. </summary>
    public VkResult* pResults;
}