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
///     VkPhysicalDeviceInlineUniformBlockProperties - Structure describing inline uniform block properties that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceInlineUniformBlockProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceInlineUniformBlockProperties.html
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
public unsafe struct VkPhysicalDeviceInlineUniformBlockProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>maxInlineUniformBlockSize is the maximum size in bytes of an inline uniform block binding.</summary>
    public uint maxInlineUniformBlockSize;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindInlineUniformBlocksis similar to maxPerStageDescriptorInlineUniformBlocks
    ///     but counts descriptor bindings from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorInlineUniformBlocks;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindInlineUniformBlocksis similar to maxPerStageDescriptorInlineUniformBlocks
    ///     but counts descriptor bindings from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;

    /// <summary>
    ///     maxDescriptorSetInlineUniformBlocks is the maximum number of inline uniform block bindings that can be
    ///     included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers.
    ///     Descriptor bindings with a descriptor type of VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK count against this limit.
    ///     Only descriptor bindings in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit.
    /// </summary>
    public uint maxDescriptorSetInlineUniformBlocks;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindInlineUniformBlocksis similar to maxDescriptorSetInlineUniformBlocks but counts
    ///     descriptor bindings from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}