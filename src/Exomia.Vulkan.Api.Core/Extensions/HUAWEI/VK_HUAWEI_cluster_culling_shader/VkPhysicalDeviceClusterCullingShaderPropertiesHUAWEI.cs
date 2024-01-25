#region License

// Copyright (c) 2018-2024, exomia
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
///     VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI - Structure describing cluster culling shader properties
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI.html
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
public unsafe struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxWorkGroupCount[3] is the maximum number of local workgroups that can be launched by a single command. These
    ///     three value represent the maximum local workgroup count in the X, Y and Z dimensions, respectively. In the current
    ///     implementation, the values of Y and Z are both implicitly set as one. groupCountX of DrawCluster command must be
    ///     less than or equal to maxWorkGroupCount[0].
    /// </summary>
    public VkArray3<uint> maxWorkGroupCount;

    /// <summary>
    ///     maxWorkGroupSize[3] is the maximum size of a local workgroup.     These three value represent the maximum
    ///     local workgroup size in the X, Y     and Z dimensions, respectively.     The x, y and z sizes, as specified by the
    ///     LocalSizeor LocalSizeId    execution mode or by the object decorated by the WorkgroupSize     decoration in shader
    ///     modules, must be less than or equal to the     corresponding limit.     In the current implementation, the maximum
    ///     workgroup size of the X     dimension is 32, the others are 1.
    /// </summary>
    public VkArray3<uint> maxWorkGroupSize;

    /// <summary>
    ///     maxOutputClusterCount is the maximum number of output cluster a single cluster culling shader workgroup can
    ///     emit.
    /// </summary>
    public uint maxOutputClusterCount;

    /// <summary>
    ///     indirectBufferOffsetAlignment indicates the alignment for cluster drawing command buffer stride.
    ///     vkCmdDrawClusterIndirectHUAWEI::offset must be a multiple of this value.
    /// </summary>
    public VkDeviceSize indirectBufferOffsetAlignment;
}