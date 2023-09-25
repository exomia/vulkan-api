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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkPhysicalDeviceShaderEnqueuePropertiesAMDX - Structure describing shader enqueue limits of an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderEnqueuePropertiesAMDX.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderEnqueuePropertiesAMDX.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderEnqueuePropertiesAMDX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ENQUEUE_PROPERTIES_AMDX;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxExecutionGraphDepth defines the maximum node chain depth in the graph. The dispatched node is at depth 1
    ///     and the node enqueued by it is at depth 2, and so on. If a node enqueues itself, each recursive enqueue increases
    ///     the depth by 1 as well.
    /// </summary>
    public uint maxExecutionGraphDepth;

    /// <summary>
    ///     maxExecutionGraphShaderOutputNodes specifies the maximum number of unique nodes that can be dispatched from a
    ///     single shader, and must be at least 256.
    /// </summary>
    public uint maxExecutionGraphShaderOutputNodes;

    /// <summary>
    ///     maxExecutionGraphShaderPayloadSize specifies the maximum total size of payload declarations in a shader. For
    ///     any payload declarations that share resources, indicated by NodeSharesPayloadLimitsWithAMDX decorations, the
    ///     maximum size of each set of shared payload declarations is taken. The sum of each shared set&#8217;s maximum size
    ///     and the size of each unshared payload is counted against this limit.
    /// </summary>
    public uint maxExecutionGraphShaderPayloadSize;

    /// <summary>
    ///     maxExecutionGraphShaderPayloadCount specifies the maximum number of output payloads that can be initialized in
    ///     a single workgroup.
    /// </summary>
    public uint maxExecutionGraphShaderPayloadCount;

    /// <summary>
    ///     executionGraphDispatchAddressAlignment specifies the alignment of non-scratch VkDeviceAddress arguments
    ///     consumed by graph dispatch commands.
    /// </summary>
    public uint executionGraphDispatchAddressAlignment;
}