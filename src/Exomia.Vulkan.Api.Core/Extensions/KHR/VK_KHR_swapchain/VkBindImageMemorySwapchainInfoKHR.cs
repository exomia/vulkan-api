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
///     VkBindImageMemorySwapchainInfoKHR - Structure specifying swapchain image memory to bind to -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImageMemorySwapchainInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImageMemorySwapchainInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkBindImageMemoryInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBindImageMemoryInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemorySwapchainInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>swapchain is VK_NULL_HANDLE or a swapchain handle.</summary>
    public VkSwapchainKHR swapchain;

    /// <summary>imageIndex is an image index within swapchain.</summary>
    public uint imageIndex;
}