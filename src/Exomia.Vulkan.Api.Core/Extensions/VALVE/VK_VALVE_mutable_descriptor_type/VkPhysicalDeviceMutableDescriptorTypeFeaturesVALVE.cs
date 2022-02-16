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
///     VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE - Structure describing whether the mutable descriptor type is
///     supported -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     mutableDescriptorType indicates that the implementation must support using the VkDescriptorTypeof
    ///     VK_DESCRIPTOR_TYPE_MUTABLE_VALVE with at least the following descriptor types, where any combination of the types
    ///     must be
    ///     supported:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGEVK_DESCRIPTOR_TYPE_STORAGE_IMAGEVK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFERVK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFERVK_DESCRIPTOR_TYPE_UNIFORM_BUFFERVK_DESCRIPTOR_TYPE_STORAGE_BUFFER
    /// </summary>
    public VkBool32 mutableDescriptorType;
}