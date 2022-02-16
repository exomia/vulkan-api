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
///     VkSubpassShadingPipelineCreateInfoHUAWEI - Structure specifying parameters of a newly created subpass shading
///     pipeline -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassShadingPipelineCreateInfoHUAWEI.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassShadingPipelineCreateInfoHUAWEI.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkComputePipelineCreateInfo</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkComputePipelineCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     renderPass is a handle to a render pass object describing the environment in which the pipeline will be used.
    ///     The pipeline must only be used with a render pass instance compatible with the one provided. See Render Pass
    ///     Compatibility for more information.
    /// </summary>
    public VkRenderPass renderPass;

    /// <summary>subpass is the index of the subpass in the render pass where this pipeline will be used.</summary>
    public uint subpass;
}