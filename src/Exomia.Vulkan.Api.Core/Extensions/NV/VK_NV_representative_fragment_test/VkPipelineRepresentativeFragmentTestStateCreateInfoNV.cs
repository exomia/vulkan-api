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
///     VkPipelineRepresentativeFragmentTestStateCreateInfoNV - Structure specifying representative fragment test -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRepresentativeFragmentTestStateCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRepresentativeFragmentTestStateCreateInfoNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkGraphicsPipelineCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGraphicsPipelineCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>representativeFragmentTestEnable controls whether the representative fragment test is enabled.</summary>
    public VkBool32 representativeFragmentTestEnable;
}