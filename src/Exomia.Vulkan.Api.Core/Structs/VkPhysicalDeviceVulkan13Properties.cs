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
///     VkPhysicalDeviceVulkan13Properties - Structure specifying physical device properties for functionality
///     promoted to Vulkan 1.3 -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan13Properties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan13Properties.html
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
public unsafe struct VkPhysicalDeviceVulkan13Properties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_PROPERTIES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     minSubgroupSize is the minimum subgroup size supported by this device. minSubgroupSize is at least one if any
    ///     of the physical device&#8217;s queues support VK_QUEUE_GRAPHICS_BIT or VK_QUEUE_COMPUTE_BIT. minSubgroupSize is a
    ///     power-of-two. minSubgroupSize is less than or equal to maxSubgroupSize. minSubgroupSize is less than or equal to
    ///     subgroupSize.
    /// </summary>
    public uint minSubgroupSize;

    /// <summary>
    ///     minSubgroupSize is the minimum subgroup size supported by this device. minSubgroupSize is at least one if any
    ///     of the physical device&#8217;s queues support VK_QUEUE_GRAPHICS_BIT or VK_QUEUE_COMPUTE_BIT. minSubgroupSize is a
    ///     power-of-two. minSubgroupSize is less than or equal to maxSubgroupSize. minSubgroupSize is less than or equal to
    ///     subgroupSize.
    /// </summary>
    public uint maxSubgroupSize;

    /// <summary>
    ///     maxComputeWorkgroupSubgroups is the maximum number of subgroups supported by the implementation within a
    ///     workgroup.
    /// </summary>
    public uint maxComputeWorkgroupSubgroups;

    /// <summary>
    ///     requiredSubgroupSizeStages is a bitfield of what shader stages support having a required subgroup size
    ///     specified.
    /// </summary>
    public VkShaderStageFlags requiredSubgroupSizeStages;

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

    /// <summary>
    ///     maxInlineUniformTotalSize is the maximum total size in bytes of all inline uniform block bindings, across all
    ///     pipeline shader stages and descriptor set numbers, that can be included in a pipeline layout. Descriptor bindings
    ///     with a descriptor type of VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK count against this limit.
    /// </summary>
    public uint maxInlineUniformTotalSize;

    /// <summary>
    ///     integerDotProduct8BitUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 8-bit unsigned
    ///     dot product operations using the OpUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct8BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct8BitSignedAccelerated is a boolean that will be VK_TRUE if the support for 8-bit signed dot
    ///     product operations using the OpSDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct8BitSignedAccelerated;

    /// <summary>
    ///     integerDotProduct8BitMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for 8-bit
    ///     mixed signedness dot product operations using the OpSUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProduct4x8BitPackedUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 8-bit
    ///     unsigned dot product operations from operands packed into 32-bit integers using the OpUDotKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct4x8BitPackedSignedAccelerated is a boolean that will be VK_TRUE if the support for 8-bit
    ///     signed dot product operations from operands packed into 32-bit integers using the OpSDotKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;

    /// <summary>
    ///     integerDotProduct4x8BitPackedMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for
    ///     8-bit mixed signedness dot product operations from operands packed into 32-bit integers using the OpSUDotKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProduct16BitUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 16-bit unsigned
    ///     dot product operations using the OpUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct16BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct16BitSignedAccelerated is a boolean that will be VK_TRUE if the support for 16-bit signed dot
    ///     product operations using the OpSDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct16BitSignedAccelerated;

    /// <summary>
    ///     integerDotProduct16BitMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for 16-bit
    ///     mixed signedness dot product operations using the OpSUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProduct32BitUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 32-bit unsigned
    ///     dot product operations using the OpUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct32BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct32BitSignedAccelerated is a boolean that will be VK_TRUE if the support for 32-bit signed dot
    ///     product operations using the OpSDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct32BitSignedAccelerated;

    /// <summary>
    ///     integerDotProduct32BitMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for 32-bit
    ///     mixed signedness dot product operations using the OpSUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProduct64BitUnsignedAccelerated is a boolean that will be VK_TRUE if the support for 64-bit unsigned
    ///     dot product operations using the OpUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct64BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProduct64BitSignedAccelerated is a boolean that will be VK_TRUE if the support for 64-bit signed dot
    ///     product operations using the OpSDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct64BitSignedAccelerated;

    /// <summary>
    ///     integerDotProduct64BitMixedSignednessAccelerated is a boolean that will be VK_TRUE if the support for 64-bit
    ///     mixed signedness dot product operations using the OpSUDotKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating8BitUnsignedAccelerated is a boolean that will be VK_TRUE if the
    ///     support for 8-bit unsigned accumulating saturating dot product operations using the OpUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating8BitSignedAccelerated is a boolean that will be VK_TRUE if the support
    ///     for 8-bit signed accumulating saturating dot product operations using the OpSDotAccSatKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating8BitMixedSignednessAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 8-bit mixed signedness accumulating saturating dot product operations using the OpSUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 8-bit unsigned accumulating saturating dot product operations from operands packed into 32-bit integers
    ///     using the OpUDotAccSatKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating4x8BitPackedSignedAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 8-bit signed accumulating saturating dot product operations from operands packed into 32-bit integers
    ///     using the OpSDotAccSatKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAcceleratedis a boolean that will be VK_TRUE
    ///     if the support for 8-bit mixed signedness accumulating saturating dot product operations from operands packed into
    ///     32-bit integers using the OpSUDotAccSatKHR SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating16BitUnsignedAccelerated is a boolean that will be VK_TRUE if the
    ///     support for 16-bit unsigned accumulating saturating dot product operations using the OpUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating16BitSignedAccelerated is a boolean that will be VK_TRUE if the support
    ///     for 16-bit signed accumulating saturating dot product operations using the OpSDotAccSatKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating16BitMixedSignednessAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 16-bit mixed signedness accumulating saturating dot product operations using the OpSUDotAccSatKHR
    ///     SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating32BitUnsignedAccelerated is a boolean that will be VK_TRUE if the
    ///     support for 32-bit unsigned accumulating saturating dot product operations using the OpUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating32BitSignedAccelerated is a boolean that will be VK_TRUE if the support
    ///     for 32-bit signed accumulating saturating dot product operations using the OpSDotAccSatKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating32BitMixedSignednessAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 32-bit mixed signedness accumulating saturating dot product operations using the OpSUDotAccSatKHR
    ///     SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating64BitUnsignedAccelerated is a boolean that will be VK_TRUE if the
    ///     support for 64-bit unsigned accumulating saturating dot product operations using the OpUDotAccSatKHR SPIR-V
    ///     instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating64BitSignedAccelerated is a boolean that will be VK_TRUE if the support
    ///     for 64-bit signed accumulating saturating dot product operations using the OpSDotAccSatKHR SPIR-V instruction is
    ///     accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;

    /// <summary>
    ///     integerDotProductAccumulatingSaturating64BitMixedSignednessAcceleratedis a boolean that will be VK_TRUE if the
    ///     support for 64-bit mixed signedness accumulating saturating dot product operations using the OpSUDotAccSatKHR
    ///     SPIR-V instruction is accelerated as defined below.
    /// </summary>
    public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;

    /// <summary>
    ///     storageTexelBufferOffsetAlignmentBytes is a byte alignment that is sufficient for a storage texel buffer of
    ///     any format. The value must be a power of two.
    /// </summary>
    public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;

    /// <summary>
    ///     storageTexelBufferOffsetSingleTexelAlignment indicates whether single texel alignment is sufficient for a
    ///     storage texel buffer of any format.
    /// </summary>
    public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;

    /// <summary>
    ///     uniformTexelBufferOffsetAlignmentBytes is a byte alignment that is sufficient for a uniform texel buffer of
    ///     any format. The value must be a power of two.
    /// </summary>
    public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;

    /// <summary>
    ///     uniformTexelBufferOffsetSingleTexelAlignment indicates whether single texel alignment is sufficient for a
    ///     uniform texel buffer of any format.
    /// </summary>
    public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;

    /// <summary> maxBufferSize is the maximum size VkBuffer that can be created.</summary>
    public VkDeviceSize maxBufferSize;
}