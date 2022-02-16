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
///     VkFramebufferMixedSamplesCombinationNV - Structure specifying a supported sample count combination -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferMixedSamplesCombinationNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferMixedSamplesCombinationNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferMixedSamplesCombinationNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>coverageReductionMode is a VkCoverageReductionModeNV value specifying the coverage reduction mode.</summary>
    public VkCoverageReductionModeNV coverageReductionMode;

    /// <summary>
    ///     rasterizationSamples is a VkSampleCountFlagBits specifying the number of rasterization samples in the
    ///     supported combination.
    /// </summary>
    public VkSampleCountFlagBits rasterizationSamples;

    /// <summary>
    ///     depthStencilSamples specifies the number of samples in the depth stencil attachment in the supported
    ///     combination. A value of 0 indicates the combination does not have a depth stencil attachment.
    /// </summary>
    public VkSampleCountFlags depthStencilSamples;

    /// <summary>
    ///     colorSamples specifies the number of color samples in a color attachment in the supported combination. A value
    ///     of 0 indicates the combination does not have a color attachment.
    /// </summary>
    public VkSampleCountFlags colorSamples;
}