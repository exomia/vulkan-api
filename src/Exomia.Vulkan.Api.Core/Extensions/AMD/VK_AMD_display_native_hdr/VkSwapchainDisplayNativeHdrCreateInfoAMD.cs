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
///     VkSwapchainDisplayNativeHdrCreateInfoAMD - Structure specifying display native HDR parameters of a newly created
///     swapchain object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainDisplayNativeHdrCreateInfoAMD.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSwapchainDisplayNativeHdrCreateInfoAMD.html
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
public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>localDimmingEnable specifies whether local dimming is enabled for the swapchain.</summary>
    public VkBool32 localDimmingEnable;
}