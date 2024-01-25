#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkValveDescriptorSetHostMapping;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_VALVE_descriptor_set_host_mapping - device extension (nr. 421) - author 'VALVE' [platform '' | contact
///     'Hans-Kristian Arntzen @HansKristian-Work']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_VALVE_descriptor_set_host_mapping.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_VALVE_descriptor_set_host_mapping.html
///     </a>
/// </summary>
/// <remarks>
///     specialuse: d3demulation
/// </remarks>
[VkDepends("VK_KHR_get_physical_device_properties2")]
[VkSpecialuse("d3demulation")]
[VkDeviceExt]
public static unsafe class VkValveDescriptorSetHostMapping
{
    /// <summary> The spec version. </summary>
    public const uint VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_EXTENSION_NAME = "VK_VALVE_descriptor_set_host_mapping";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u565f\u4c41\u4556\u445f\u5345\u5243\u5049\u4f54\u5f52\u4553\u5f54\u4f48\u5453\u4d5f\u5041\u4950\u474e\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetDescriptorSetLayoutHostMappingInfoVALVE - Stub description of vkGetDescriptorSetLayoutHostMappingInfoVALVE -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutHostMappingInfoVALVE.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutHostMappingInfoVALVE.html
    ///     </a>
    /// </summary>
    /// <param name="device">
    ///     VUID-vkGetDescriptorSetLayoutHostMappingInfoVALVE-device-parameter device must be a valid
    ///     VkDevice handle
    /// </param>
    /// <param name="pBindingReference">
    ///     VUID-vkGetDescriptorSetLayoutHostMappingInfoVALVE-pBindingReference-parameter
    ///     pBindingReference must be a valid pointer to a valid VkDescriptorSetBindingReferenceVALVE structure
    /// </param>
    /// <param name="pHostMapping">
    ///     VUID-vkGetDescriptorSetLayoutHostMappingInfoVALVE-pHostMapping-parameter pHostMapping must
    ///     be a valid pointer to a VkDescriptorSetLayoutHostMappingInfoVALVE structure
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDescriptorSetBindingReferenceVALVE* /*pBindingReference*/,
        VkDescriptorSetLayoutHostMappingInfoVALVE* /*pHostMapping*/,
        void> vkGetDescriptorSetLayoutHostMappingInfoVALVE = null;

    /// <summary>
    ///     vkGetDescriptorSetHostMappingVALVE - Stub description of vkGetDescriptorSetHostMappingVALVE -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetHostMappingVALVE.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetHostMappingVALVE.html
    ///     </a>
    /// </summary>
    /// <param name="device"> VUID-vkGetDescriptorSetHostMappingVALVE-device-parameter device must be a valid VkDevice handle</param>
    /// <param name="descriptorSet">
    ///     VUID-vkGetDescriptorSetHostMappingVALVE-descriptorSet-parameter descriptorSet must be a
    ///     valid VkDescriptorSet handle
    /// </param>
    /// <param name="ppData">
    ///     VUID-vkGetDescriptorSetHostMappingVALVE-ppData-parameter ppData must be a valid pointer to a
    ///     pointer value
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDescriptorSet /*descriptorSet*/,
        void** /*ppData*/,
        void> vkGetDescriptorSetHostMappingVALVE = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetDescriptorSetLayoutHostMappingInfoVALVE</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDescriptorSetHostMappingVALVE</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void>* pvkGetDescriptorSetLayoutHostMappingInfoVALVE =
            &vkGetDescriptorSetLayoutHostMappingInfoVALVE)
        {
            *pvkGetDescriptorSetLayoutHostMappingInfoVALVE = (delegate*<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7365\u7263\u7069\u6f74\u5372\u7465\u614c\u6f79\u7475\u6f48\u7473\u614d\u7070\u6e69\u4967\u666e\u566f\u4c41\u4556\u0000");
        }

        fixed (delegate*<VkDevice, VkDescriptorSet, void**, void>* pvkGetDescriptorSetHostMappingVALVE = &vkGetDescriptorSetHostMappingVALVE)
        {
            *pvkGetDescriptorSetHostMappingVALVE = (delegate*<VkDevice, VkDescriptorSet, void**, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7365\u7263\u7069\u6f74\u5372\u7465\u6f48\u7473\u614d\u7070\u6e69\u5667\u4c41\u4556\u0000");
        }
    }
}