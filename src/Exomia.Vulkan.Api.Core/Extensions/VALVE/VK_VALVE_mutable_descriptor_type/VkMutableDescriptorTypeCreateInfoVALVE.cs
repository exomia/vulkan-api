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
///     VkMutableDescriptorTypeCreateInfoVALVE - Structure describing the list of possible active descriptor types for
///     mutable type descriptors -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMutableDescriptorTypeCreateInfoVALVE.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMutableDescriptorTypeCreateInfoVALVE.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkDescriptorSetLayoutCreateInfo,VkDescriptorPoolCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkDescriptorSetLayoutCreateInfo,VkDescriptorPoolCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>mutableDescriptorTypeListCount is the number of elements in pMutableDescriptorTypeLists.</summary>
    public uint mutableDescriptorTypeListCount;

    /// <summary>pMutableDescriptorTypeLists is a pointer to an array of VkMutableDescriptorTypeListVALVE structures.</summary>
    public VkMutableDescriptorTypeListVALVE* pMutableDescriptorTypeLists;
}