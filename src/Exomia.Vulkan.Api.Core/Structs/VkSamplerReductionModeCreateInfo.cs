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
///     VkSamplerReductionModeCreateInfo - Structure specifying sampler reduction mode -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionModeCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionModeCreateInfo.html
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
public unsafe struct VkSamplerReductionModeCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>reductionMode is a VkSamplerReductionMode value controlling how texture filtering combines texel values.</summary>
    public VkSamplerReductionMode reductionMode;
}