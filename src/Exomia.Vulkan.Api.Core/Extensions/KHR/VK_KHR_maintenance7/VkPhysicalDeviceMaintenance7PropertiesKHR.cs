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
///     VkPhysicalDeviceMaintenance7PropertiesKHR - Structure describing various implementation-defined properties
///     introduced with VK_KHR_maintenance7 -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance7PropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance7PropertiesKHR.html
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
public unsafe struct VkPhysicalDeviceMaintenance7PropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     robustFragmentShadingRateAttachmentAccess indicates whether the scaled size of a fragment shading rate
    ///     attachment can be less than the size of the render area. If robustFragmentShadingRateAttachmentAccess is VK_FALSE,
    ///     the size of the attachment multiplied by the texel size must be greater than or equal to the size of the render
    ///     area. If it is VK_TRUE and the fragment shading rate attachment was created with
    ///     VkImageSubresourceRange::baseMipLevel equal to 0, the scaled size can be smaller than the render area, and shading
    ///     rates for missing texels are defined by texel replacement for invalid texels.
    /// </summary>
    public VkBool32 robustFragmentShadingRateAttachmentAccess;

    /// <summary>
    ///     separateDepthStencilAttachmentAccess indicates support for writing to one aspect of a depth/stencil attachment
    ///     without performing read-modify-write operations on the other aspect. If this property is VK_TRUE, writes to one
    ///     aspect must not result in read-modify-write operations on the other aspect. If VK_FALSE, writes to one aspect may
    ///     result in writes to the other aspect as defined by render pass load operations, render pass store operations and
    ///     render pass resolve operations.
    /// </summary>
    public VkBool32 separateDepthStencilAttachmentAccess;

    /// <summary>
    ///     maxDescriptorSetTotalUniformBuffersDynamic is the maximum total count of dynamic uniform buffers that can be
    ///     included in a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against
    ///     this limit. Only descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. See
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbufferdynamic.
    /// </summary>
    public uint maxDescriptorSetTotalUniformBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetTotalStorageBuffersDynamic is the maximum total count of dynamic storage buffers that can be
    ///     included in a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against
    ///     this limit. Only descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. See
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebufferdynamic.
    /// </summary>
    public uint maxDescriptorSetTotalStorageBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetTotalBuffersDynamic is the maximum total count of dynamic uniform buffers and storage buffers
    ///     that can be included in a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC or
    ///     VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this limit. Only descriptors in descriptor set layouts
    ///     created without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit.
    /// </summary>
    public uint maxDescriptorSetTotalBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic is similar to
    ///     maxDescriptorSetTotalUniformBuffersDynamic but counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic is similar to
    ///     maxDescriptorSetTotalStorageBuffersDynamic but counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindTotalBuffersDynamic is similar to maxDescriptorSetTotalBuffersDynamic but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set. While an application can allocate dynamic
    ///     storage buffer descriptors from a pool created with the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT,
    ///     bindings for these descriptors must not be present in any descriptor set layout that includes bindings created with
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
}