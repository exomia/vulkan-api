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
///     VkPipelineRasterizationConservativeStateCreateInfoEXT - Structure specifying conservative raster state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationConservativeStateCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationConservativeStateCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPipelineRasterizationStateCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPipelineRasterizationStateCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;

    /// <summary>conservativeRasterizationMode is the conservative rasterization mode to use.</summary>
    public VkConservativeRasterizationModeEXT conservativeRasterizationMode;

    /// <summary>
    ///     extraPrimitiveOverestimationSize is the extra size in pixels to increase the generating primitive during
    ///     conservative rasterization at each of its edges in X and Y equally in screen space beyond the base overestimation
    ///     specified in VkPhysicalDeviceConservativeRasterizationPropertiesEXT::primitiveOverestimationSize. If
    ///     conservativeRasterizationMode is not VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT, this value is ignored.
    /// </summary>
    public float extraPrimitiveOverestimationSize;
}