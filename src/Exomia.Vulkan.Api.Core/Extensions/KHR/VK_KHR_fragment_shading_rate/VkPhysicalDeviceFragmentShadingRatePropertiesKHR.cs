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
///     VkPhysicalDeviceFragmentShadingRatePropertiesKHR - Structure describing variable fragment shading rate limits that
///     can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShadingRatePropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShadingRatePropertiesKHR.html
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
public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     minFragmentShadingRateAttachmentTexelSize indicates minimum supported width and height of the portion of the
    ///     framebuffer corresponding to each texel in a fragment shading rate attachment. Each value must be less than or
    ///     equal to the values in maxFragmentShadingRateAttachmentTexelSize. Each value must be a power-of-two. It must be
    ///     (0,0) if the attachmentFragmentShadingRate feature is not supported.
    /// </summary>
    public VkExtent2D minFragmentShadingRateAttachmentTexelSize;

    /// <summary>
    ///     minFragmentShadingRateAttachmentTexelSize indicates minimum supported width and height of the portion of the
    ///     framebuffer corresponding to each texel in a fragment shading rate attachment. Each value must be less than or
    ///     equal to the values in maxFragmentShadingRateAttachmentTexelSize. Each value must be a power-of-two. It must be
    ///     (0,0) if the attachmentFragmentShadingRate feature is not supported.
    /// </summary>
    public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;

    /// <summary>
    ///     maxFragmentShadingRateAttachmentTexelSizeAspectRatio indicates the maximum ratio between the width and height
    ///     of the portion of the framebuffer corresponding to each texel in a fragment shading rate attachment.
    ///     maxFragmentShadingRateAttachmentTexelSizeAspectRatio must be a power-of-two value, and must be less than or equal
    ///     to max(maxFragmentShadingRateAttachmentTexelSize.width / minFragmentShadingRateAttachmentTexelSize.height,
    ///     maxFragmentShadingRateAttachmentTexelSize.height / minFragmentShadingRateAttachmentTexelSize.width). It must be 0
    ///     if the attachmentFragmentShadingRate feature is not supported.
    /// </summary>
    public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;

    /// <summary>
    ///     primitiveFragmentShadingRateWithMultipleViewports specifies     whether the primitive     fragment shading
    ///     rate can be used when multiple viewports are used.     If this value is VK_FALSE, only a single viewport must be
    ///     used,     and applications must not write to the     ViewportMaskNV or     ViewportIndex built-in when setting
    ///     PrimitiveShadingRateKHR.     It must be VK_FALSE if     the shaderOutputViewportIndex feature,     the
    ///     VK_EXT_shader_viewport_index_layer extension, or     the geometryShader feature is not     supported, or if the
    ///     primitiveFragmentShadingRate feature is not supported.
    /// </summary>
    public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;

    /// <summary>
    ///     layeredShadingRateAttachments specifies whether a shading rate     attachment image view can be created
    ///     with multiple layers.     If this value is VK_FALSE, when creating an image view with a     usage that includes
    ///     VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,     layerCount must be 1.     It must be VK_FALSE if
    ///     the multiview feature,     the shaderOutputViewportIndex feature,     the VK_EXT_shader_viewport_index_layer
    ///     extension, or     the geometryShader feature is not     supported, or if the attachmentFragmentShadingRate feature
    ///     is not supported.
    /// </summary>
    public VkBool32 layeredShadingRateAttachments;

    /// <summary>
    ///     fragmentShadingRateNonTrivialCombinerOps specifies whether VkFragmentShadingRateCombinerOpKHR enums other than
    ///     VK_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_KHR or VK_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_KHR can be used. It
    ///     must be VK_FALSE unless either the primitiveFragmentShadingRate or attachmentFragmentShadingRate feature is
    ///     supported.
    /// </summary>
    public VkBool32 fragmentShadingRateNonTrivialCombinerOps;

    /// <summary>
    ///     maxFragmentSize indicates the maximum supported width and height of a fragment. Its width and height members
    ///     must both be power-of-two values. This limit is purely informational, and is not validated.
    /// </summary>
    public VkExtent2D maxFragmentSize;

    /// <summary>
    ///     maxFragmentSizeAspectRatioindicates the maximum ratio between the width and height of a fragment.
    ///     maxFragmentSizeAspectRatio must be a power-of-two value, and must be less than or equal to the maximum of the width
    ///     and height members of maxFragmentSize. This limit is purely informational, and is not validated.
    /// </summary>
    public uint maxFragmentSizeAspectRatio;

    /// <summary>
    ///     maxFragmentShadingRateCoverageSamples specifies the maximum number of coverage samples supported in a single
    ///     fragment. maxFragmentShadingRateCoverageSamples must be less than or equal to the product of the width and height
    ///     members of maxFragmentSize, and the sample count reported by maxFragmentShadingRateRasterizationSamples.
    ///     maxFragmentShadingRateCoverageSamples must be less than or equal to maxSampleMaskWords × 32 if
    ///     fragmentShadingRateWithShaderSampleMask is supported. This limit is purely informational, and is not validated.
    /// </summary>
    public uint maxFragmentShadingRateCoverageSamples;

    /// <summary>
    ///     maxFragmentShadingRateCoverageSamples specifies the maximum number of coverage samples supported in a single
    ///     fragment. maxFragmentShadingRateCoverageSamples must be less than or equal to the product of the width and height
    ///     members of maxFragmentSize, and the sample count reported by maxFragmentShadingRateRasterizationSamples.
    ///     maxFragmentShadingRateCoverageSamples must be less than or equal to maxSampleMaskWords × 32 if
    ///     fragmentShadingRateWithShaderSampleMask is supported. This limit is purely informational, and is not validated.
    /// </summary>
    public VkSampleCountFlagBits maxFragmentShadingRateRasterizationSamples;

    /// <summary>
    ///     fragmentShadingRateWithShaderDepthStencilWrites specifies whether the implementation supports writing
    ///     FragDepthor FragStencilRefEXTfrom a fragment shader for multi-pixel fragments. If this value is VK_FALSE, writing
    ///     to those built-ins will clamp the fragment shading rate to (1,1).
    /// </summary>
    public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;

    /// <summary>
    ///     fragmentShadingRateWithSampleMask specifies whether the implementation supports setting valid bits of
    ///     VkPipelineMultisampleStateCreateInfo::pSampleMask to 0 for multi-pixel fragments. If this value is VK_FALSE,
    ///     zeroing valid bits in the sample mask will clamp the fragment shading rate to (1,1).
    /// </summary>
    public VkBool32 fragmentShadingRateWithSampleMask;

    /// <summary>
    ///     maxFragmentShadingRateCoverageSamples specifies the maximum number of coverage samples supported in a single
    ///     fragment. maxFragmentShadingRateCoverageSamples must be less than or equal to the product of the width and height
    ///     members of maxFragmentSize, and the sample count reported by maxFragmentShadingRateRasterizationSamples.
    ///     maxFragmentShadingRateCoverageSamples must be less than or equal to maxSampleMaskWords × 32 if
    ///     fragmentShadingRateWithShaderSampleMask is supported. This limit is purely informational, and is not validated.
    /// </summary>
    public VkBool32 fragmentShadingRateWithShaderSampleMask;

    /// <summary>
    ///     fragmentShadingRateWithConservativeRasterizationspecifies whether conservative rasterization is supported for
    ///     multi-pixel fragments. It must be VK_FALSE if VK_EXT_conservative_rasterizationis not supported. If this value is
    ///     VK_FALSE, using conservative rasterization will clamp the fragment shading rate to (1,1).
    /// </summary>
    public VkBool32 fragmentShadingRateWithConservativeRasterization;

    /// <summary>
    ///     fragmentShadingRateWithFragmentShaderInterlockspecifies whether fragment shader interlock is supported for
    ///     multi-pixel fragments. It must be VK_FALSE if VK_EXT_fragment_shader_interlockis not supported. If this value is
    ///     VK_FALSE, using fragment shader interlock will clamp the fragment shading rate to (1,1).
    /// </summary>
    public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;

    /// <summary>
    ///     fragmentShadingRateWithCustomSampleLocationsspecifies whether custom sample locationsare supported for
    ///     multi-pixel fragments. It must be VK_FALSE if VK_EXT_sample_locations is not supported. If this value is VK_FALSE,
    ///     using custom sample locations will clamp the fragment shading rate to (1,1).
    /// </summary>
    public VkBool32 fragmentShadingRateWithCustomSampleLocations;

    /// <summary>
    ///     fragmentShadingRateStrictMultiplyCombiner specifies whether VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR
    ///     accurately performs a multiplication or not. Implementations where this value is VK_FALSE will instead combine
    ///     rates with an addition. If fragmentShadingRateNonTrivialCombinerOps is VK_FALSE, implementations must report this
    ///     as VK_FALSE. If fragmentShadingRateNonTrivialCombinerOps is VK_TRUE, implementations should report this as VK_TRUE.
    /// </summary>
    public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
}