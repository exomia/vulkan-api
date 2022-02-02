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
///     VkSamplerCustomBorderColorCreateInfoEXT - Structure specifying custom border color -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCustomBorderColorCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCustomBorderColorCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSamplerCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSamplerCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>customBorderColor is a VkClearColorValue representing the desired custom sampler border color.</summary>
    public VkClearColorValue customBorderColor;

    /// <summary>
    ///     format is a VkFormat representing the format of the sampled image view(s). This field may be
    ///     VK_FORMAT_UNDEFINED if the customBorderColorWithoutFormatfeature is enabled.
    /// </summary>
    public VkFormat format;
}