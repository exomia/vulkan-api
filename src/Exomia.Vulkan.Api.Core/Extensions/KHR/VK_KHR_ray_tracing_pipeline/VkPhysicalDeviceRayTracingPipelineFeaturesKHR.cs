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
///     VkPhysicalDeviceRayTracingPipelineFeaturesKHR - Structure describing the ray tracing features that can be supported
///     by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPipelineFeaturesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPipelineFeaturesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     rayTracingPipeline indicates whether the implementation supports the ray tracing pipeline functionality. See
    ///     Ray Tracing.
    /// </summary>
    public VkBool32 rayTracingPipeline;

    /// <summary>
    ///     rayTracingPipelineShaderGroupHandleCaptureReplay indicates whether the implementation supports saving and
    ///     reusing shader group handles, e.g. for trace capture and replay.
    /// </summary>
    public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplay;

    /// <summary>
    ///     rayTracingPipelineShaderGroupHandleCaptureReplayMixed indicates whether the implementation supports reuse of
    ///     shader group handles being arbitrarily mixed with creation of non-reused shader group handles. If this is VK_FALSE,
    ///     all reused shader group handles must be specified before any non-reused handles may be created.
    /// </summary>
    public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplayMixed;

    /// <summary>
    ///     rayTracingPipelineTraceRaysIndirect indicates whether the implementation supports indirect ray tracing
    ///     commands, e.g. vkCmdTraceRaysIndirectKHR.
    /// </summary>
    public VkBool32 rayTracingPipelineTraceRaysIndirect;

    /// <summary>
    ///     rayTraversalPrimitiveCulling indicates whether the implementation supports primitive culling during ray
    ///     traversal.
    /// </summary>
    public VkBool32 rayTraversalPrimitiveCulling;
}