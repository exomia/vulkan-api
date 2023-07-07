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
///     VkMutableDescriptorTypeCreateInfoEXT - Structure describing the list of possible active descriptor types for
///     mutable type descriptors -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMutableDescriptorTypeCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMutableDescriptorTypeCreateInfoEXT.html
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
public unsafe struct VkMutableDescriptorTypeCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>mutableDescriptorTypeListCount is the number of elements in pMutableDescriptorTypeLists.</summary>
    public uint mutableDescriptorTypeListCount;

    /// <summary>pMutableDescriptorTypeLists is a pointer to an array of VkMutableDescriptorTypeListEXT structures.</summary>
    public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
}