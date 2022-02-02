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
///     VkSamplerBorderColorComponentMappingCreateInfoEXT - Structure specifying the component mapping of the border color
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerBorderColorComponentMappingCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerBorderColorComponentMappingCreateInfoEXT.html
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
public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>components is a VkComponentMapping structure specifying a remapping of the border color components.</summary>
    public VkComponentMapping components;

    /// <summary>
    ///     srgb indicates that the sampler will be combined with an image view that has an image format which is sRGB
    ///     encoded.
    /// </summary>
    public VkBool32 srgb;
}