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
///     VkPhysicalDeviceFragmentDensityMap2PropertiesEXT - Structure describing additional fragment density map properties
///     that can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMap2PropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMap2PropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     subsampledLoads specifies if performing image data read with load operations on subsampled attachments will
    ///     be resampled to the fragment density of the render pass
    /// </summary>
    public VkBool32 subsampledLoads;

    /// <summary>
    ///     subsampledCoarseReconstructionEarlyAccess specifies if performing image data read with samplers created with
    ///     flags containing VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT in fragment shader will trigger
    ///     additional reads during VK_PIPELINE_STAGE_VERTEX_SHADER_BIT
    /// </summary>
    public VkBool32 subsampledCoarseReconstructionEarlyAccess;

    /// <summary>
    ///     maxSubsampledArrayLayers is the maximum number of VkImageView array layers for usages supporting subsampled
    ///     samplers
    /// </summary>
    public uint maxSubsampledArrayLayers;

    /// <summary>
    ///     maxDescriptorSetSubsampledSamplers is the maximum number of subsampled samplers that can be included in a
    ///     VkPipelineLayout
    /// </summary>
    public uint maxDescriptorSetSubsampledSamplers;
}