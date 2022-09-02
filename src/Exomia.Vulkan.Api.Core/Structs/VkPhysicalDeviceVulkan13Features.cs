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
///     VkPhysicalDeviceVulkan13Features - Structure describing the Vulkan 1.3 features that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan13Features.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan13Features.html
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
public unsafe struct VkPhysicalDeviceVulkan13Features
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     robustImageAccessindicates whether image accesses are tightly bounds-checked against the dimensions of the
    ///     image view. Invalid texels resulting from out of bounds image loads will be replaced as described in Texel
    ///     Replacement, with either (0,0,1) or (0,0,0) values inserted for missing G, B, or A components based on the format.
    /// </summary>
    public VkBool32 robustImageAccess;

    /// <summary>
    ///     inlineUniformBlockindicates whether the implementation supports inline uniform block descriptors. If this
    ///     feature is not enabled, VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK must not be used.
    /// </summary>
    public VkBool32 inlineUniformBlock;

    /// <summary>
    ///     descriptorBindingInlineUniformBlockUpdateAfterBindindicates whether the implementation supports updating
    ///     inline uniform block descriptors after a set is bound. If this feature is not enabled,
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT must not be used with VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK.
    /// </summary>
    public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;

    /// <summary>
    ///     pipelineCreationCacheControl indicates that the implementation supports:The following can be used in
    ///     Vk*PipelineCreateInfo::flags:VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BITVK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BITThe
    ///     following can be used in VkPipelineCacheCreateInfo::flags:VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT
    /// </summary>
    public VkBool32 pipelineCreationCacheControl;

    /// <summary> privateData indicates whether the implementation supports private data. See Private Data.</summary>
    public VkBool32 privateData;

    /// <summary>
    ///     shaderDemoteToHelperInvocation indicates whether the implementation supports the SPIR-V
    ///     DemoteToHelperInvocationEXTcapability.
    /// </summary>
    public VkBool32 shaderDemoteToHelperInvocation;

    /// <summary>
    ///     shaderTerminateInvocation specifies whether the implementation supports SPIR-V modules that use the
    ///     SPV_KHR_terminate_invocationextension.
    /// </summary>
    public VkBool32 shaderTerminateInvocation;

    /// <summary>
    ///     subgroupSizeControl indicates whether the implementation supports controlling shader subgroup sizes via the
    ///     VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BITflag and the
    ///     VkPipelineShaderStageRequiredSubgroupSizeCreateInfostructure.
    /// </summary>
    public VkBool32 subgroupSizeControl;

    /// <summary>
    ///     computeFullSubgroups indicates whether the implementation supports requiring full subgroups in compute , mesh,
    ///     or task shaders via the VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT flag.
    /// </summary>
    public VkBool32 computeFullSubgroups;

    /// <summary>
    ///     synchronization2indicates whether the implementation supports the new set of synchronization commands
    ///     introduced in VK_KHR_synchronization2.
    /// </summary>
    public VkBool32 synchronization2;

    /// <summary>
    ///     textureCompressionASTC_HDR indicates whether all of the ASTC HDR compressed texture formats are supported. If
    ///     this feature is enabled, then the VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, VK_FORMAT_FEATURE_BLIT_SRC_BIT and
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT features mustbe supported in optimalTilingFeatures for the
    ///     following
    ///     formats:VK_FORMAT_ASTC_4x4_SFLOAT_BLOCKVK_FORMAT_ASTC_5x4_SFLOAT_BLOCKVK_FORMAT_ASTC_5x5_SFLOAT_BLOCKVK_FORMAT_ASTC_6x5_SFLOAT_BLOCKVK_FORMAT_ASTC_6x6_SFLOAT_BLOCKVK_FORMAT_ASTC_8x5_SFLOAT_BLOCKVK_FORMAT_ASTC_8x6_SFLOAT_BLOCKVK_FORMAT_ASTC_8x8_SFLOAT_BLOCKVK_FORMAT_ASTC_10x5_SFLOAT_BLOCKVK_FORMAT_ASTC_10x6_SFLOAT_BLOCKVK_FORMAT_ASTC_10x8_SFLOAT_BLOCKVK_FORMAT_ASTC_10x10_SFLOAT_BLOCKVK_FORMAT_ASTC_12x10_SFLOAT_BLOCKVK_FORMAT_ASTC_12x12_SFLOAT_BLOCKTo
    ///     query for additional properties, or if the feature is not enabled, vkGetPhysicalDeviceFormatProperties and
    ///     vkGetPhysicalDeviceImageFormatProperties can be used to check for supported properties of individual formats as
    ///     normal.
    /// </summary>
    public VkBool32 textureCompressionASTC_HDR;

    /// <summary>
    ///     shaderZeroInitializeWorkgroupMemory specifies whether the implementation supports initializing a variable in
    ///     Workgroup storage class.
    /// </summary>
    public VkBool32 shaderZeroInitializeWorkgroupMemory;

    /// <summary>
    ///     dynamicRenderingspecifies that the implementation supports dynamic render pass instances using the
    ///     vkCmdBeginRendering command.
    /// </summary>
    public VkBool32 dynamicRendering;

    /// <summary>
    ///     shaderIntegerDotProduct specifies whether shader modules candeclare the DotProductInputAllKHR,
    ///     DotProductInput4x8BitKHR, DotProductInput4x8BitPackedKHR and DotProductKHR capabilities.
    /// </summary>
    public VkBool32 shaderIntegerDotProduct;

    /// <summary>
    ///     maintenance4 indicates that the implementation supports the following:The application may destroy a
    ///     VkPipelineLayout object immediately after using it to create another object.LocalSizeId can be used as an
    ///     alternative to LocalSize to specify the local workgroup size with specialization constants.Images created with
    ///     identical creation parameters will always have the same alignment requirements.The size memory requirement of a
    ///     buffer or image is never greater than that of another buffer or image created with a greater or equal size.Push
    ///     constants do not have to be initialized before they are dynamically accessed.The interface matching rules allow a
    ///     larger output vector to match with a smaller input vector, with additional values being discarded.
    /// </summary>
    public VkBool32 maintenance4;
}