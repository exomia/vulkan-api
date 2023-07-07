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
///     VkPhysicalDevicePipelineRobustnessPropertiesEXT - Structure describing the default robustness behavior of a
///     physical device -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineRobustnessPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineRobustnessPropertiesEXT.html
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
public unsafe struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     defaultRobustnessStorageBuffers describes the behaviour of out of bounds accesses made to storage buffers when
    ///     no robustness features are enabled
    /// </summary>
    public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessStorageBuffers;

    /// <summary>
    ///     defaultRobustnessUniformBuffers describes the behaviour of out of bounds accesses made to uniform buffers when
    ///     no robustness features are enabled
    /// </summary>
    public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessUniformBuffers;

    /// <summary>
    ///     defaultRobustnessVertexInputs describes the behaviour of out of bounds accesses made to vertex input
    ///     attributes when no robustness features are enabled
    /// </summary>
    public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessVertexInputs;

    /// <summary>
    ///     defaultRobustnessImages describes the behaviour of out of bounds accesses made to images when no robustness
    ///     features are enabled
    /// </summary>
    public VkPipelineRobustnessImageBehaviorEXT defaultRobustnessImages;
}