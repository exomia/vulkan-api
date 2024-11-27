#region License

// Copyright (c) 2018-2024, exomia
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
///     VkSwapchainLatencyCreateInfoNV - Specify that a swapchain will use low latency mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainLatencyCreateInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainLatencyCreateInfoNV.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSwapchainCreateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSwapchainCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainLatencyCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SWAPCHAIN_LATENCY_CREATE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>latencyModeEnable is VK_TRUE if the created swapchain will utilize low latency mode, VK_FALSE otherwise.</summary>
    public VkBool32 latencyModeEnable;
}