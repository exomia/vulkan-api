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
///     VkDescriptorBindingFlagBits - Bitmask specifying descriptor set layout binding properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorBindingFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorBindingFlagBits.html</a>
/// </summary>
[Flags]
public enum VkDescriptorBindingFlagBits
{
    /// <summary>
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT specifies that if descriptors in this binding are updated between when
    ///     the descriptor set is bound in a command buffer and when that command buffer is submitted to a queue, then the
    ///     submission will use the most recently set descriptors for this binding and the updates do not invalidate the
    ///     command buffer. Descriptor bindings created with this flag are also partially exempt from the external
    ///     synchronization requirement in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html">
    ///         vkUpdateDescriptorSetWithTemplateKHR
    ///     </a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html">vkUpdateDescriptorSets</a>
    ///     . Multiple descriptors with this flag set can be updated concurrently in different threads, though the same
    ///     descriptor must not be updated concurrently by two threads. Descriptors with this flag set can be updated
    ///     concurrently with the set being bound to a command buffer in another thread, but not concurrently with the set
    ///     being reset or freed.
    /// </summary>
    VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT = 0x1,

    /// <summary>
    ///     VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT specifies that descriptors in this binding can be updated
    ///     after a command buffer has bound this descriptor set, or while a command buffer that uses this descriptor set is
    ///     pending execution, as long as the descriptors that are updated are not used by those command buffers. Descriptor
    ///     bindings created with this flag are also partially exempt from the external synchronization requirement in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html">
    ///         vkUpdateDescriptorSetWithTemplateKHR
    ///     </a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html">vkUpdateDescriptorSets</a>
    ///     in the same way as for VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT. If VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT is
    ///     also set, then descriptors can be updated as long as they are not dynamically used by any shader invocations. If
    ///     VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT is not set, then descriptors can be updated as long as they are not
    ///     statically used by any shader invocations.
    /// </summary>
    VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT = 0x2,

    /// <summary>
    ///     VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT specifies that descriptors in this binding that are not dynamically
    ///     used need not contain valid descriptors at the time the descriptors are consumed. A descriptor is dynamically used
    ///     if any shader invocation executes an instruction that performs any memory access using the descriptor. If a
    ///     descriptor is not dynamically used, any resource referenced by the descriptor is not considered to be referenced
    ///     during command execution.
    /// </summary>
    VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT = 0x4,

    /// <summary>
    ///     VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT specifies that     this is a variable-sized descriptor binding
    ///     whose size will be     specified when a descriptor set is allocated using this layout.     The value of
    ///     descriptorCount is treated as an upper bound on the     size of the binding.     This must only be used for the
    ///     last binding in the descriptor set     layout (i.e. the binding with the largest value of binding).     For the
    ///     purposes of counting against limits such as     maxDescriptorSet* and maxPerStageDescriptor*, the full value     of
    ///     descriptorCount is     counted, except for descriptor bindings with a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK, when
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutCreateInfo.html">
    ///         VkDescriptorSetLayoutCreateInfo
    ///     </a>
    ///     ::flags does not contain     VK_DESCRIPTOR_SET_LAYOUT_CREATE_DESCRIPTOR_BUFFER_BIT_EXT.     In this case,
    ///     descriptorCount specifies the upper bound on the     byte size of the binding; thus it counts against the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#limits-maxInlineUniformBlockSize">
    ///         <code>maxInlineUniformBlockSize</code>
    ///     </a>
    ///     and
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#limits-maxInlineUniformTotalSize">
    ///         <code>maxInlineUniformTotalSize</code>
    ///     </a>
    ///     limits instead.
    /// </summary>
    VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT = 0x8,

    /// <summary>
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT specifies that if descriptors in this binding are updated between when
    ///     the descriptor set is bound in a command buffer and when that command buffer is submitted to a queue, then the
    ///     submission will use the most recently set descriptors for this binding and the updates do not invalidate the
    ///     command buffer. Descriptor bindings created with this flag are also partially exempt from the external
    ///     synchronization requirement in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html">
    ///         vkUpdateDescriptorSetWithTemplateKHR
    ///     </a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html">vkUpdateDescriptorSets</a>
    ///     . Multiple descriptors with this flag set can be updated concurrently in different threads, though the same
    ///     descriptor must not be updated concurrently by two threads. Descriptors with this flag set can be updated
    ///     concurrently with the set being bound to a command buffer in another thread, but not concurrently with the set
    ///     being reset or freed.
    /// </summary>
    VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT = VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT,

    /// <summary>
    ///     VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT specifies that descriptors in this binding can be updated
    ///     after a command buffer has bound this descriptor set, or while a command buffer that uses this descriptor set is
    ///     pending execution, as long as the descriptors that are updated are not used by those command buffers. Descriptor
    ///     bindings created with this flag are also partially exempt from the external synchronization requirement in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html">
    ///         vkUpdateDescriptorSetWithTemplateKHR
    ///     </a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html">vkUpdateDescriptorSets</a>
    ///     in the same way as for VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT. If VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT is
    ///     also set, then descriptors can be updated as long as they are not dynamically used by any shader invocations. If
    ///     VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT is not set, then descriptors can be updated as long as they are not
    ///     statically used by any shader invocations.
    /// </summary>
    VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT_EXT = VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT,

    /// <summary>
    ///     VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT specifies that descriptors in this binding that are not dynamically
    ///     used need not contain valid descriptors at the time the descriptors are consumed. A descriptor is dynamically used
    ///     if any shader invocation executes an instruction that performs any memory access using the descriptor. If a
    ///     descriptor is not dynamically used, any resource referenced by the descriptor is not considered to be referenced
    ///     during command execution.
    /// </summary>
    VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT = VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT,

    /// <summary>
    ///     VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT specifies that     this is a variable-sized descriptor binding
    ///     whose size will be     specified when a descriptor set is allocated using this layout.     The value of
    ///     descriptorCount is treated as an upper bound on the     size of the binding.     This must only be used for the
    ///     last binding in the descriptor set     layout (i.e. the binding with the largest value of binding).     For the
    ///     purposes of counting against limits such as     maxDescriptorSet* and maxPerStageDescriptor*, the full value     of
    ///     descriptorCount is     counted, except for descriptor bindings with a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK, when
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutCreateInfo.html">
    ///         VkDescriptorSetLayoutCreateInfo
    ///     </a>
    ///     ::flags does not contain     VK_DESCRIPTOR_SET_LAYOUT_CREATE_DESCRIPTOR_BUFFER_BIT_EXT.     In this case,
    ///     descriptorCount specifies the upper bound on the     byte size of the binding; thus it counts against the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#limits-maxInlineUniformBlockSize">
    ///         <code>maxInlineUniformBlockSize</code>
    ///     </a>
    ///     and
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#limits-maxInlineUniformTotalSize">
    ///         <code>maxInlineUniformTotalSize</code>
    ///     </a>
    ///     limits instead.
    /// </summary>
    VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT_EXT = VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT
}