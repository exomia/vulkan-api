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
///     VkClearDepthStencilValue - Structure specifying a clear depth stencil value -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearDepthStencilValue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearDepthStencilValue.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkClearDepthStencilValue
{
    /// <summary>
    ///     depth is the clear value for the depth aspect of the depth/stencil attachment. It is a floating-point value
    ///     which is automatically converted to the attachment&#8217;s format.
    /// </summary>
    public float depth;

    /// <summary>
    ///     stencil is the clear value for the stencil aspect of the depth/stencil attachment. It is a 32-bit integer
    ///     value which is converted to the attachment&#8217;s format by taking the appropriate number of LSBs.
    /// </summary>
    public uint stencil;
}