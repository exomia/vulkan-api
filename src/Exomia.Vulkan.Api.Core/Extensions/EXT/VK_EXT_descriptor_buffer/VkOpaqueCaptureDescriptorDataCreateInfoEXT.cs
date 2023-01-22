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
///     VkOpaqueCaptureDescriptorDataCreateInfoEXT - Structure specifying opaque capture descriptor data -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpaqueCaptureDescriptorDataCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpaqueCaptureDescriptorDataCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkBufferCreateInfo,VkImageCreateInfo,VkImageViewCreateInfo,VkSamplerCreateInfo,VkAccelerationStructureCreateInfoKHR,VkAccelerationStructureCreateInfoNV</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBufferCreateInfo,VkImageCreateInfo,VkImageViewCreateInfo,VkSamplerCreateInfo,VkAccelerationStructureCreateInfoKHR,VkAccelerationStructureCreateInfoNV")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     opaqueCaptureDescriptorData is a pointer to a user-allocated buffer containing opaque capture data retrieved
    ///     using vkGetBufferOpaqueCaptureDescriptorDataEXT, vkGetImageOpaqueCaptureDescriptorDataEXT,
    ///     vkGetImageViewOpaqueCaptureDescriptorDataEXT, vkGetSamplerOpaqueCaptureDescriptorDataEXT, or
    ///     vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT.
    /// </summary>
    public void* opaqueCaptureDescriptorData;
}