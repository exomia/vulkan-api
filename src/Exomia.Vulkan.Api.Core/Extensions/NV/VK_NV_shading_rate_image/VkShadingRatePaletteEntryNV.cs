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
///     VkShadingRatePaletteEntryNV - Shading rate image palette entry types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShadingRatePaletteEntryNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShadingRatePaletteEntryNV.html</a>
/// </summary>
public enum VkShadingRatePaletteEntryNV
{
    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>0</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>0</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>0</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV = 0,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>16</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV = 1,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>8</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV = 2,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>4</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV = 3,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>2</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV = 4,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV = 5,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>2</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV = 6,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>1</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>2</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV = 7,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>2</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>2</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV = 8,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>4</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>2</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV = 9,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>2</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>4</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV = 10,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Width</term><description>4</description>
    ///         </item>
    ///         <item>
    ///             <term>Height</term><description>4</description>
    ///         </item>
    ///         <item>
    ///             <term>Invocations</term><description>1</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV = 11
}