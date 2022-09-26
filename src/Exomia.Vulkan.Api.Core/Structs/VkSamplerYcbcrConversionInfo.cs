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
///     VkSamplerYcbcrConversionInfo - Structure specifying Y′CBCR conversion to a sampler or image view -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionInfo.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionInfo.html </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkSamplerCreateInfo,VkImageViewCreateInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSamplerCreateInfo,VkImageViewCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> conversion is a VkSamplerYcbcrConversion handle created with vkCreateSamplerYcbcrConversion. </summary>
    public VkSamplerYcbcrConversion conversion;
}