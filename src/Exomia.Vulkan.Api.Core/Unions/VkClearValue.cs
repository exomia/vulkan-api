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
///     VkClearValue - Structure specifying a clear value -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearValue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearValue.html</a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public struct VkClearValue
{
    /// <summary>color specifies the color image clear values to use when clearing a color image or attachment.</summary>
    [FieldOffset(0)]
    public VkClearColorValue color;

    /// <summary>
    ///     depthStencil specifies the depth and stencil clear values to use when clearing a depth/stencil image or
    ///     attachment.
    /// </summary>
    [FieldOffset(0)]
    public VkClearDepthStencilValue depthStencil;
}