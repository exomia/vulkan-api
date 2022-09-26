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
///     VkDisplayPresentInfoKHR - Structure describing parameters of a queue presentation to a swapchain -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPresentInfoKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPresentInfoKHR.html </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkPresentInfoKHR </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPresentInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPresentInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> srcRect is a rectangular region of pixels to present. It must be a subset of the image being presented. If VkDisplayPresentInfoKHR is not specified, this region will be assumed to be the entire presentable image. </summary>
    public VkRect2D srcRect;

    /// <summary> dstRect is a rectangular region within the visible region of the swapchain&#8217;s display mode. If VkDisplayPresentInfoKHR is not specified, this region will be assumed to be the entire visible region of the swapchain&#8217;s mode. If the specified rectangle is a subset of the display mode&#8217;s visible region, content from display planes below the swapchain&#8217;s plane will be visible outside the rectangle. If there are no planes below the swapchain&#8217;s, the area outside the specified rectangle will be black. If portions of the specified rectangle are outside of the display&#8217;s visible region, pixels mapping only to those portions of the rectangle will be discarded. </summary>
    public VkRect2D dstRect;

    /// <summary> persistent: If this is VK_TRUE, the display engine will enable buffered mode on displays that support it. This allows the display engine to stop sending content to the display until a new image is presented. The display will instead maintain a copy of the last presented image. This allows less power to be used, but may increase presentation latency. If VkDisplayPresentInfoKHR is not specified, persistent mode will not be used. </summary>
    public VkBool32 persistent;
}