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
///     VkPhysicalDeviceFeatures - Structure describing the fine-grained features that can be supported by an
///     implementation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFeatures.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFeatures.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkPhysicalDeviceFeatures
{
    /// <summary>
    ///     robustBufferAccess specifies that accesses to buffers are bounds-checked against the range of the buffer
    ///     descriptor (as determined by VkDescriptorBufferInfo::range, VkBufferViewCreateInfo::range, or the size of the
    ///     buffer). Out of bounds accesses must not cause application termination, and the effects of shader loads, stores,
    ///     and atomics must conform to an implementation-dependent behavior as described below.A buffer access is considered
    ///     to be out of bounds if any of the following are true:The pointer was formed by OpImageTexelPointer and the
    ///     coordinate is less than zero or greater than or equal to the number of whole elements in the bound range.The
    ///     pointer was not formed by OpImageTexelPointer and the object pointed to is not wholly contained within the bound
    ///     range. This includes accesses performed via variable pointers where the buffer descriptor being accessed cannot be
    ///     statically determined. Uninitialized pointers and pointers equal to OpConstantNull are treated as pointing to a
    ///     zero-sized object, so all accesses through such pointers are considered to be out of bounds. Buffer accesses
    ///     through buffer device addresses are not bounds-checked. If the cooperativeMatrixRobustBufferAccess feature is not
    ///     enabled, then accesses using OpCooperativeMatrixLoadNV and OpCooperativeMatrixStoreNV may not be
    ///     bounds-checked.NoteIf a SPIR-V OpLoad instruction loads a structure and the tail end of the structure is out of
    ///     bounds, then all members of the structure are considered out of bounds even if the members at the end are not
    ///     statically used.If robustBufferAccess2 is not enabled and any buffer access is determined to be out of bounds, then
    ///     any other access of the same type (load, store, or atomic) to the same buffer that accesses an address less than 16
    ///     bytes away from the out of bounds address may also be considered out of bounds.If the access is a load that reads
    ///     from the same memory locations as a prior store in the same shader invocation, with no other intervening accesses
    ///     to the same memory locations in that shader invocation, then the result of the load may be the value stored by the
    ///     store instruction, even if the access is out of bounds. If the load is Volatile, then an out of bounds load must
    ///     return the appropriate out of bounds value.Accesses to descriptors written with a VK_NULL_HANDLE resource or view
    ///     are not considered to be out of bounds. Instead, each type of descriptor access defines a specific behavior for
    ///     accesses to a null descriptor.Out-of-bounds buffer loads will return any of the following values:If the access is
    ///     to a uniform buffer and robustBufferAccess2 is enabled, loads of offsets between the end of the descriptor range
    ///     and the end of the descriptor range rounded up to a multiple of robustUniformBufferAccessSizeAlignment bytes must
    ///     return either zero values or the contents of the memory at the offset being loaded. Loads of offsets past the
    ///     descriptor range rounded up to a multiple of robustUniformBufferAccessSizeAlignment bytes must return zero
    ///     values.If the access is to a storage buffer and robustBufferAccess2 is enabled, loads of offsets between the end of
    ///     the descriptor range and the end of the descriptor range rounded up to a multiple of
    ///     robustStorageBufferAccessSizeAlignment bytes must return either zero values or the contents of the memory at the
    ///     offset being loaded. Loads of offsets past the descriptor range rounded up to a multiple of
    ///     robustStorageBufferAccessSizeAlignment bytes must return zero values. Similarly, stores to addresses between the
    ///     end of the descriptor range and the end of the descriptor range rounded up to a multiple of
    ///     robustStorageBufferAccessSizeAlignment bytes may be discarded.Non-atomic accesses to storage buffers that are a
    ///     multiple of 32 bits may be decomposed into 32-bit accesses that are individually bounds-checked.If the access is to
    ///     an index buffer and robustBufferAccess2 is enabled, zero values must be returned.If the access is to a uniform
    ///     texel buffer or storage texel buffer and robustBufferAccess2 is enabled, zero values must be returned, and then
    ///     Conversion to RGBA is applied based on the buffer view&#8217;s format.Values from anywhere within the memory
    ///     range(s) bound to the buffer (possibly including bytes of memory past the end of the buffer, up to the end of the
    ///     bound range).Zero values, or (0,0,0,x) vectors for vector reads where x is a valid value represented in the type of
    ///     the vector components and maybe any of:0, 1, or the maximum representable positive integer value, for signed or
    ///     unsigned integer components0.0 or 1.0, for floating-point componentsOut-of-bounds writes may modify values within
    ///     the memory range(s) bound to the buffer, but must not modify any other memory.If robustBufferAccess2 is enabled,
    ///     out of bounds writes must not modify any memory.Out-of-bounds atomics may modify values within the memory range(s)
    ///     bound to the buffer, but must not modify any other memory, and return an undefined value.If robustBufferAccess2 is
    ///     enabled, out of bounds atomics must not modify any memory, and return an undefined value.If robustBufferAccess2 is
    ///     disabled, vertex input attributes are considered out of bounds if the offset of the attribute in the bound vertex
    ///     buffer range plus the size of the attribute is greater than either:vertexBufferRangeSize, if bindingStride == 0;
    ///     or(vertexBufferRangeSize - (vertexBufferRangeSize % bindingStride))where vertexBufferRangeSize is the byte size of
    ///     the memory range bound to the vertex buffer binding and bindingStride is the byte stride of the corresponding
    ///     vertex input binding. Further, if any vertex input attribute using a specific vertex input binding is out of
    ///     bounds, then all vertex input attributes using that vertex input binding for that vertex shader invocation are
    ///     considered out of bounds.If a vertex input attribute is out of bounds, it will be assigned one of the following
    ///     values:Values from anywhere within the memory range(s) bound to the buffer, converted according to the format of
    ///     the attribute.Zero values, format converted according to the format of the attribute.Zero values, or (0,0,0,x)
    ///     vectors, as described above.If robustBufferAccess2 is enabled, vertex input attributes are considered out of bounds
    ///     if the offset of the attribute in the bound vertex buffer range plus the size of the attribute is greater than the
    ///     byte size of the memory range bound to the vertex buffer binding.If a vertex input attribute is out of bounds, the
    ///     raw data extracted are zero values, and missing G, B, or A components are filled with (0,0,1).If robustBufferAccess
    ///     is not enabled, applications must not perform out of bounds accesses except under the conditions enabled by the
    ///     pipelineRobustness feature .
    /// </summary>
    public VkBool32 robustBufferAccess;

    /// <summary>
    ///     fullDrawIndexUint32 specifies the full 32-bit range of indices is supported for indexed draw calls when using
    ///     a VkIndexType of VK_INDEX_TYPE_UINT32. maxDrawIndexedIndexValue is the maximum index value that may be used (aside
    ///     from the primitive restart index, which is always 232-1 when the VkIndexType is VK_INDEX_TYPE_UINT32). If this
    ///     feature is supported, maxDrawIndexedIndexValue must be 232-1; otherwise it must be no smaller than 224-1. See
    ///     maxDrawIndexedIndexValue.
    /// </summary>
    public VkBool32 fullDrawIndexUint32;

    /// <summary>
    ///     imageCubeArray specifies whether image views with a VkImageViewType of VK_IMAGE_VIEW_TYPE_CUBE_ARRAY can be
    ///     created, and that the corresponding SampledCubeArray and ImageCubeArray SPIR-V capabilities can be used in shader
    ///     code.
    /// </summary>
    public VkBool32 imageCubeArray;

    /// <summary>
    ///     independentBlend specifies whether the VkPipelineColorBlendAttachmentState settings are controlled
    ///     independently per-attachment. If this feature is not enabled, the VkPipelineColorBlendAttachmentState settings for
    ///     all color attachments must be identical. Otherwise, a different VkPipelineColorBlendAttachmentState can be provided
    ///     for each bound color attachment.
    /// </summary>
    public VkBool32 independentBlend;

    /// <summary>
    ///     geometryShader specifies whether geometry shaders are supported. If this feature is not enabled, the
    ///     VK_SHADER_STAGE_GEOMETRY_BITand VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT enum values must not be used. This also
    ///     specifies whether shader modules can declare the Geometry capability.
    /// </summary>
    public VkBool32 geometryShader;

    /// <summary>
    ///     tessellationShader specifies whether tessellation control and evaluation shaders are supported. If this
    ///     feature is not enabled, the VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT, VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT,
    ///     VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT, VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT, and
    ///     VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO enum values must not be used. This also specifies whether
    ///     shader modules can declare the Tessellation capability.
    /// </summary>
    public VkBool32 tessellationShader;

    /// <summary>
    ///     sampleRateShading specifies whether Sample Shading and multisample interpolation are supported. If this
    ///     feature is not enabled, the sampleShadingEnable member of the VkPipelineMultisampleStateCreateInfo structure must
    ///     be set to VK_FALSE and the minSampleShading member is ignored. This also specifies whether shader modules can
    ///     declare the SampleRateShading capability.
    /// </summary>
    public VkBool32 sampleRateShading;

    /// <summary>
    ///     dualSrcBlend specifies whether blend operations which take two sources are supported. If this feature is not
    ///     enabled, the VK_BLEND_FACTOR_SRC1_COLOR, VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR, VK_BLEND_FACTOR_SRC1_ALPHA, and
    ///     VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA enum values must not be used as source or destination blending factors. See
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-dsb.
    /// </summary>
    public VkBool32 dualSrcBlend;

    /// <summary>
    ///     logicOp specifies whether logic operations are supported. If this feature is not enabled, the logicOpEnable
    ///     member of the VkPipelineColorBlendStateCreateInfo structure must be set to VK_FALSE, and the logicOp member is
    ///     ignored.
    /// </summary>
    public VkBool32 logicOp;

    /// <summary>
    ///     multiDrawIndirect specifies whether multiple draw indirect is supported. If this feature is not enabled, the
    ///     drawCount parameter to the vkCmdDrawIndirect and vkCmdDrawIndexedIndirect commands must be 0 or 1. The
    ///     maxDrawIndirectCount member of the VkPhysicalDeviceLimits structure must also be 1 if this feature is not
    ///     supported. See maxDrawIndirectCount.
    /// </summary>
    public VkBool32 multiDrawIndirect;

    /// <summary>
    ///     drawIndirectFirstInstancespecifies whether indirect drawing calls support the firstInstanceparameter. If this
    ///     feature is not enabled, the firstInstance member of all VkDrawIndirectCommand and
    ///     VkDrawIndexedIndirectCommandstructures that are provided to the vkCmdDrawIndirect and vkCmdDrawIndexedIndirect
    ///     commands must be 0.
    /// </summary>
    public VkBool32 drawIndirectFirstInstance;

    /// <summary>
    ///     depthClamp specifies whether depth clamping is supported. If this feature is not enabled, the
    ///     depthClampEnable member of the VkPipelineRasterizationStateCreateInfo structure must be set to VK_FALSE. Otherwise,
    ///     setting depthClampEnable to VK_TRUE will enable depth clamping.
    /// </summary>
    public VkBool32 depthClamp;

    /// <summary>
    ///     depthBiasClamp specifies whether depth bias clamping is supported. If this feature is not enabled, the
    ///     depthBiasClamp member of the VkPipelineRasterizationStateCreateInfo structure must be set to 0.0 unless the
    ///     VK_DYNAMIC_STATE_DEPTH_BIAS dynamic state is enabled, and the depthBiasClamp parameter to vkCmdSetDepthBias must be
    ///     set to 0.0.
    /// </summary>
    public VkBool32 depthBiasClamp;

    /// <summary>
    ///     fillModeNonSolid specifies whether point and wireframe fill modes are supported. If this feature is not
    ///     enabled, the VK_POLYGON_MODE_POINT and VK_POLYGON_MODE_LINE enum values must not be used.
    /// </summary>
    public VkBool32 fillModeNonSolid;

    /// <summary>
    ///     depthBounds specifies whether depth bounds tests are supported. If this feature is not enabled, the
    ///     depthBoundsTestEnable member of the VkPipelineDepthStencilStateCreateInfo structure must be set to VK_FALSE. When
    ///     depthBoundsTestEnable is set to VK_FALSE, the minDepthBounds and maxDepthBounds members of the
    ///     VkPipelineDepthStencilStateCreateInfo structure are ignored.
    /// </summary>
    public VkBool32 depthBounds;

    /// <summary>
    ///     wideLines specifies whether lines with width other than 1.0 are supported. If this feature is not enabled,
    ///     the lineWidth member of the VkPipelineRasterizationStateCreateInfo structure must be set to 1.0 unless the
    ///     VK_DYNAMIC_STATE_LINE_WIDTH dynamic state is enabled, and the lineWidth parameter to vkCmdSetLineWidthmust be set
    ///     to 1.0. When this feature is supported, the range and granularity of supported line widths are indicated by the
    ///     lineWidthRange and lineWidthGranularity members of the VkPhysicalDeviceLimitsstructure, respectively.
    /// </summary>
    public VkBool32 wideLines;

    /// <summary>
    ///     largePoints specifies whether points with size greater than 1.0 are supported. If this feature is not
    ///     enabled, only a point size of 1.0 written by a shader is supported. The range and granularity of supported point
    ///     sizes are indicated by the pointSizeRange and pointSizeGranularity members of the VkPhysicalDeviceLimits structure,
    ///     respectively.
    /// </summary>
    public VkBool32 largePoints;

    /// <summary>
    ///     alphaToOne specifies whether the implementation is able to replace the alpha value of the fragment shader
    ///     color output in the Multisample Coverage fragment operation. If this feature is not enabled, then the
    ///     alphaToOneEnable member of the VkPipelineMultisampleStateCreateInfo structure must be set to VK_FALSE. Otherwise
    ///     setting alphaToOneEnable to VK_TRUE will enable alpha-to-one behavior.
    /// </summary>
    public VkBool32 alphaToOne;

    /// <summary>
    ///     multiViewport specifies whether more than one viewport is supported. If this feature is not enabled:The
    ///     viewportCount and scissorCount members of the VkPipelineViewportStateCreateInfo structure must be set to 1.The
    ///     firstViewport and viewportCount parameters to the vkCmdSetViewport command must be set to 0 and 1, respectively.The
    ///     firstScissor and scissorCount parameters to the vkCmdSetScissor command must be set to 0 and 1, respectively.The
    ///     exclusiveScissorCount member of the VkPipelineViewportExclusiveScissorStateCreateInfoNV structure must be set to 0
    ///     or 1.The firstExclusiveScissor and exclusiveScissorCountparameters to the vkCmdSetExclusiveScissorNV command must
    ///     be set to 0 and 1, respectively.
    /// </summary>
    public VkBool32 multiViewport;

    /// <summary>
    ///     samplerAnisotropy specifies whether anisotropic filtering is supported. If this feature is not enabled, the
    ///     anisotropyEnable member of the VkSamplerCreateInfo structure must be VK_FALSE.
    /// </summary>
    public VkBool32 samplerAnisotropy;

    /// <summary>
    ///     textureCompressionETC2specifies whether all of the ETC2 and EAC compressed texture formats are supported. If
    ///     this feature is enabled, then the VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, VK_FORMAT_FEATURE_BLIT_SRC_BIT and
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT features mustbe supported in optimalTilingFeatures for the
    ///     following
    ///     formats:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCKVK_FORMAT_ETC2_R8G8B8_SRGB_BLOCKVK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCKVK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCKVK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCKVK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCKVK_FORMAT_EAC_R11_UNORM_BLOCKVK_FORMAT_EAC_R11_SNORM_BLOCKVK_FORMAT_EAC_R11G11_UNORM_BLOCKVK_FORMAT_EAC_R11G11_SNORM_BLOCKTo
    ///     query for additional properties, or if the feature is not enabled, vkGetPhysicalDeviceFormatProperties and
    ///     vkGetPhysicalDeviceImageFormatProperties can be used to check for supported properties of individual formats as
    ///     normal.
    /// </summary>
    public VkBool32 textureCompressionETC2;

    /// <summary>
    ///     textureCompressionASTC_LDRspecifies whether all of the ASTC LDR compressed texture formats are supported. If
    ///     this feature is enabled, then the VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, VK_FORMAT_FEATURE_BLIT_SRC_BIT and
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT features mustbe supported in optimalTilingFeatures for the
    ///     following
    ///     formats:VK_FORMAT_ASTC_4x4_UNORM_BLOCKVK_FORMAT_ASTC_4x4_SRGB_BLOCKVK_FORMAT_ASTC_5x4_UNORM_BLOCKVK_FORMAT_ASTC_5x4_SRGB_BLOCKVK_FORMAT_ASTC_5x5_UNORM_BLOCKVK_FORMAT_ASTC_5x5_SRGB_BLOCKVK_FORMAT_ASTC_6x5_UNORM_BLOCKVK_FORMAT_ASTC_6x5_SRGB_BLOCKVK_FORMAT_ASTC_6x6_UNORM_BLOCKVK_FORMAT_ASTC_6x6_SRGB_BLOCKVK_FORMAT_ASTC_8x5_UNORM_BLOCKVK_FORMAT_ASTC_8x5_SRGB_BLOCKVK_FORMAT_ASTC_8x6_UNORM_BLOCKVK_FORMAT_ASTC_8x6_SRGB_BLOCKVK_FORMAT_ASTC_8x8_UNORM_BLOCKVK_FORMAT_ASTC_8x8_SRGB_BLOCKVK_FORMAT_ASTC_10x5_UNORM_BLOCKVK_FORMAT_ASTC_10x5_SRGB_BLOCKVK_FORMAT_ASTC_10x6_UNORM_BLOCKVK_FORMAT_ASTC_10x6_SRGB_BLOCKVK_FORMAT_ASTC_10x8_UNORM_BLOCKVK_FORMAT_ASTC_10x8_SRGB_BLOCKVK_FORMAT_ASTC_10x10_UNORM_BLOCKVK_FORMAT_ASTC_10x10_SRGB_BLOCKVK_FORMAT_ASTC_12x10_UNORM_BLOCKVK_FORMAT_ASTC_12x10_SRGB_BLOCKVK_FORMAT_ASTC_12x12_UNORM_BLOCKVK_FORMAT_ASTC_12x12_SRGB_BLOCKTo
    ///     query for additional properties, or if the feature is not enabled, vkGetPhysicalDeviceFormatProperties and
    ///     vkGetPhysicalDeviceImageFormatProperties can be used to check for supported properties of individual formats as
    ///     normal.
    /// </summary>
    public VkBool32 textureCompressionASTC_LDR;

    /// <summary>
    ///     textureCompressionBC specifies whether all of the BC compressed texture formats are supported. If this
    ///     feature is enabled, then the VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, VK_FORMAT_FEATURE_BLIT_SRC_BIT and
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT features mustbe supported in optimalTilingFeatures for the
    ///     following
    ///     formats:VK_FORMAT_BC1_RGB_UNORM_BLOCKVK_FORMAT_BC1_RGB_SRGB_BLOCKVK_FORMAT_BC1_RGBA_UNORM_BLOCKVK_FORMAT_BC1_RGBA_SRGB_BLOCKVK_FORMAT_BC2_UNORM_BLOCKVK_FORMAT_BC2_SRGB_BLOCKVK_FORMAT_BC3_UNORM_BLOCKVK_FORMAT_BC3_SRGB_BLOCKVK_FORMAT_BC4_UNORM_BLOCKVK_FORMAT_BC4_SNORM_BLOCKVK_FORMAT_BC5_UNORM_BLOCKVK_FORMAT_BC5_SNORM_BLOCKVK_FORMAT_BC6H_UFLOAT_BLOCKVK_FORMAT_BC6H_SFLOAT_BLOCKVK_FORMAT_BC7_UNORM_BLOCKVK_FORMAT_BC7_SRGB_BLOCKTo
    ///     query for additional properties, or if the feature is not enabled, vkGetPhysicalDeviceFormatProperties and
    ///     vkGetPhysicalDeviceImageFormatProperties can be used to check for supported properties of individual formats as
    ///     normal.
    /// </summary>
    public VkBool32 textureCompressionBC;

    /// <summary>
    ///     occlusionQueryPrecise specifies whether occlusion queries returning actual sample counts are supported.
    ///     Occlusion queries are created in a VkQueryPool by specifying the queryType of VK_QUERY_TYPE_OCCLUSION in the
    ///     VkQueryPoolCreateInfo structure which is passed to vkCreateQueryPool. If this feature is enabled, queries of this
    ///     type can enable VK_QUERY_CONTROL_PRECISE_BIT in the flags parameter to vkCmdBeginQuery. If this feature is not
    ///     supported, the implementation supports only boolean occlusion queries. When any samples are passed, boolean queries
    ///     will return a non-zero result value, otherwise a result value of zero is returned. When this feature is enabled and
    ///     VK_QUERY_CONTROL_PRECISE_BIT is set, occlusion queries will report the actual number of samples passed.
    /// </summary>
    public VkBool32 occlusionQueryPrecise;

    /// <summary>
    ///     pipelineStatisticsQueryspecifies whether the pipeline statistics queries are supported. If this feature is
    ///     not enabled, queries of type VK_QUERY_TYPE_PIPELINE_STATISTICS cannot be created, and none of the
    ///     VkQueryPipelineStatisticFlagBits bits can be set in the pipelineStatistics member of the
    ///     VkQueryPoolCreateInfostructure.
    /// </summary>
    public VkBool32 pipelineStatisticsQuery;

    /// <summary>
    ///     vertexPipelineStoresAndAtomics specifies whether storage buffers and images support stores and atomic
    ///     operations in the vertex, tessellation, and geometry shader stages. If this feature is not enabled, all storage
    ///     image, storage texel buffer, and storage buffer variables used by these stages in shader modules must be decorated
    ///     with the NonWritable decoration (or the readonly memory qualifier in GLSL).
    /// </summary>
    public VkBool32 vertexPipelineStoresAndAtomics;

    /// <summary>
    ///     fragmentStoresAndAtomicsspecifies whether storage buffers and images support stores and atomic operations in
    ///     the fragment shader stage. If this feature is not enabled, all storage image, storage texel buffer, and storage
    ///     buffer variables used by the fragment stage in shader modules must be decorated with the NonWritable decoration (or
    ///     the readonly memory qualifier in GLSL).
    /// </summary>
    public VkBool32 fragmentStoresAndAtomics;

    /// <summary>
    ///     shaderTessellationAndGeometryPointSize specifies whether the PointSize built-in decoration is available in the
    ///     tessellation control, tessellation evaluation, and geometry shader stages. If this feature is not enabled, members
    ///     decorated with the PointSize built-in decoration must not be read from or written to and all points written from a
    ///     tessellation or geometry shader will have a size of 1.0. This also specifies whether shader modules can declare the
    ///     TessellationPointSize capability for tessellation control and evaluation shaders, or if the shader modules can
    ///     declare the GeometryPointSize capability for geometry shaders. An implementation supporting this feature must also
    ///     support one or both of the tessellationShader or geometryShader features.
    /// </summary>
    public VkBool32 shaderTessellationAndGeometryPointSize;

    /// <summary>
    ///     shaderImageGatherExtendedspecifies whether the extended set of image gather instructions are available in
    ///     shader code. If this feature is not enabled, the OpImage*Gather instructions do not support the Offset and
    ///     ConstOffsets operands. This also specifies whether shader modules can declare the ImageGatherExtended capability.
    /// </summary>
    public VkBool32 shaderImageGatherExtended;

    /// <summary>
    ///     shaderStorageImageExtendedFormats specifies whether all the &#8220;storage image extended formats&#8221; below
    ///     are supported; if this feature is supported, then the VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT mustbe supported in
    ///     optimalTilingFeatures for the following
    ///     formats:VK_FORMAT_R16G16_SFLOATVK_FORMAT_B10G11R11_UFLOAT_PACK32VK_FORMAT_R16_SFLOATVK_FORMAT_R16G16B16A16_UNORMVK_FORMAT_A2B10G10R10_UNORM_PACK32VK_FORMAT_R16G16_UNORMVK_FORMAT_R8G8_UNORMVK_FORMAT_R16_UNORMVK_FORMAT_R8_UNORMVK_FORMAT_R16G16B16A16_SNORMVK_FORMAT_R16G16_SNORMVK_FORMAT_R8G8_SNORMVK_FORMAT_R16_SNORMVK_FORMAT_R8_SNORMVK_FORMAT_R16G16_SINTVK_FORMAT_R8G8_SINTVK_FORMAT_R16_SINTVK_FORMAT_R8_SINTVK_FORMAT_A2B10G10R10_UINT_PACK32VK_FORMAT_R16G16_UINTVK_FORMAT_R8G8_UINTVK_FORMAT_R16_UINTVK_FORMAT_R8_UINTNoteshaderStorageImageExtendedFormats
    ///     feature only adds a guarantee of format support, which is specified for the whole physical device. Therefore
    ///     enabling or disabling the feature via vkCreateDevice has no practical effect.To query for additional properties, or
    ///     if the feature is not supported, vkGetPhysicalDeviceFormatProperties and vkGetPhysicalDeviceImageFormatProperties
    ///     can be used to check for supported properties of individual formats, as usual rules allow.VK_FORMAT_R32G32_UINT,
    ///     VK_FORMAT_R32G32_SINT, and VK_FORMAT_R32G32_SFLOAT from StorageImageExtendedFormats SPIR-V capability, are already
    ///     covered by core Vulkan mandatory format support.
    /// </summary>
    public VkBool32 shaderStorageImageExtendedFormats;

    /// <summary>
    ///     shaderStorageImageMultisample specifies whether multisampled storage images are supported. If this feature is
    ///     not enabled, images that are created with a usage that includes VK_IMAGE_USAGE_STORAGE_BIT must be created with
    ///     samples equal to VK_SAMPLE_COUNT_1_BIT. This also specifies whether shader modules can declare the
    ///     StorageImageMultisample and ImageMSArray capabilities.
    /// </summary>
    public VkBool32 shaderStorageImageMultisample;

    /// <summary>
    ///     shaderStorageImageReadWithoutFormat specifies whether storage images and storage texel buffers require a
    ///     format qualifier to be specified when reading. shaderStorageImageReadWithoutFormat applies only to formats listed
    ///     in the storage without formatlist.
    /// </summary>
    public VkBool32 shaderStorageImageReadWithoutFormat;

    /// <summary>
    ///     shaderStorageImageWriteWithoutFormat specifies whether storage images and storage texel buffers require a
    ///     format qualifier to be specified when writing. shaderStorageImageWriteWithoutFormat applies only to formats listed
    ///     in the storage without format list.
    /// </summary>
    public VkBool32 shaderStorageImageWriteWithoutFormat;

    /// <summary>
    ///     shaderUniformBufferArrayDynamicIndexing specifies whether arrays of uniform buffers can be indexed by
    ///     dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor
    ///     type of VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC must be indexed only by
    ///     constant integral expressions when aggregated into arrays in shader code. This also specifies whether shader
    ///     modules can declare the UniformBufferArrayDynamicIndexing capability.
    /// </summary>
    public VkBool32 shaderUniformBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderSampledImageArrayDynamicIndexing specifies whether arrays of samplers or sampled images can be indexed
    ///     by dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a
    ///     descriptor type of VK_DESCRIPTOR_TYPE_SAMPLER, VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, or
    ///     VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE must be indexed only by constant integral expressions when aggregated into arrays
    ///     in shader code. This also specifies whether shader modules can declare the SampledImageArrayDynamicIndexing
    ///     capability.
    /// </summary>
    public VkBool32 shaderSampledImageArrayDynamicIndexing;

    /// <summary>
    ///     shaderStorageBufferArrayDynamicIndexing specifies whether arrays of storage buffers can be indexed by
    ///     dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor
    ///     type of VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC must be indexed only by
    ///     constant integral expressions when aggregated into arrays in shader code. This also specifies whether shader
    ///     modules can declare the StorageBufferArrayDynamicIndexing capability.
    /// </summary>
    public VkBool32 shaderStorageBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderStorageImageArrayDynamicIndexing specifies whether arrays of storage images can be indexed by
    ///     dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor
    ///     type of VK_DESCRIPTOR_TYPE_STORAGE_IMAGE must be indexed only by constant integral expressions when aggregated into
    ///     arrays in shader code. This also specifies whether shader modules can declare the StorageImageArrayDynamicIndexing
    ///     capability.
    /// </summary>
    public VkBool32 shaderStorageImageArrayDynamicIndexing;

    /// <summary>
    ///     shaderClipDistance specifies whether clip distances are supported in shader code. If this feature is not
    ///     enabled, any members decorated with the ClipDistance built-in decoration must not be read from or written to in
    ///     shader modules. This also specifies whether shader modules can declare the ClipDistance capability.
    /// </summary>
    public VkBool32 shaderClipDistance;

    /// <summary>
    ///     shaderCullDistance specifies whether cull distances are supported in shader code. If this feature is not
    ///     enabled, any members decorated with the CullDistance built-in decoration must not be read from or written to in
    ///     shader modules. This also specifies whether shader modules can declare the CullDistance capability.
    /// </summary>
    public VkBool32 shaderCullDistance;

    /// <summary>
    ///     shaderFloat64 specifies whether 64-bit floats (doubles) are supported in shader code. If this feature is not
    ///     enabled, 64-bit floating-point types must not be used in shader code. This also specifies whether shader modules
    ///     can declare the Float64capability. Declaring and using 64-bit floats is enabled for all storage classes that SPIR-V
    ///     allows with the Float64 capability.
    /// </summary>
    public VkBool32 shaderFloat64;

    /// <summary>
    ///     shaderInt64 specifies whether 64-bit integers (signed and unsigned) are supported in shader code. If this
    ///     feature is not enabled, 64-bit integer types must not be used in shader code. This also specifies whether shader
    ///     modules can declare the Int64capability. Declaring and using 64-bit integers is enabled for all storage classes
    ///     that SPIR-V allows with the Int64 capability.
    /// </summary>
    public VkBool32 shaderInt64;

    /// <summary>
    ///     shaderInt16 specifies whether 16-bit integers (signed and unsigned) are supported in shader code. If this
    ///     feature is not enabled, 16-bit integer types must not be used in shader code. This also specifies whether shader
    ///     modules can declare the Int16capability. However, this only enables a subset of the storage classes that SPIR-V
    ///     allows for the Int16 SPIR-V capability: Declaring and using 16-bit integers in the Private, Workgroup (for
    ///     non-Block variables), and Function storage classes is enabled, while declaring them in the interface storage
    ///     classes (e.g., UniformConstant, Uniform, StorageBuffer, Input, Output, and PushConstant) is not enabled.
    /// </summary>
    public VkBool32 shaderInt16;

    /// <summary>
    ///     shaderResourceResidencyspecifies whether image operations that return resource residency information are
    ///     supported in shader code. If this feature is not enabled, the OpImageSparse* instructions must not be used in
    ///     shader code. This also specifies whether shader modules can declare the SparseResidency capability. The feature
    ///     requires at least one of the sparseResidency* features to be supported.
    /// </summary>
    public VkBool32 shaderResourceResidency;

    /// <summary>
    ///     shaderResourceMinLod specifies whether image operations specifying the minimum resource LOD are supported in
    ///     shader code. If this feature is not enabled, the MinLod image operand must not be used in shader code. This also
    ///     specifies whether shader modules can declare the MinLodcapability.
    /// </summary>
    public VkBool32 shaderResourceMinLod;

    /// <summary>
    ///     sparseBinding specifies whether resource memory can be managed at opaque sparse block level instead of at the
    ///     object level. If this feature is not enabled, resource memory must be bound only on a per-object basis using the
    ///     vkBindBufferMemory and vkBindImageMemory commands. In this case, buffers and images must not be created with
    ///     VK_BUFFER_CREATE_SPARSE_BINDING_BIT and VK_IMAGE_CREATE_SPARSE_BINDING_BIT set in the flags member of the
    ///     VkBufferCreateInfo and VkImageCreateInfo structures, respectively. Otherwise resource memory can be managed as
    ///     described in Sparse Resource Features.
    /// </summary>
    public VkBool32 sparseBinding;

    /// <summary>
    ///     sparseResidencyBuffer specifies whether the device can access partially resident buffers. If this feature is
    ///     not enabled, buffers must not be created with VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT set in the flagsmember of the
    ///     VkBufferCreateInfo structure.
    /// </summary>
    public VkBool32 sparseResidencyBuffer;

    /// <summary>
    ///     sparseResidencyImage2Dspecifies whether the device can access partially resident 2D images with 1 sample per
    ///     pixel. If this feature is not enabled, images with an imageType of VK_IMAGE_TYPE_2D and samples set to
    ///     VK_SAMPLE_COUNT_1_BIT must not be created with VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the flags member of the
    ///     VkImageCreateInfo structure.
    /// </summary>
    public VkBool32 sparseResidencyImage2D;

    /// <summary>
    ///     sparseResidencyImage3Dspecifies whether the device can access partially resident 3D images. If this feature
    ///     is not enabled, images with an imageType of VK_IMAGE_TYPE_3D must not be created with
    ///     VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the flags member of the VkImageCreateInfo structure.
    /// </summary>
    public VkBool32 sparseResidencyImage3D;

    /// <summary>
    ///     sparseResidency2Samplesspecifies whether the physical device can access partially resident 2D images with 2
    ///     samples per pixel. If this feature is not enabled, images with an imageType of VK_IMAGE_TYPE_2D and samples set to
    ///     VK_SAMPLE_COUNT_2_BIT must not be created with VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the flags member of the
    ///     VkImageCreateInfo structure.
    /// </summary>
    public VkBool32 sparseResidency2Samples;

    /// <summary>
    ///     sparseResidency4Samplesspecifies whether the physical device can access partially resident 2D images with 4
    ///     samples per pixel. If this feature is not enabled, images with an imageType of VK_IMAGE_TYPE_2D and samples set to
    ///     VK_SAMPLE_COUNT_4_BIT must not be created with VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the flags member of the
    ///     VkImageCreateInfo structure.
    /// </summary>
    public VkBool32 sparseResidency4Samples;

    /// <summary>
    ///     sparseResidency8Samplesspecifies whether the physical device can access partially resident 2D images with 8
    ///     samples per pixel. If this feature is not enabled, images with an imageType of VK_IMAGE_TYPE_2D and samples set to
    ///     VK_SAMPLE_COUNT_8_BIT must not be created with VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the flags member of the
    ///     VkImageCreateInfo structure.
    /// </summary>
    public VkBool32 sparseResidency8Samples;

    /// <summary>
    ///     sparseResidency16Samplesspecifies whether the physical device can access partially resident 2D images with 16
    ///     samples per pixel. If this feature is not enabled, images with an imageType of VK_IMAGE_TYPE_2D and samples set to
    ///     VK_SAMPLE_COUNT_16_BIT must not be created with VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the flags member of the
    ///     VkImageCreateInfo structure.
    /// </summary>
    public VkBool32 sparseResidency16Samples;

    /// <summary>
    ///     sparseResidencyAliasedspecifies whether the physical device can correctly access data aliased into multiple
    ///     locations. If this feature is not enabled, the VK_BUFFER_CREATE_SPARSE_ALIASED_BIT and
    ///     VK_IMAGE_CREATE_SPARSE_ALIASED_BIT enum values must not be used in flags members of the VkBufferCreateInfo and
    ///     VkImageCreateInfo structures, respectively.
    /// </summary>
    public VkBool32 sparseResidencyAliased;

    /// <summary>
    ///     variableMultisampleRatespecifies whether all pipelines that will be bound to a command buffer during a
    ///     subpass which uses no attachmentsmust have the same value for
    ///     VkPipelineMultisampleStateCreateInfo::rasterizationSamples. If set to VK_TRUE, the implementation supports variable
    ///     multisample rates in a subpass which uses no attachments. If set to VK_FALSE, then all pipelines bound in such a
    ///     subpass must have the same multisample rate. This has no effect in situations where a subpass uses any attachments.
    /// </summary>
    public VkBool32 variableMultisampleRate;

    /// <summary> inheritedQueries specifies whether a secondary command buffer may be executed while a query is active.</summary>
    public VkBool32 inheritedQueries;
}