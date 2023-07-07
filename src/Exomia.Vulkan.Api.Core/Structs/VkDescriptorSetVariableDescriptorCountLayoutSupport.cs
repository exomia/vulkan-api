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
///     VkDescriptorSetVariableDescriptorCountLayoutSupport - Structure returning information about whether a descriptor
///     set layout can be supported -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetVariableDescriptorCountLayoutSupport.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetVariableDescriptorCountLayoutSupport.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkDescriptorSetLayoutSupport</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkDescriptorSetLayoutSupport")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxVariableDescriptorCount indicates the maximum number of descriptors supported in the highest numbered
    ///     binding of the layout, if that binding is variable-sized. If the highest numbered binding of the layout has a
    ///     descriptor type of VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then maxVariableDescriptorCount indicates the maximum
    ///     byte size supported for the binding, if that binding is variable-sized.
    /// </summary>
    public uint maxVariableDescriptorCount;
}