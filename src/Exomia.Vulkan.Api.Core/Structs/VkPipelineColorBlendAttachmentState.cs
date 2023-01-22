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
///     VkPipelineColorBlendAttachmentState - Structure specifying a pipeline color blend attachment state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendAttachmentState.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendAttachmentState.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkPipelineColorBlendAttachmentState
{
    /// <summary>
    ///     blendEnable controls whether blending is enabled for the corresponding color attachment. If blending is not
    ///     enabled, the source fragment&#8217;s color for that attachment is passed through unmodified.
    /// </summary>
    public VkBool32 blendEnable;

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
    ///     alphaBlendOp selects which blend operation is used to calculate the alpha values to write to the color
    ///     attachment.
    /// </summary>
    public VkBlendOp alphaBlendOp;

    /// <summary>
    ///     colorWriteMask is a bitmask of VkColorComponentFlagBitsspecifying which of the R, G, B, and/or A components
    ///     are enabled for writing, as described for the Color Write Mask.
    /// </summary>
    public VkColorComponentFlags colorWriteMask;
}