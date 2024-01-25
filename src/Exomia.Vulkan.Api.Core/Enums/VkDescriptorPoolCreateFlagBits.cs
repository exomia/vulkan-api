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
///     VkDescriptorPoolCreateFlagBits - Bitmask specifying certain supported operations on a descriptor pool -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkDescriptorPoolCreateFlagBits
{
    /// <summary>
    ///     VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT specifies that descriptor sets can return their individual
    ///     allocations to the pool, i.e. all of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAllocateDescriptorSets.html">vkAllocateDescriptorSets</a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFreeDescriptorSets.html">vkFreeDescriptorSets</a>
    ///     , and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetDescriptorPool.html">vkResetDescriptorPool</a>
    ///     are allowed. Otherwise, descriptor sets allocated from the pool must not be individually freed back to the pool,
    ///     i.e. only
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAllocateDescriptorSets.html">vkAllocateDescriptorSets</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetDescriptorPool.html">vkResetDescriptorPool</a>
    ///     are allowed.
    /// </summary>
    VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT = 0x1,

    /// <summary>
    ///     VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT specifies that descriptor sets allocated from this pool can
    ///     include bindings with the VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT bit set. It is valid to allocate descriptor
    ///     sets that have bindings that do not set the VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT bit from a pool that has
    ///     VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT set.
    /// </summary>
    VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT = 0x2,

    /// <summary>
    ///     VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT specifies that this descriptor pool and the descriptor sets allocated
    ///     from it reside entirely in host memory and cannot be bound. Similar to descriptor sets allocated without this flag,
    ///     applications can copy-from and copy-to descriptors sets allocated from this descriptor pool. Descriptor sets
    ///     allocated from this pool are partially exempt from the external synchronization requirement in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html">
    ///         vkUpdateDescriptorSetWithTemplateKHR
    ///     </a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html">vkUpdateDescriptorSets</a>
    ///     . Descriptor sets and their descriptors can be updated concurrently in different threads, though the same
    ///     descriptor must not be updated concurrently by two threads.
    /// </summary>
    VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_SETS_BIT_NVspecifies that the implementation should allow the
    ///     application to allocate more than
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolCreateInfo.html">VkDescriptorPoolCreateInfo</a>
    ///     ::maxSetsdescriptor set objects from the descriptor pool as available resources allow. The implementation may use
    ///     the maxSets value to allocate the initial available sets, but using zero is permitted.
    /// </summary>
    VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_SETS_BIT_NV = 0x8,

    /// <summary>
    ///     VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_POOLS_BIT_NVspecifies that the implementation should allow the
    ///     application to allocate more descriptors from the pool than was specified by the
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolSize.html">VkDescriptorPoolSize</a>
    ///     ::descriptorCount for any descriptor type as specified by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolCreateInfo.html">VkDescriptorPoolCreateInfo</a>
    ///     ::poolSizeCount and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolCreateInfo.html">VkDescriptorPoolCreateInfo</a>
    ///     ::pPoolSizes, as available resources allow. The implementation may use the descriptorCount for each descriptor type
    ///     to allocate the initial pool, but the application is allowed to set the poolSizeCount to zero, or any of the
    ///     descriptorCount values in the pPoolSizes array to zero.
    /// </summary>
    VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_POOLS_BIT_NV = 0x10,

    /// <summary>
    ///     VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT specifies that descriptor sets allocated from this pool can
    ///     include bindings with the VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT bit set. It is valid to allocate descriptor
    ///     sets that have bindings that do not set the VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT bit from a pool that has
    ///     VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT set.
    /// </summary>
    VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT = VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT,

    /// <summary>
    ///     VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT specifies that this descriptor pool and the descriptor sets allocated
    ///     from it reside entirely in host memory and cannot be bound. Similar to descriptor sets allocated without this flag,
    ///     applications can copy-from and copy-to descriptors sets allocated from this descriptor pool. Descriptor sets
    ///     allocated from this pool are partially exempt from the external synchronization requirement in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html">
    ///         vkUpdateDescriptorSetWithTemplateKHR
    ///     </a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html">vkUpdateDescriptorSets</a>
    ///     . Descriptor sets and their descriptors can be updated concurrently in different threads, though the same
    ///     descriptor must not be updated concurrently by two threads.
    /// </summary>
    VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE = VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT
}