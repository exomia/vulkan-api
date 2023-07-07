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
///     VkAcquireNextImageInfoKHR - Structure specifying parameters of the acquire -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAcquireNextImageInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAcquireNextImageInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAcquireNextImageInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>swapchain is a non-retired swapchain from which an image is acquired.</summary>
    public VkSwapchainKHR swapchain;

    /// <summary>timeout specifies how long the function waits, in nanoseconds, if no image is available.</summary>
    public ulong timeout;

    /// <summary>semaphore is VK_NULL_HANDLE or a semaphore to signal.</summary>
    public VkSemaphore semaphore;

    /// <summary>fence is VK_NULL_HANDLE or a fence to signal.</summary>
    public VkFence fence;

    /// <summary>
    ///     deviceMask is a mask of physical devices for which the swapchain image will be ready to use when the semaphore
    ///     or fence is signaled.
    /// </summary>
    public uint deviceMask;
}