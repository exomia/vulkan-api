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
///     VkSwapchainCounterCreateInfoEXT - Specify the surface counters desired -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainCounterCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainCounterCreateInfoEXT.html
///     </a>
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
public unsafe struct VkSwapchainCounterCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     surfaceCounters is a bitmask of VkSurfaceCounterFlagBitsEXTspecifying surface counters to enable for the
    ///     swapchain.
    /// </summary>
    public VkSurfaceCounterFlagsEXT surfaceCounters;
}