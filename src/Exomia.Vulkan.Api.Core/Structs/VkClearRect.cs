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
///     VkClearRect - Structure specifying a clear rectangle -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearRect.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearRect.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkClearRect
{
    /// <summary>rect is the two-dimensional region to be cleared.</summary>
    public VkRect2D rect;

    /// <summary>baseArrayLayer is the first layer to be cleared.</summary>
    public uint baseArrayLayer;

    /// <summary>layerCount is the number of layers to clear.</summary>
    public uint layerCount;
}