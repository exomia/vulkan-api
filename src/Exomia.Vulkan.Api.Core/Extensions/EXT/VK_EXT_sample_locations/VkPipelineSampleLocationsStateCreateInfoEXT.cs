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
///     VkPipelineSampleLocationsStateCreateInfoEXT - Structure specifying sample locations for a pipeline -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineSampleLocationsStateCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineSampleLocationsStateCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPipelineMultisampleStateCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPipelineMultisampleStateCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     sampleLocationsEnable controls whether custom sample locations are used. If sampleLocationsEnable is VK_FALSE,
    ///     the default sample locations are used and the values specified in sampleLocationsInfoare ignored.
    /// </summary>
    public VkBool32 sampleLocationsEnable;

    /// <summary>
    ///     sampleLocationsInfo is the sample locations to use during rasterization if sampleLocationsEnable is VK_TRUE
    ///     and the graphics pipeline is not created with VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT.
    /// </summary>
    public VkSampleLocationsInfoEXT sampleLocationsInfo;
}