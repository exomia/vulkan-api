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
///     VkSamplerYcbcrConversionCreateInfo - Structure specifying the parameters of the newly created conversion -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> format is the format of the image from which color information will be retrieved. </summary>
    public VkFormat format;

    /// <summary> ycbcrModel describes the color matrix for conversion between color models. </summary>
    public VkSamplerYcbcrModelConversion ycbcrModel;

    /// <summary> ycbcrRange describes whether the encoded values have headroom and foot room, or whether the encoding uses the full numerical range. </summary>
    public VkSamplerYcbcrRange ycbcrRange;

    /// <summary> components applies a swizzle based on VkComponentSwizzleenums prior to range expansion and color model conversion. </summary>
    public VkComponentMapping components;

    /// <summary> xChromaOffset describes the sample location associated with downsampled chroma components in the x dimension. xChromaOffset has no effect for formats in which chroma components are not downsampled horizontally. </summary>
    public VkChromaLocation xChromaOffset;

    /// <summary> yChromaOffset describes the sample location associated with downsampled chroma components in the y dimension. yChromaOffset has no effect for formats in which the chroma components are not downsampled vertically. </summary>
    public VkChromaLocation yChromaOffset;

    /// <summary> chromaFilter is the filter for chroma reconstruction. </summary>
    public VkFilter chromaFilter;

    /// <summary> forceExplicitReconstruction can be used to ensure that reconstruction is done explicitly, if supported. </summary>
    public VkBool32 forceExplicitReconstruction;
}