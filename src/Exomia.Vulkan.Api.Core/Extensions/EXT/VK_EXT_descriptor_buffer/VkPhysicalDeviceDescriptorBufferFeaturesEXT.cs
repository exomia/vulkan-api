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
///     VkPhysicalDeviceDescriptorBufferFeaturesEXT - Structure describing the descriptor buffer features that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorBufferFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorBufferFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     descriptorBuffer indicates that the implementation supports putting shader-accessible descriptors directly in
    ///     memory.
    /// </summary>
    public VkBool32 descriptorBuffer;

    /// <summary>
    ///     descriptorBufferCaptureReplay indicates that the implementation supports capture and replay when using
    ///     descriptor buffers. If this is VK_TRUE, all resources created with
    ///     VK_BUFFER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT,
    ///     VK_IMAGE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT,
    ///     VK_IMAGE_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT,
    ///     VK_SAMPLER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT, or
    ///     VK_ACCELERATION_STRUCTURE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXTmust be created before resources of the
    ///     same types without those flags.
    /// </summary>
    public VkBool32 descriptorBufferCaptureReplay;

    /// <summary>
    ///     descriptorBufferImageLayoutIgnored indicates that the implementation will ignore imageLayout in
    ///     VkDescriptorImageInfo when calling vkGetDescriptorEXT.
    /// </summary>
    public VkBool32 descriptorBufferImageLayoutIgnored;

    /// <summary>
    ///     descriptorBufferPushDescriptors indicates that the implementation supports using push descriptors with
    ///     descriptor buffers.
    /// </summary>
    public VkBool32 descriptorBufferPushDescriptors;
}