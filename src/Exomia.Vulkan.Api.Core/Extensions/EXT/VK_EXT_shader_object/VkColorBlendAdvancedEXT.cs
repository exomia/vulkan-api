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
///     VkColorBlendAdvancedEXT - Structure specifying the advanced blend operation parameters for an attachment -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkColorBlendAdvancedEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkColorBlendAdvancedEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkColorBlendAdvancedEXT
{
    /// <summary>
    ///     advancedBlendOp selects which blend operation is used to calculate the RGB values to write to the color
    ///     attachment.
    /// </summary>
    public VkBlendOp advancedBlendOp;

    /// <summary>srcPremultiplied specifies whether the source color of the blend operation is treated as premultiplied.</summary>
    public VkBool32 srcPremultiplied;

    /// <summary>dstPremultiplied specifies whether the destination color of the blend operation is treated as premultiplied.</summary>
    public VkBool32 dstPremultiplied;

    /// <summary>
    ///     blendOverlap is a VkBlendOverlapEXT value specifying how the source and destination sample&#8217;s coverage is
    ///     correlated.
    /// </summary>
    public VkBlendOverlapEXT blendOverlap;

    /// <summary>
    ///     clampResults specifies that results must be clamped to the [0,1] range before writing to the attachment, which
    ///     is useful when the attachment format is not normalized fixed-point.
    /// </summary>
    public VkBool32 clampResults;
}