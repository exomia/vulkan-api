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
///     VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM - Structure specifying Y′CBCR degamma parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSamplerYcbcrConversionCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSamplerYcbcrConversionCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>enableYDegamma indicates sRGB to linearconversion is enabled for the G component.</summary>
    public VkBool32 enableYDegamma;

    /// <summary>enableCbCrDegamma indicates sRGB to linear conversion is enabled for the R and B components.</summary>
    public VkBool32 enableCbCrDegamma;
}