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
///     VkSamplerBlockMatchWindowCreateInfoQCOM - Structure specifying the block match window parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerBlockMatchWindowCreateInfoQCOM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerBlockMatchWindowCreateInfoQCOM.html
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
public unsafe struct VkSamplerBlockMatchWindowCreateInfoQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>windowExtent is a VkExtent2D specifying a the width and height of the block match window.</summary>
    public VkExtent2D windowExtent;

    /// <summary>windowCompareMode is a VkBlockMatchWindowCompareModeQCOMspecifying the compare mode.</summary>
    public VkBlockMatchWindowCompareModeQCOM windowCompareMode;
}