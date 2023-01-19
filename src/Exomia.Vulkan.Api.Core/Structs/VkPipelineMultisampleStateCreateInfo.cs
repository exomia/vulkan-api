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
///     VkPipelineMultisampleStateCreateInfo - Structure specifying parameters of a newly created pipeline multisample
///     state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineMultisampleStateCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineMultisampleStateCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineMultisampleStateCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkPipelineMultisampleStateCreateFlags flags;

    /// <summary>
    ///     rasterizationSamples is a VkSampleCountFlagBits value specifying the number of samples used in rasterization.
    ///     This value is ignored for the purposes of setting the number of samples used in rasterization if the pipeline is
    ///     created with the VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT dynamic state set, but if
    ///     VK_DYNAMIC_STATE_SAMPLE_MASK_EXT dynamic state is not set, it is still used to define the size of the pSampleMask
    ///     array as described below.
    /// </summary>
    public VkSampleCountFlagBits rasterizationSamples;

    /// <summary>sampleShadingEnable can be used to enable Sample Shading.</summary>
    public VkBool32 sampleShadingEnable;

    /// <summary>minSampleShading specifies a minimum fraction of sample shading if sampleShadingEnable is set to VK_TRUE.</summary>
    public float minSampleShading;

    /// <summary>pSampleMask is a pointer to an array of VkSampleMaskvalues used in the sample mask test.</summary>
    public VkSampleMask* pSampleMask;

    /// <summary>
    ///     alphaToCoverageEnable controls whether a temporary coverage value is generated based on the alpha component of
    ///     the fragment&#8217;s first color output as specified in the Multisample Coveragesection.
    /// </summary>
    public VkBool32 alphaToCoverageEnable;

    /// <summary>
    ///     alphaToOneEnable controls whether the alpha component of the fragment&#8217;s first color output is replaced
    ///     with one as described in Multisample Coverage.
    /// </summary>
    public VkBool32 alphaToOneEnable;
}