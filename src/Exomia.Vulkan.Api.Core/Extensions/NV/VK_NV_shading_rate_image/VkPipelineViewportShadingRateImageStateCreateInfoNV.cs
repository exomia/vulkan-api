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
///     VkPipelineViewportShadingRateImageStateCreateInfoNV - Structure specifying parameters controlling shading rate
///     image usage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportShadingRateImageStateCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportShadingRateImageStateCreateInfoNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPipelineViewportStateCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPipelineViewportStateCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>shadingRateImageEnable specifies whether shading rate image and palettes are used during rasterization.</summary>
    public VkBool32 shadingRateImageEnable;

    /// <summary>
    ///     viewportCount specifies the number of per-viewport palettes used to translate values stored in shading rate
    ///     images.
    /// </summary>
    public uint viewportCount;

    /// <summary>
    ///     pShadingRatePalettes is a pointer to an array of VkShadingRatePaletteNV structures defining the palette for
    ///     each viewport. If the shading rate palette state is dynamic, this member is ignored.
    /// </summary>
    public VkShadingRatePaletteNV* pShadingRatePalettes;
}