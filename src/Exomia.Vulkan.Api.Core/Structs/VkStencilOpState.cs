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
///     VkStencilOpState - Structure specifying stencil operation state -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStencilOpState.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStencilOpState.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkStencilOpState
{
    /// <summary>failOp is a VkStencilOp value specifying the action performed on samples that fail the stencil test.</summary>
    public VkStencilOp failOp;

    /// <summary>
    ///     passOp is a VkStencilOp value specifying the action performed on samples that pass both the depth and stencil
    ///     tests.
    /// </summary>
    public VkStencilOp passOp;

    /// <summary>
    ///     depthFailOp is a VkStencilOp value specifying the action performed on samples that pass the stencil test and
    ///     fail the depth test.
    /// </summary>
    public VkStencilOp depthFailOp;

    /// <summary>compareOp is a VkCompareOp value specifying the comparison operator used in the stencil test.</summary>
    public VkCompareOp compareOp;

    /// <summary>compareMask selects the bits of the unsigned integer stencil values participating in the stencil test.</summary>
    public uint compareMask;

    /// <summary>
    ///     writeMask selects the bits of the unsigned integer stencil values updated by the stencil test in the stencil
    ///     framebuffer attachment.
    /// </summary>
    public uint writeMask;

    /// <summary>reference is an integer reference value that is used in the unsigned stencil comparison.</summary>
    public uint reference;
}