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
///     VkPhysicalDeviceVulkan12Properties - Structure specifying physical device properties for functionality
///     promoted to Vulkan 1.2 -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan12Properties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan12Properties.html
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
public unsafe struct VkPhysicalDeviceVulkan12Properties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>driverID is a unique identifier for the driver of the physical device.</summary>
    public VkDriverId driverID;

    /// <summary>
    ///     driverName is an array of VK_MAX_DRIVER_NAME_SIZE charcontaining a null-terminated UTF-8 string which is the
    ///     name of the driver.
    /// </summary>
    public fixed byte driverName[(int)VK_MAX_DRIVER_NAME_SIZE];

    /// <summary>
    ///     driverInfo is an array of VK_MAX_DRIVER_INFO_SIZE charcontaining a null-terminated UTF-8 string with
    ///     additional information about the driver.
    /// </summary>
    public fixed byte driverInfo[(int)VK_MAX_DRIVER_INFO_SIZE];

    /// <summary>
    ///     conformanceVersion is the latest version of the Vulkan conformance test that the implementor has successfully
    ///     tested this driver against prior to release (see VkConformanceVersion).
    /// </summary>
    public VkConformanceVersion conformanceVersion;

    /// <summary>
    ///     denormBehaviorIndependence is a VkShaderFloatControlsIndependence value indicating whether, and how, denorm
    ///     behavior can be set independently for different bit widths.
    /// </summary>
    public VkShaderFloatControlsIndependence denormBehaviorIndependence;

    /// <summary>
    ///     roundingModeIndependence is a VkShaderFloatControlsIndependence value indicating whether, and how, rounding
    ///     modes can be set independently for different bit widths.
    /// </summary>
    public VkShaderFloatControlsIndependence roundingModeIndependence;

    /// <summary>
    ///     shaderSignedZeroInfNanPreserveFloat16 is a boolean value indicating whether sign of a zero, Nans and ±∞ can be
    ///     preserved in 16-bit floating-point computations. It also indicates whether the SignedZeroInfNanPreserve execution
    ///     mode can be used for 16-bit floating-point types.
    /// </summary>
    public VkBool32 shaderSignedZeroInfNanPreserveFloat16;

    /// <summary>
    ///     shaderSignedZeroInfNanPreserveFloat32 is a boolean value indicating whether sign of a zero, Nans and ±∞ can be
    ///     preserved in 32-bit floating-point computations. It also indicates whether the SignedZeroInfNanPreserve execution
    ///     mode can be used for 32-bit floating-point types.
    /// </summary>
    public VkBool32 shaderSignedZeroInfNanPreserveFloat32;

    /// <summary>
    ///     shaderSignedZeroInfNanPreserveFloat64 is a boolean value indicating whether sign of a zero, Nans and ±∞ can be
    ///     preserved in 64-bit floating-point computations. It also indicates whether the SignedZeroInfNanPreserve execution
    ///     mode can be used for 64-bit floating-point types.
    /// </summary>
    public VkBool32 shaderSignedZeroInfNanPreserveFloat64;

    /// <summary>
    ///     shaderDenormPreserveFloat16 is a boolean value indicating whether denormals can be preserved in 16-bit
    ///     floating-point computations. It also indicates whether the DenormPreserve execution mode can be used for 16-bit
    ///     floating-point types.
    /// </summary>
    public VkBool32 shaderDenormPreserveFloat16;

    /// <summary>
    ///     shaderDenormPreserveFloat32 is a boolean value indicating whether denormals can be preserved in 32-bit
    ///     floating-point computations. It also indicates whether the DenormPreserve execution mode can be used for 32-bit
    ///     floating-point types.
    /// </summary>
    public VkBool32 shaderDenormPreserveFloat32;

    /// <summary>
    ///     shaderDenormPreserveFloat64 is a boolean value indicating whether denormals can be preserved in 64-bit
    ///     floating-point computations. It also indicates whether the DenormPreserve execution mode can be used for 64-bit
    ///     floating-point types.
    /// </summary>
    public VkBool32 shaderDenormPreserveFloat64;

    /// <summary>
    ///     shaderDenormFlushToZeroFloat16 is a boolean value indicating whether denormals can be flushed to zero in
    ///     16-bit floating-point computations. It also indicates whether the DenormFlushToZero execution mode canbe used for
    ///     16-bit floating-point types.
    /// </summary>
    public VkBool32 shaderDenormFlushToZeroFloat16;

    /// <summary>
    ///     shaderDenormFlushToZeroFloat32 is a boolean value indicating whether denormals can be flushed to zero in
    ///     32-bit floating-point computations. It also indicates whether the DenormFlushToZero execution mode canbe used for
    ///     32-bit floating-point types.
    /// </summary>
    public VkBool32 shaderDenormFlushToZeroFloat32;

    /// <summary>
    ///     shaderDenormFlushToZeroFloat64 is a boolean value indicating whether denormals can be flushed to zero in
    ///     64-bit floating-point computations. It also indicates whether the DenormFlushToZero execution mode canbe used for
    ///     64-bit floating-point types.
    /// </summary>
    public VkBool32 shaderDenormFlushToZeroFloat64;

    /// <summary>
    ///     shaderRoundingModeRTEFloat16 is a boolean value indicating whether an implementation supports the
    ///     round-to-nearest-even rounding mode for 16-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTE execution mode canbe used for 16-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTEFloat16;

    /// <summary>
    ///     shaderRoundingModeRTEFloat32 is a boolean value indicating whether an implementation supports the
    ///     round-to-nearest-even rounding mode for 32-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTE execution mode canbe used for 32-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTEFloat32;

    /// <summary>
    ///     shaderRoundingModeRTEFloat64 is a boolean value indicating whether an implementation supports the
    ///     round-to-nearest-even rounding mode for 64-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTE execution mode canbe used for 64-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTEFloat64;

    /// <summary>
    ///     shaderRoundingModeRTZFloat16 is a boolean value indicating whether an implementation supports the
    ///     round-towards-zero rounding mode for 16-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTZ execution mode canbe used for 16-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTZFloat16;

    /// <summary>
    ///     shaderRoundingModeRTZFloat32 is a boolean value indicating whether an implementation supports the
    ///     round-towards-zero rounding mode for 32-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTZ execution mode canbe used for 32-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTZFloat32;

    /// <summary>
    ///     shaderRoundingModeRTZFloat64 is a boolean value indicating whether an implementation supports the
    ///     round-towards-zero rounding mode for 64-bit floating-point arithmetic and conversion instructions. It also
    ///     indicates whether the RoundingModeRTZ execution mode canbe used for 64-bit floating-point types.
    /// </summary>
    public VkBool32 shaderRoundingModeRTZFloat64;

    /// <summary>
    ///     maxUpdateAfterBindDescriptorsInAllPools is the maximum number of descriptors (summed over all descriptor
    ///     types) that can be created across all pools that are created with the
    ///     VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT bit set. Pool creation may fail when this limit is exceeded, or
    ///     when the space this limit represents is unable to satisfy a pool creation due to fragmentation.
    /// </summary>
    public uint maxUpdateAfterBindDescriptorsInAllPools;

    /// <summary>
    ///     shaderUniformBufferArrayNonUniformIndexingNative is a boolean value indicating whether uniform buffer
    ///     descriptors natively support non-uniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that non-uniformly indexes an array of uniform buffers mayexecute multiple times in order to access all
    ///     the descriptors.
    /// </summary>
    public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;

    /// <summary>
    ///     shaderSampledImageArrayNonUniformIndexingNative is a boolean value indicating whether sampler and image
    ///     descriptors natively support non-uniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that non-uniformly indexes an array of samplers or images may execute multiple times in order to access
    ///     all the descriptors.
    /// </summary>
    public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;

    /// <summary>
    ///     shaderStorageBufferArrayNonUniformIndexingNative is a boolean value indicating whether storage buffer
    ///     descriptors natively support non-uniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that non-uniformly indexes an array of storage buffers mayexecute multiple times in order to access all
    ///     the descriptors.
    /// </summary>
    public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;

    /// <summary>
    ///     shaderStorageImageArrayNonUniformIndexingNative is a boolean value indicating whether storage image
    ///     descriptors natively support non-uniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that non-uniformly indexes an array of storage images mayexecute multiple times in order to access all
    ///     the descriptors.
    /// </summary>
    public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;

    /// <summary>
    ///     shaderInputAttachmentArrayNonUniformIndexingNative is a boolean value indicating whether input attachment
    ///     descriptors natively support non-uniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that non-uniformly indexes an array of input attachments may execute multiple times in order to access
    ///     all the descriptors.
    /// </summary>
    public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;

    /// <summary>
    ///     robustBufferAccessUpdateAfterBind is a boolean value indicating whether robustBufferAccess canbe enabled on a
    ///     device simultaneously with descriptorBindingUniformBufferUpdateAfterBind,
    ///     descriptorBindingStorageBufferUpdateAfterBind, descriptorBindingUniformTexelBufferUpdateAfterBind, and/or
    ///     descriptorBindingStorageTexelBufferUpdateAfterBind. If this is VK_FALSE, then either robustBufferAccess must be
    ///     disabled or all of these update-after-bind features must be disabled.
    /// </summary>
    public VkBool32 robustBufferAccessUpdateAfterBind;

    /// <summary>
    ///     quadDivergentImplicitLod is a boolean value indicating whether implicit LOD calculations for image operations
    ///     have well-defined results when the image and/or sampler objects used for the instruction are not uniform within a
    ///     quad. See Derivative Image Operations.
    /// </summary>
    public VkBool32 quadDivergentImplicitLod;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindSamplers is similar to maxPerStageDescriptorSamplers but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindSamplers;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindUniformBuffers is similar to maxPerStageDescriptorUniformBuffers but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindStorageBuffers is similar to maxPerStageDescriptorStorageBuffers but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindSampledImages is similar to maxPerStageDescriptorSampledImages but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindSampledImages;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindStorageImages is similar to maxPerStageDescriptorStorageImages but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindStorageImages;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindInputAttachments is similar to maxPerStageDescriptorInputAttachments but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;

    /// <summary>
    ///     maxPerStageUpdateAfterBindResources is similar to maxPerStageResources but counts descriptors from descriptor
    ///     sets created with or without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageUpdateAfterBindResources;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindSamplers is similar to maxDescriptorSetSamplers but counts descriptors from
    ///     descriptor sets created with or without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindSamplers;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindUniformBuffers is similar to maxDescriptorSetUniformBuffers but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindUniformBuffers;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindUniformBuffersDynamic is similar to maxDescriptorSetUniformBuffersDynamic but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set. While an application can allocate dynamic
    ///     uniform buffer descriptors from a pool created with the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT,
    ///     bindings for these descriptors must not be present in any descriptor set layout that includes bindings created with
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindStorageBuffers is similar to maxDescriptorSetStorageBuffers but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindStorageBuffers;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindStorageBuffersDynamic is similar to maxDescriptorSetStorageBuffersDynamic but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set. While an application can allocate dynamic
    ///     storage buffer descriptors from a pool created with the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT,
    ///     bindings for these descriptors must not be present in any descriptor set layout that includes bindings created with
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindSampledImages is similar to maxDescriptorSetSampledImages but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindSampledImages;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindStorageImages is similar to maxDescriptorSetStorageImages but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindStorageImages;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindInputAttachments is similar to maxDescriptorSetInputAttachments but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindInputAttachments;

    /// <summary>
    ///     supportedDepthResolveModes is a bitmask of VkResolveModeFlagBits indicating the set of supported depth resolve
    ///     modes. VK_RESOLVE_MODE_SAMPLE_ZERO_BIT must be included in the set but implementations may support additional
    ///     modes.
    /// </summary>
    public VkResolveModeFlags supportedDepthResolveModes;

    /// <summary>
    ///     supportedStencilResolveModes is a bitmask of VkResolveModeFlagBits indicating the set of supported stencil
    ///     resolve modes. VK_RESOLVE_MODE_SAMPLE_ZERO_BIT must be included in the set but implementations may support
    ///     additional modes. VK_RESOLVE_MODE_AVERAGE_BIT must not be included in the set.
    /// </summary>
    public VkResolveModeFlags supportedStencilResolveModes;

    /// <summary>
    ///     independentResolveNone is VK_TRUE if the implementation supports setting the depth and stencil resolve modes
    ///     to different values when one of those modes is VK_RESOLVE_MODE_NONE. Otherwise the implementation only supports
    ///     setting both modes to the same value.
    /// </summary>
    public VkBool32 independentResolveNone;

    /// <summary>
    ///     independentResolveis VK_TRUE if the implementation supports all combinations of the supported depth and
    ///     stencil resolve modes, including setting either depth or stencil resolve mode to VK_RESOLVE_MODE_NONE. An
    ///     implementation that supports independentResolve must also support independentResolveNone.
    /// </summary>
    public VkBool32 independentResolve;

    /// <summary>
    ///     filterMinmaxSingleComponentFormats is a boolean value indicating whether a minimum set of required formats
    ///     support min/max filtering.
    /// </summary>
    public VkBool32 filterMinmaxSingleComponentFormats;

    /// <summary>
    ///     filterMinmaxImageComponentMapping is a boolean value indicating whether the implementation supports
    ///     non-identity component mapping of the image when doing min/max filtering.
    /// </summary>
    public VkBool32 filterMinmaxImageComponentMapping;

    /// <summary>
    ///     maxTimelineSemaphoreValueDifference indicates the maximum difference allowed by the implementation between the
    ///     current value of a timeline semaphore and any pending signal or wait operations.
    /// </summary>
    public ulong maxTimelineSemaphoreValueDifference;

    /// <summary>
    ///     framebufferIntegerColorSampleCounts is a bitmask of VkSampleCountFlagBits indicating the color sample counts
    ///     that are supported for all framebuffer color attachments with integer formats.
    /// </summary>
    public VkSampleCountFlags framebufferIntegerColorSampleCounts;
}