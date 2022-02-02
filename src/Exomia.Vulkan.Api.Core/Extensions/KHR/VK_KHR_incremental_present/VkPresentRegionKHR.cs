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
///     VkPresentRegionKHR - Structure containing rectangular region changed by vkQueuePresentKHR for a given VkImage
///     -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentRegionKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPresentRegionKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentRegionKHR
{
    /// <summary>
    ///     rectangleCount is the number of rectangles in pRectangles, or zero if the entire image has changed and should
    ///     be presented.
    /// </summary>
    public uint rectangleCount;

    /// <summary>
    ///     pRectangles is either NULL or a pointer to an array of VkRectLayerKHR structures. The VkRectLayerKHR structure
    ///     is the framebuffer coordinates, plus layer, of a portion of a presentable image that has changed and must be
    ///     presented. If non-NULL, each entry in pRectangles is a rectangle of the given image that has changed since the last
    ///     image was presented to the given swapchain. The rectangles must be specified relative to
    ///     VkSurfaceCapabilitiesKHR::currentTransform, regardless of the swapchain&#8217;s preTransform. The presentation
    ///     engine will apply the preTransform transformation to the rectangles, along with any further transformation it
    ///     applies to the image content.
    /// </summary>
    public VkRectLayerKHR* pRectangles;
}