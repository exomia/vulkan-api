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
///     VkPipelineRobustnessCreateInfoEXT - Structure controlling the robustness of a newly created pipeline shader
///     stage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo,VkPipelineShaderStageCreateInfo,VkRayTracingPipelineCreateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo,VkPipelineShaderStageCreateInfo,VkRayTracingPipelineCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRobustnessCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     storageBuffers<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT
    ///     </a>
    /// </summary>
    public VkPipelineRobustnessBufferBehaviorEXT storageBuffers;

    /// <summary>
    ///     uniformBuffers<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT
    ///     </a>
    /// </summary>
    public VkPipelineRobustnessBufferBehaviorEXT uniformBuffers;

    /// <summary>
    ///     vertexInputs<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT
    ///     </a>
    /// </summary>
    public VkPipelineRobustnessBufferBehaviorEXT vertexInputs;

    /// <summary>
    ///     images<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineRobustnessCreateInfoEXT
    ///     </a>
    /// </summary>
    public VkPipelineRobustnessImageBehaviorEXT images;
}