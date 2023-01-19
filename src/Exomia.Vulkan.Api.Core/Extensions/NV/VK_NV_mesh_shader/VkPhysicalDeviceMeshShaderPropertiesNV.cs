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
///     VkPhysicalDeviceMeshShaderPropertiesNV - Structure describing mesh shading properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderPropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderPropertiesNV.html
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
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxDrawMeshTasksCount is the maximum number of local workgroups that can be launched by a single draw mesh
    ///     tasks command. See https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-mesh-shading.
    /// </summary>
    public uint maxDrawMeshTasksCount;

    /// <summary>
    ///     maxTaskWorkGroupInvocations is the maximum total number of task     shader invocations in a single local
    ///     workgroup.     The product of the X, Y, and Z sizes, as specified by the LocalSizeor LocalSizeId    execution mode
    ///     in shader modules or by the object decorated by the     WorkgroupSize decoration, must be less than or equal to
    ///     this     limit.
    /// </summary>
    public uint maxTaskWorkGroupInvocations;

    /// <summary>
    ///     maxTaskWorkGroupSize[3] is the maximum size of a local task     workgroup.     These three values represent
    ///     the maximum local workgroup size in the X,     Y, and Z dimensions, respectively.     The x, y, and z sizes, as
    ///     specified by the     LocalSizeor LocalSizeId    execution mode or by the object decorated by the WorkgroupSize
    ///     decoration in shader modules, must be less than or equal to the     corresponding limit.
    /// </summary>
    public VkArray3<uint> maxTaskWorkGroupSize;

    /// <summary>
    ///     maxTaskTotalMemorySize is the maximum number of bytes that the task shader can use in total for shared and
    ///     output memory combined.
    /// </summary>
    public uint maxTaskTotalMemorySize;

    /// <summary>maxTaskOutputCount is the maximum number of output tasks a single task shader workgroup can emit.</summary>
    public uint maxTaskOutputCount;

    /// <summary>
    ///     maxMeshWorkGroupInvocations is the maximum total number of mesh     shader invocations in a single local
    ///     workgroup.     The product of the X, Y, and Z sizes, as specified by the LocalSizeor LocalSizeId    execution mode
    ///     in shader modules or by the object decorated by the     WorkgroupSize decoration, must be less than or equal to
    ///     this     limit.
    /// </summary>
    public uint maxMeshWorkGroupInvocations;

    /// <summary>
    ///     maxMeshWorkGroupSize[3] is the maximum size of a local mesh     workgroup.     These three values represent
    ///     the maximum local workgroup size in the X,     Y, and Z dimensions, respectively.     The x, y, and z sizes, as
    ///     specified by the     LocalSizeor LocalSizeId    execution mode or by the object decorated by the WorkgroupSize
    ///     decoration in shader modules, must be less than or equal to the     corresponding limit.
    /// </summary>
    public VkArray3<uint> maxMeshWorkGroupSize;

    /// <summary>
    ///     maxMeshTotalMemorySize is the maximum number of bytes that the mesh shader can use in total for shared and
    ///     output memory combined.
    /// </summary>
    public uint maxMeshTotalMemorySize;

    /// <summary>maxMeshOutputVertices is the maximum number of vertices a mesh shader output can store.</summary>
    public uint maxMeshOutputVertices;

    /// <summary>maxMeshOutputPrimitives is the maximum number of primitives a mesh shader output can store.</summary>
    public uint maxMeshOutputPrimitives;

    /// <summary>maxMeshMultiviewViewCount is the maximum number of multiview views a mesh shader can use.</summary>
    public uint maxMeshMultiviewViewCount;

    /// <summary>
    ///     meshOutputPerVertexGranularity is the granularity with which mesh vertex outputs are allocated. The value can
    ///     be used to compute the memory size used by the mesh shader, which must be less than or equal to
    ///     maxMeshTotalMemorySize.
    /// </summary>
    public uint meshOutputPerVertexGranularity;

    /// <summary>
    ///     meshOutputPerPrimitiveGranularity is the granularity with which mesh outputs qualified as per-primitive are
    ///     allocated. The value can be used to compute the memory size used by the mesh shader, which must be less than or
    ///     equal to maxMeshTotalMemorySize.
    /// </summary>
    public uint meshOutputPerPrimitiveGranularity;
}