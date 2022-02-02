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
///     VkDescriptorSetLayoutCreateFlagBits - Bitmask specifying descriptor set layout properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutCreateFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutCreateFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkDescriptorSetLayoutCreateFlagBits
{
    /// <summary>
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BITspecifies that descriptor sets using this layout
    ///     must be allocated from a descriptor pool created with the VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT bit set.
    ///     Descriptor set layouts created with this bit set have alternate limits for the maximum number of descriptors
    ///     per-stage and per-pipeline layout. The non-UpdateAfterBind limits only count descriptors in sets created without
    ///     this flag. The UpdateAfterBind limits count all descriptors, but the limits may be higher than the
    ///     non-UpdateAfterBind limits.
    /// </summary>
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT = 1,

    /// <summary>
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR specifies that descriptor sets must not be allocated
    ///     using this layout, and descriptors are instead pushed by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetKHR.html">vkCmdPushDescriptorSetKHR</a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR = 0,

    /// <summary>
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_4_BIT_AMD<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDescriptorSetLayoutCreateFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDescriptorSetLayoutCreateFlagBits
    ///     </a>
    /// </summary>
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_4_BIT_AMD = 4,

    /// <summary>
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_3_BIT_AMD<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDescriptorSetLayoutCreateFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDescriptorSetLayoutCreateFlagBits
    ///     </a>
    /// </summary>
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_3_BIT_AMD = 3,

    /// <summary>
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE specifies that descriptor sets using this layout must
    ///     be allocated from a descriptor pool created with the VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE bit set.
    ///     Descriptor set layouts created with this bit have no expressable limit for maximum number of descriptors per-stage.
    ///     Host descriptor sets are limited only by available host memory, but maybe limited for implementation specific
    ///     reasons. Implementations may limit the number of supported descriptors to UpdateAfterBind limits or
    ///     non-UpdateAfterBind limits, whichever is larger.
    /// </summary>
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE = 2,

    /// <summary>
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BITspecifies that descriptor sets using this layout
    ///     must be allocated from a descriptor pool created with the VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT bit set.
    ///     Descriptor set layouts created with this bit set have alternate limits for the maximum number of descriptors
    ///     per-stage and per-pipeline layout. The non-UpdateAfterBind limits only count descriptors in sets created without
    ///     this flag. The UpdateAfterBind limits count all descriptors, but the limits may be higher than the
    ///     non-UpdateAfterBind limits.
    /// </summary>
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT = VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT
}