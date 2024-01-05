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
///     VkColorBlendEquationEXT - Structure specifying the color blend factors and operations for an attachment -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkColorBlendEquationEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkColorBlendEquationEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkColorBlendEquationEXT
{
    /// <summary>srcColorBlendFactor selects which blend factor is used to determine the source factors (Sr,Sg,Sb).</summary>
    public VkBlendFactor srcColorBlendFactor;

    /// <summary>dstColorBlendFactor selects which blend factor is used to determine the destination factors (Dr,Dg,Db).</summary>
    public VkBlendFactor dstColorBlendFactor;

    /// <summary>
    ///     colorBlendOp selects which blend operation is used to calculate the RGB values to write to the color
    ///     attachment.
    /// </summary>
    public VkBlendOp colorBlendOp;

    /// <summary>srcAlphaBlendFactor selects which blend factor is used to determine the source factor Sa.</summary>
    public VkBlendFactor srcAlphaBlendFactor;

    /// <summary>dstAlphaBlendFactor selects which blend factor is used to determine the destination factor Da.</summary>
    public VkBlendFactor dstAlphaBlendFactor;

    /// <summary>
    ///     alphaBlendOp selects which blend operation is use to calculate the alpha values to write to the color
    ///     attachment.
    /// </summary>
    public VkBlendOp alphaBlendOp;
}