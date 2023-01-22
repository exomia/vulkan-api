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
///     VkDescriptorSetLayoutBindingFlagsCreateInfo - Structure specifying creation flags for descriptor set layout
///     bindings -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutBindingFlagsCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutBindingFlagsCreateInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkDescriptorSetLayoutCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkDescriptorSetLayoutCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>bindingCount is zero or the number of elements in pBindingFlags.</summary>
    public uint bindingCount;

    /// <summary>
    ///     pBindingFlags is a pointer to an array of VkDescriptorBindingFlags bitfields, one for each descriptor set
    ///     layout binding.
    /// </summary>
    public VkDescriptorBindingFlags* pBindingFlags;
}