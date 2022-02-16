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
///     VkDescriptorSetLayoutBinding - Structure specifying a descriptor set layout binding -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutBinding.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutBinding.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutBinding
{
    /// <summary>
    ///     binding is the binding number of this entry and corresponds to a resource of the same binding number in the
    ///     shader stages.
    /// </summary>
    public uint binding;

    /// <summary>descriptorType is a VkDescriptorType specifying which type of resource descriptors are used for this binding.</summary>
    public VkDescriptorType descriptorType;

    /// <summary>
    ///     descriptorCount is the number of descriptors contained in the binding, accessed in a shader as an array,
    ///     except if descriptorType is VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK in which case descriptorCount is the size in
    ///     bytes of the inline uniform block. If descriptorCount is zero this binding entry is reserved and the resource must
    ///     not be accessed from any stage via this binding within any pipeline using the set layout.
    /// </summary>
    public uint descriptorCount;

    /// <summary>
    ///     stageFlags member is a bitmask of VkShaderStageFlagBitsspecifying which pipeline shader stages can access a
    ///     resource for this binding. VK_SHADER_STAGE_ALL is a shorthand specifying that all defined shader stages, including
    ///     any additional stages defined by extensions, can access the resource.If a shader stage is not included in
    ///     stageFlags, then a resource mustnot be accessed from that stage via this binding within any pipeline using the set
    ///     layout. Other than input attachments which are limited to the fragment shader, there are no limitations on what
    ///     combinations of stages can use a descriptor binding, and in particular a binding can be used by both graphics
    ///     stages and the compute stage.
    /// </summary>
    public VkShaderStageFlags stageFlags;

    /// <summary>
    ///     pImmutableSamplers affects initialization of samplers. If descriptorType specifies a
    ///     VK_DESCRIPTOR_TYPE_SAMPLER or VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER type descriptor, then pImmutableSamplers
    ///     can be used to initialize a set of immutable samplers. Immutable samplers are permanently bound into the set layout
    ///     and mustnot be changed; updating a VK_DESCRIPTOR_TYPE_SAMPLER descriptor with immutable samplers is not allowed and
    ///     updates to a VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER descriptor with immutable samplers does not modify the
    ///     samplers (the image views are updated, but the sampler updates are ignored). If pImmutableSamplers is not NULL,
    ///     then it is a pointer to an array of sampler handles that will be copied into the set layout and used for the
    ///     corresponding binding. Only the sampler handles are copied; the sampler objects must not be destroyed before the
    ///     final use of the set layout and any descriptor pools and sets created using it. If pImmutableSamplers is NULL, then
    ///     the sampler slots are dynamic and sampler handles must be bound into descriptor sets using this layout. If
    ///     descriptorType is not one of these descriptor types, then pImmutableSamplers is ignored.
    /// </summary>
    public VkSampler* pImmutableSamplers;
}