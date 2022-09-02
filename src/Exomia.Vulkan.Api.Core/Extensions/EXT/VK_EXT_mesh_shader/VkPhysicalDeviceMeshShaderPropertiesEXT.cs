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
///     VkPhysicalDeviceMeshShaderPropertiesEXT - Structure describing mesh shading properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderPropertiesEXT.html
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
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxTaskWorkGroupTotalCountis the maximum number of total local workgroups that can be launched by a single
    ///     mesh tasks drawing command. See
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-mesh-shading.
    /// </summary>
    public uint maxTaskWorkGroupTotalCount;

    /// <summary>
    ///     maxTaskWorkGroupCount[3] is the maximum number of local workgroups that can be launched by a single mesh
    ///     tasks drawing command. These three values represent the maximum number of local workgroups for the X, Y, and Z
    ///     dimensions, respectively. The workgroup count parameters to the drawing commands must be less than or equal to the
    ///     corresponding limit. The product of these dimensions must be less than or equal to maxTaskWorkGroupTotalCount.
    /// </summary>
    public VkArray3<uint> maxTaskWorkGroupCount;

    /// <summary>
    ///     maxTaskWorkGroupInvocations    is the maximum total number of task shader invocations in a single local
    ///     workgroup.     The product of the X, Y, and Z sizes, as specified by the LocalSizeor LocalSizeId    execution mode
    ///     in shader modules or by the object decorated by the     WorkgroupSize decoration, must be less than or equal to
    ///     this     limit.
    /// </summary>
    public uint maxTaskWorkGroupInvocations;

    /// <summary>
    ///     maxTaskWorkGroupSize[3] is the     maximum size of a local task workgroup, per dimension.     These three
    ///     values represent the maximum local workgroup size in the X,     Y, and Z dimensions, respectively.     The x, y,
    ///     and z sizes, as specified by the     LocalSizeor LocalSizeId    execution mode or by the object decorated by the
    ///     WorkgroupSize    decoration in shader modules, must be less than or equal to the     corresponding limit.
    /// </summary>
    public VkArray3<uint> maxTaskWorkGroupSize;

    /// <summary>
    ///     maxTaskPayloadSize is the maximum total storage size, in bytes, available for variables declared with the
    ///     TaskPayloadWorkgroupEXT storage class in shader modules in the task shader stage.
    /// </summary>
    public uint maxTaskPayloadSize;

    /// <summary>
    ///     maxTaskSharedMemorySize is the maximum total storage size, in bytes, available for variables declared with
    ///     the Workgroup storage class in shader modules in the task shader stage.
    /// </summary>
    public uint maxTaskSharedMemorySize;

    /// <summary>
    ///     maxTaskPayloadAndSharedMemorySize is the maximum total storage size, in bytes, available for variables that
    ///     are declared with the TaskPayloadWorkgroupEXT or Workgroup storage class, in shader modules in the task shader
    ///     stage.
    /// </summary>
    public uint maxTaskPayloadAndSharedMemorySize;

    /// <summary>
    ///     maxMeshWorkGroupTotalCountis the maximum number of local output tasks a single task shader workgroup can
    ///     emit.
    /// </summary>
    public uint maxMeshWorkGroupTotalCount;

    /// <summary>
    ///     maxMeshWorkGroupCount[3] is the maximum number of local output tasks a single task shader workgroup can emit,
    ///     per dimension. These three values represent the maximum number of local output tasks for the X, Y, and Z
    ///     dimensions, respectively. The workgroup count parameters to the OpEmitMeshTasksEXT must be less than or equal to
    ///     the corresponding limit. The product of these dimensions must be less than or equal to maxMeshWorkGroupTotalCount.
    /// </summary>
    public VkArray3<uint> maxMeshWorkGroupCount;

    /// <summary>
    ///     maxMeshWorkGroupInvocations    is the maximum total number of mesh shader invocations in a single local
    ///     workgroup.     The product of the X, Y, and Z sizes, as specified by the LocalSizeor LocalSizeId    execution mode
    ///     in shader modules or by the object decorated by the     WorkgroupSize decoration, must be less than or equal to
    ///     this     limit.
    /// </summary>
    public uint maxMeshWorkGroupInvocations;

    /// <summary>
    ///     maxMeshWorkGroupSize[3] is the     maximum size of a local mesh workgroup, per dimension.     These three
    ///     values represent the maximum local workgroup size in the X,     Y, and Z dimensions, respectively.     The x, y,
    ///     and z sizes, as specified by the     LocalSizeor LocalSizeId    execution mode or by the object decorated by the
    ///     WorkgroupSize    decoration in shader modules, must be less than or equal to the     corresponding limit.
    /// </summary>
    public VkArray3<uint> maxMeshWorkGroupSize;

    /// <summary>
    ///     maxMeshSharedMemorySize is the maximum total storage size, in bytes, available for variables declared with
    ///     the Workgroup storage class in shader modules in the mesh shader stage.
    /// </summary>
    public uint maxMeshSharedMemorySize;

    /// <summary>
    ///     maxMeshPayloadAndSharedMemorySize is the maximum total storage size, in bytes, available for variables that
    ///     are declared with the TaskPayloadWorkgroupEXT or Workgroup storage class in shader modules in the mesh shader
    ///     stage.
    /// </summary>
    public uint maxMeshPayloadAndSharedMemorySize;

    /// <summary>
    ///     maxMeshOutputMemorySize is the maximum total storage size, in bytes, available for output variables in shader
    ///     modules in the mesh shader stage, according to the formula in Mesh Shader Output.
    /// </summary>
    public uint maxMeshOutputMemorySize;

    /// <summary>
    ///     maxMeshPayloadAndOutputMemorySize is the maximum total storage size, in bytes, available for variables that
    ///     are declared with the TaskPayloadWorkgroupEXT storage class, or output variables in shader modules in the mesh
    ///     shader stage, according to the formula in Mesh Shader Output.
    /// </summary>
    public uint maxMeshPayloadAndOutputMemorySize;

    /// <summary>
    ///     maxMeshOutputComponents is the maximum number of components of output variables which can be output from the
    ///     mesh shader stage.
    /// </summary>
    public uint maxMeshOutputComponents;

    /// <summary>
    ///     maxMeshOutputVertices is the maximum number of vertices which can be emitted by a single mesh shader
    ///     workgroup.
    /// </summary>
    public uint maxMeshOutputVertices;

    /// <summary>
    ///     maxMeshOutputPrimitives is the maximum number of primitives which can be emitted by a single mesh shader
    ///     workgroup.
    /// </summary>
    public uint maxMeshOutputPrimitives;

    /// <summary>
    ///     maxMeshOutputLayers is one greater than the maximum layer index that can be output from the mesh shader
    ///     stage.
    /// </summary>
    public uint maxMeshOutputLayers;

    /// <summary> maxMeshMultiviewViewCount is one greater than the maximum view index that can be used by any mesh shader.</summary>
    public uint maxMeshMultiviewViewCount;

    /// <summary>
    ///     meshOutputPerVertexGranularity is the granularity of vertex allocation. The number of output vertices
    ///     allocated for the mesh shader stage is padded to a multiple of this number. The value can be used to calculate the
    ///     required storage size for output variables in shader modules in the mesh shader stage, which must be less than or
    ///     equal to maxMeshOutputMemorySize.
    /// </summary>
    public uint meshOutputPerVertexGranularity;

    /// <summary>
    ///     meshOutputPerPrimitiveGranularity is the granularity of primitive allocation. The number of output primitives
    ///     allocated for the mesh shader stage is padded to a multiple of this number. The value can be used to calculate the
    ///     required storage size for output variables in shader modules in the mesh shader stage, which must be less than or
    ///     equal to maxMeshOutputMemorySize.
    /// </summary>
    public uint meshOutputPerPrimitiveGranularity;

    /// <summary>
    ///     maxPreferredTaskWorkGroupInvocations is the maximum number of task shader invocations in a single workgroup
    ///     that is preferred by the implementation for optimal performance. The value is guaranteed to be a multiple of a
    ///     supported subgroup size for the task shader stage.
    /// </summary>
    public uint maxPreferredTaskWorkGroupInvocations;

    /// <summary>
    ///     maxPreferredMeshWorkGroupInvocations is the maximum number of mesh shader invocations in a single workgroup
    ///     that is preferred by the implementation for optimal performance. The value is guaranteed to be a multiple of a
    ///     supported subgroup size for the mesh shader stage.
    /// </summary>
    public uint maxPreferredMeshWorkGroupInvocations;

    /// <summary>
    ///     prefersLocalInvocationVertexOutput specifies whether writes to the vertex output array in a mesh shader yield
    ///     best performance when the array index matches LocalInvocationIndex.
    /// </summary>
    public VkBool32 prefersLocalInvocationVertexOutput;

    /// <summary>
    ///     prefersLocalInvocationPrimitiveOutput specifies whether writes to the primitive output array in a mesh shader
    ///     yield best performance when the array index matches LocalInvocationIndex.
    /// </summary>
    public VkBool32 prefersLocalInvocationPrimitiveOutput;

    /// <summary>
    ///     prefersCompactVertexOutputspecifies whether output vertices should be compacted after custom culling in the
    ///     mesh shader for best performance, otherwise keeping the vertices at their original location may be better.
    /// </summary>
    public VkBool32 prefersCompactVertexOutput;

    /// <summary>
    ///     prefersCompactPrimitiveOutput specifies whether output primitives should be compacted after custom culling in
    ///     the mesh shader for best performance, otherwise the use of CullPrimitiveEXT may be better.
    /// </summary>
    public VkBool32 prefersCompactPrimitiveOutput;
}