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
///     VkPhysicalDeviceRayTracingPropertiesNV - Properties of the physical device for ray tracing -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPropertiesNV.html
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
public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>shaderGroupHandleSize is the size in bytes of the shader header.</summary>
    public uint shaderGroupHandleSize;

    /// <summary> maxRecursionDepth is the maximum number of levels of recursion allowed in a trace command.</summary>
    public uint maxRecursionDepth;

    /// <summary>maxShaderGroupStride is the maximum stride in bytes allowed between shader groups in the shader binding table.</summary>
    public uint maxShaderGroupStride;

    /// <summary>shaderGroupBaseAlignment is the required alignment in bytes for the base of the shader binding table.</summary>
    public uint shaderGroupBaseAlignment;

    /// <summary>maxGeometryCount is the maximum number of geometries in the bottom level acceleration structure.</summary>
    public ulong maxGeometryCount;

    /// <summary>maxInstanceCount is the maximum number of instances in the top level acceleration structure.</summary>
    public ulong maxInstanceCount;

    /// <summary>
    ///     maxTriangleCount is the maximum number of triangles in all geometries in the bottom level acceleration
    ///     structure.
    /// </summary>
    public ulong maxTriangleCount;

    /// <summary>
    ///     maxDescriptorSetAccelerationStructures is the maximum number of acceleration structure descriptors that are
    ///     allowed in a descriptor set.
    /// </summary>
    public uint maxDescriptorSetAccelerationStructures;
}