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
///     VkPhysicalDeviceRayTracingPipelinePropertiesKHR - Properties of the physical device for ray tracing -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPipelinePropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPipelinePropertiesKHR.html
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
public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>shaderGroupHandleSize is the size in bytes of the shader header.</summary>
    public uint shaderGroupHandleSize;

    /// <summary> maxRayRecursionDepth is the maximum number of levels of ray recursion allowed in a trace command.</summary>
    public uint maxRayRecursionDepth;

    /// <summary>maxShaderGroupStride is the maximum stride in bytes allowed between shader groups in the shader binding table.</summary>
    public uint maxShaderGroupStride;

    /// <summary>shaderGroupBaseAlignment is the required alignment in bytes for the base of the shader binding table.</summary>
    public uint shaderGroupBaseAlignment;

    /// <summary>
    ///     shaderGroupHandleCaptureReplaySize is the number of bytes for the information required to do capture and
    ///     replay for shader group handles.
    /// </summary>
    public uint shaderGroupHandleCaptureReplaySize;

    /// <summary>
    ///     maxRayDispatchInvocationCount is the maximum number of ray generation shader invocations which may be produced
    ///     by a single vkCmdTraceRaysIndirectKHR or vkCmdTraceRaysKHR command.
    /// </summary>
    public uint maxRayDispatchInvocationCount;

    /// <summary>
    ///     shaderGroupHandleAlignment is the required alignment in bytes for each shader binding table entry. The value
    ///     must be a power of two.
    /// </summary>
    public uint shaderGroupHandleAlignment;

    /// <summary>maxRayHitAttributeSize is the maximum size in bytes for a ray attribute structure</summary>
    public uint maxRayHitAttributeSize;
}