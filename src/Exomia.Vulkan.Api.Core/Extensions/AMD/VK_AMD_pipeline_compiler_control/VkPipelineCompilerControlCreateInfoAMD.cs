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
///     VkPipelineCompilerControlCreateInfoAMD - Structure used to pass compilation control flags to a pipeline -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCompilerControlCreateInfoAMD.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCompilerControlCreateInfoAMD.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCompilerControlCreateInfoAMD
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     compilerControlFlags is a bitmask of VkPipelineCompilerControlFlagBitsAMD affecting how the pipeline will be
    ///     compiled.
    /// </summary>
    public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
}