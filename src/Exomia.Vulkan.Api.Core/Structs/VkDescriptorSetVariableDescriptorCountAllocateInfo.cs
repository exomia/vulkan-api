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
///     VkDescriptorSetVariableDescriptorCountAllocateInfo - Structure specifying additional allocation parameters for
///     descriptor sets -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetVariableDescriptorCountAllocateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetVariableDescriptorCountAllocateInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkDescriptorSetAllocateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkDescriptorSetAllocateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>descriptorSetCount is zero or the number of elements in pDescriptorCounts.</summary>
    public uint descriptorSetCount;

    /// <summary>
    ///     pDescriptorCounts is a pointer to an array of descriptor counts, with each member specifying the number of
    ///     descriptors in a variable-sized descriptor binding in the corresponding descriptor set being allocated.
    /// </summary>
    public uint* pDescriptorCounts;
}