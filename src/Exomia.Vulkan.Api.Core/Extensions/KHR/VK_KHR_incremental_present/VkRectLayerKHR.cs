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
///     VkRectLayerKHR - Structure containing a rectangle, including layer, changed by vkQueuePresentKHR for a given
///     VkImage -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRectLayerKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRectLayerKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkRectLayerKHR
{
    /// <summary>offset is the origin of the rectangle, in pixels.</summary>
    public VkOffset2D offset;

    /// <summary>extent is the size of the rectangle, in pixels.</summary>
    public VkExtent2D extent;

    /// <summary>layer is the layer of the image. For images with only one layer, the value of layer must be 0.</summary>
    public uint layer;
}