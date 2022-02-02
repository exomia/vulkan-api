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
///     VkPhysicalDeviceLimits - Structure reporting implementation-dependent physical device limits -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLimits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLimits.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkPhysicalDeviceLimits
{
    /// <summary>
    ///     maxImageDimension1D is the largest dimension (width) that is guaranteed to be supported for all images
    ///     created with an imageType of VK_IMAGE_TYPE_1D. Some combinations of image parameters (format, usage, etc.) may
    ///     allow support for larger dimensions, which can be queried using vkGetPhysicalDeviceImageFormatProperties.
    /// </summary>
    public uint maxImageDimension1D;

    /// <summary>
    ///     maxImageDimension2D is the largest dimension (width or height) that is guaranteed to be supported for all
    ///     images created with an imageType of VK_IMAGE_TYPE_2D and without VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in flags.
    ///     Some combinations of image parameters (format, usage, etc.) may allow support for larger dimensions, which can be
    ///     queried using vkGetPhysicalDeviceImageFormatProperties.
    /// </summary>
    public uint maxImageDimension2D;

    /// <summary>
    ///     maxImageDimension3D is the largest dimension (width, height, or depth) that is guaranteed to be supported for
    ///     all images created with an imageType of VK_IMAGE_TYPE_3D. Some combinations of image parameters (format, usage,
    ///     etc.) may allow support for larger dimensions, which can be queried using vkGetPhysicalDeviceImageFormatProperties.
    /// </summary>
    public uint maxImageDimension3D;

    /// <summary>
    ///     maxImageDimensionCube is the largest dimension (width or height) that is guaranteed to be supported for all
    ///     images created with an imageType of VK_IMAGE_TYPE_2D and with VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in flags.
    ///     Some combinations of image parameters (format, usage, etc.) may allow support for larger dimensions, which can be
    ///     queried using vkGetPhysicalDeviceImageFormatProperties.
    /// </summary>
    public uint maxImageDimensionCube;

    /// <summary> maxImageArrayLayers is the maximum number of layers (arrayLayers) for an image.</summary>
    public uint maxImageArrayLayers;

    /// <summary>
    ///     maxTexelBufferElements is the maximum number of addressable texels for a buffer view created on a buffer
    ///     which was created with the VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set
    ///     in the usagemember of the VkBufferCreateInfo structure.
    /// </summary>
    public uint maxTexelBufferElements;

    /// <summary>
    ///     maxUniformBufferRange is the maximum value that can be specified in the range member of a
    ///     VkDescriptorBufferInfo structure passed to vkUpdateDescriptorSets for descriptors of type
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.
    /// </summary>
    public uint maxUniformBufferRange;

    /// <summary>
    ///     maxStorageBufferRange is the maximum value that can be specified in the range member of a
    ///     VkDescriptorBufferInfo structure passed to vkUpdateDescriptorSets for descriptors of type
    ///     VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.
    /// </summary>
    public uint maxStorageBufferRange;

    /// <summary>
    ///     maxPushConstantsSize is the maximum size, in bytes, of the pool of push constant memory. For each of the push
    ///     constant ranges indicated by the pPushConstantRanges member of the VkPipelineLayoutCreateInfostructure, (offset +
    ///     size) must be less than or equal to this limit.
    /// </summary>
    public uint maxPushConstantsSize;

    /// <summary>
    ///     maxMemoryAllocationCount is the maximum number of device memory allocations, as created by vkAllocateMemory,
    ///     which can simultaneously exist.
    /// </summary>
    public uint maxMemoryAllocationCount;

    /// <summary>
    ///     maxSamplerAllocationCount is the maximum number of sampler objects, as created by vkCreateSampler, which can
    ///     simultaneously exist on a device.
    /// </summary>
    public uint maxSamplerAllocationCount;

    /// <summary>
    ///     bufferImageGranularity is the granularity, in bytes, at which buffer or linear image resources, and optimal
    ///     image resources can be bound to adjacent offsets in the same VkDeviceMemory object without aliasing. See
    ///     Buffer-Image Granularity for more details.
    /// </summary>
    public VkDeviceSize bufferImageGranularity;

    /// <summary>
    ///     sparseAddressSpaceSize is the total amount of address space available, in bytes, for sparse memory resources.
    ///     This is an upper bound on the sum of the sizes of all sparse resources, regardless of whether any memory is bound
    ///     to them.
    /// </summary>
    public VkDeviceSize sparseAddressSpaceSize;

    /// <summary>
    ///     maxBoundDescriptorSets is the maximum number of descriptor sets that can be simultaneously used by a
    ///     pipeline. All DescriptorSet decorations in shader modules must have a value less than maxBoundDescriptorSets. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sets.
    /// </summary>
    public uint maxBoundDescriptorSets;

    /// <summary>
    ///     maxPerStageDescriptorSamplers is the maximum number of samplers that can be accessible to a single shader
    ///     stage in a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_SAMPLER or
    ///     VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against this limit. Only descriptors in descriptor set layouts
    ///     created without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. A
    ///     descriptor is accessible to a shader stage when the stageFlagsmember of the VkDescriptorSetLayoutBinding structure
    ///     has the bit for that shader stage set. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampler and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-combinedimagesampler.
    /// </summary>
    public uint maxPerStageDescriptorSamplers;

    /// <summary>
    ///     maxPerStageDescriptorUniformBuffers is the maximum number of uniform buffers that can be accessible to a
    ///     single shader stage in a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this limit. Only descriptors in descriptor set layouts
    ///     created without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. A
    ///     descriptor is accessible to a shader stage when the stageFlagsmember of the VkDescriptorSetLayoutBinding structure
    ///     has the bit for that shader stage set. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbuffer and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbufferdynamic.
    /// </summary>
    public uint maxPerStageDescriptorUniformBuffers;

    /// <summary>
    ///     maxPerStageDescriptorStorageBuffers is the maximum number of storage buffers that can be accessible to a
    ///     single shader stage in a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    ///     VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this limit. Only descriptors in descriptor set layouts
    ///     created without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. A
    ///     descriptor is accessible to a pipeline shader stage when the stageFlags member of the
    ///     VkDescriptorSetLayoutBindingstructure has the bit for that shader stage set. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebuffer and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebufferdynamic.
    /// </summary>
    public uint maxPerStageDescriptorStorageBuffers;

    /// <summary>
    ///     maxPerStageDescriptorSampledImages is the maximum number of sampled images that can be accessible to a single
    ///     shader stage in a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
    ///     VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, or VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this limit. Only
    ///     descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. A descriptor is
    ///     accessible to a pipeline shader stage when the stageFlags member of the VkDescriptorSetLayoutBindingstructure has
    ///     the bit for that shader stage set. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-combinedimagesampler,
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampledimage, and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformtexelbuffer.
    /// </summary>
    public uint maxPerStageDescriptorSampledImages;

    /// <summary>
    ///     maxPerStageDescriptorStorageImages is the maximum number of storage images that can be accessible to a single
    ///     shader stage in a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
    ///     VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER count against this limit. Only descriptors in descriptor set layouts
    ///     created without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. A
    ///     descriptor is accessible to a pipeline shader stage when the stageFlags member of the
    ///     VkDescriptorSetLayoutBindingstructure has the bit for that shader stage set. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage, and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer.
    /// </summary>
    public uint maxPerStageDescriptorStorageImages;

    /// <summary>
    ///     maxPerStageDescriptorInputAttachments is the maximum number of input attachments that can be accessible to a
    ///     single shader stage in a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENTcount
    ///     against this limit. Only descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. A descriptor is
    ///     accessible to a pipeline shader stage when the stageFlags member of the VkDescriptorSetLayoutBindingstructure has
    ///     the bit for that shader stage set. These are only supported for the fragment stage. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-inputattachment.
    /// </summary>
    public uint maxPerStageDescriptorInputAttachments;

    /// <summary>
    ///     maxPerStageResources is the maximum number of resources that can be accessible to a single shader stage in a
    ///     pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
    ///     VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER,
    ///     VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER, VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER, VK_DESCRIPTOR_TYPE_STORAGE_BUFFER,
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, or
    ///     VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit. Only descriptors in descriptor set layouts created
    ///     without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. For the
    ///     fragment shader stage the framebuffer color attachments also count against this limit.
    /// </summary>
    public uint maxPerStageResources;

    /// <summary>
    ///     maxDescriptorSetSamplers is the maximum number of samplers that can be included in a pipeline layout.
    ///     Descriptors with a type of VK_DESCRIPTOR_TYPE_SAMPLER or VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against
    ///     this limit. Only descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampler and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-combinedimagesampler.
    /// </summary>
    public uint maxDescriptorSetSamplers;

    /// <summary>
    ///     maxDescriptorSetUniformBuffers is the maximum number of uniform buffers that can be included in a pipeline
    ///     layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC
    ///     count against this limit. Only descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbuffer and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbufferdynamic.
    /// </summary>
    public uint maxDescriptorSetUniformBuffers;

    /// <summary>
    ///     maxDescriptorSetUniformBuffersDynamic is the maximum number of dynamic uniform buffers that can be included in
    ///     a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this limit.
    ///     Only descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbufferdynamic.
    /// </summary>
    public uint maxDescriptorSetUniformBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetStorageBuffers is the maximum number of storage buffers that can be included in a pipeline
    ///     layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC
    ///     count against this limit. Only descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebuffer and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebufferdynamic.
    /// </summary>
    public uint maxDescriptorSetStorageBuffers;

    /// <summary>
    ///     maxDescriptorSetStorageBuffersDynamic is the maximum number of dynamic storage buffers that can be included in
    ///     a pipeline layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this limit.
    ///     Only descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebufferdynamic.
    /// </summary>
    public uint maxDescriptorSetStorageBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetSampledImages is the maximum number of sampled images that can be included in a pipeline
    ///     layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, or
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this limit. Only descriptors in descriptor set layouts
    ///     created without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit.
    ///     See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-combinedimagesampler,
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampledimage, and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformtexelbuffer.
    /// </summary>
    public uint maxDescriptorSetSampledImages;

    /// <summary>
    ///     maxDescriptorSetStorageImages is the maximum number of storage images that can be included in a pipeline
    ///     layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER
    ///     count against this limit. Only descriptors in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage, and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer.
    /// </summary>
    public uint maxDescriptorSetStorageImages;

    /// <summary>
    ///     maxDescriptorSetInputAttachments is the maximum number of input attachments that can be included in a pipeline
    ///     layout. Descriptors with a type of VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENTcount against this limit. Only descriptors in
    ///     descriptor set layouts created without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count
    ///     against this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-inputattachment.
    /// </summary>
    public uint maxDescriptorSetInputAttachments;

    /// <summary>
    ///     maxVertexInputAttributes is the maximum number of vertex input attributes that can be specified for a
    ///     graphics pipeline. These are described in the array of VkVertexInputAttributeDescription structures that are
    ///     provided at graphics pipeline creation time via the pVertexAttributeDescriptions member of the
    ///     VkPipelineVertexInputStateCreateInfo structure. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fxvertex-attrib and
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fxvertex-input.
    /// </summary>
    public uint maxVertexInputAttributes;

    /// <summary>
    ///     maxVertexInputBindings is the maximum number of vertex buffers that can be specified for providing vertex
    ///     attributes to a graphics pipeline. These are described in the array of VkVertexInputBindingDescription structures
    ///     that are provided at graphics pipeline creation time via the pVertexBindingDescriptionsmember of the
    ///     VkPipelineVertexInputStateCreateInfo structure. The binding member of VkVertexInputBindingDescription mustbe less
    ///     than this limit. See https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fxvertex-input.
    /// </summary>
    public uint maxVertexInputBindings;

    /// <summary>
    ///     maxVertexInputAttributeOffset is the maximum vertex input attribute offset that can be added to the vertex
    ///     input binding stride. The offset member of the VkVertexInputAttributeDescriptionstructure must be less than or
    ///     equal to this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fxvertex-input.
    /// </summary>
    public uint maxVertexInputAttributeOffset;

    /// <summary>
    ///     maxVertexInputBindingStrideis the maximum vertex input binding stride that can be specified in a vertex input
    ///     binding. The stride member of the VkVertexInputBindingDescriptionstructure must be less than or equal to this
    ///     limit. See https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fxvertex-input.
    /// </summary>
    public uint maxVertexInputBindingStride;

    /// <summary>
    ///     maxVertexOutputComponents is the maximum number of components of output variables which can be output by a
    ///     vertex shader. See https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#shaders-vertex.
    /// </summary>
    public uint maxVertexOutputComponents;

    /// <summary>
    ///     maxTessellationGenerationLevel is the maximum tessellation generation level supported by the fixed-function
    ///     tessellation primitive generator. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#tessellation.
    /// </summary>
    public uint maxTessellationGenerationLevel;

    /// <summary>
    ///     maxTessellationPatchSize is the maximum patch size, in vertices, of patches that can be processed by the
    ///     tessellation control shader and tessellation primitive generator. The patchControlPoints member of the
    ///     VkPipelineTessellationStateCreateInfo structure specified at pipeline creation time and the value provided in the
    ///     OutputVerticesexecution mode of shader modules must be less than or equal to this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#tessellation.
    /// </summary>
    public uint maxTessellationPatchSize;

    /// <summary>
    ///     maxTessellationControlPerVertexInputComponents is the maximum number of components of input variables which
    ///     can be provided as per-vertex inputs to the tessellation control shader stage.
    /// </summary>
    public uint maxTessellationControlPerVertexInputComponents;

    /// <summary>
    ///     maxTessellationControlPerVertexOutputComponents is the maximum number of components of per-vertex output
    ///     variables which can be output from the tessellation control shader stage.
    /// </summary>
    public uint maxTessellationControlPerVertexOutputComponents;

    /// <summary>
    ///     maxTessellationControlPerPatchOutputComponents is the maximum number of components of per-patch output
    ///     variables which can be output from the tessellation control shader stage.
    /// </summary>
    public uint maxTessellationControlPerPatchOutputComponents;

    /// <summary>
    ///     maxTessellationControlTotalOutputComponents is the maximum total number of components of per-vertex and
    ///     per-patch output variables which can be output from the tessellation control shader stage.
    /// </summary>
    public uint maxTessellationControlTotalOutputComponents;

    /// <summary>
    ///     maxTessellationEvaluationInputComponents is the maximum number of components of input variables which can be
    ///     provided as per-vertex inputs to the tessellation evaluation shader stage.
    /// </summary>
    public uint maxTessellationEvaluationInputComponents;

    /// <summary>
    ///     maxTessellationEvaluationOutputComponents is the maximum number of components of per-vertex output variables
    ///     which can be output from the tessellation evaluation shader stage.
    /// </summary>
    public uint maxTessellationEvaluationOutputComponents;

    /// <summary>
    ///     maxGeometryShaderInvocations is the maximum invocation count supported for instanced geometry shaders. The
    ///     value provided in the Invocations execution mode of shader modules must be less than or equal to this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#geometry.
    /// </summary>
    public uint maxGeometryShaderInvocations;

    /// <summary>
    ///     maxGeometryInputComponentsis the maximum number of components of input variables which can be provided as
    ///     inputs to the geometry shader stage.
    /// </summary>
    public uint maxGeometryInputComponents;

    /// <summary>
    ///     maxGeometryOutputComponentsis the maximum number of components of output variables which can be output from
    ///     the geometry shader stage.
    /// </summary>
    public uint maxGeometryOutputComponents;

    /// <summary> maxGeometryOutputVertices is the maximum number of vertices which can be emitted by any geometry shader.</summary>
    public uint maxGeometryOutputVertices;

    /// <summary>
    ///     maxGeometryTotalOutputComponents is the maximum total number of components of output variables, across all
    ///     emitted vertices, which canbe output from the geometry shader stage.
    /// </summary>
    public uint maxGeometryTotalOutputComponents;

    /// <summary>
    ///     maxFragmentInputComponentsis the maximum number of components of input variables which can be provided as
    ///     inputs to the fragment shader stage.
    /// </summary>
    public uint maxFragmentInputComponents;

    /// <summary>
    ///     maxFragmentOutputAttachments is the maximum number of output attachments which can be written to by the
    ///     fragment shader stage.
    /// </summary>
    public uint maxFragmentOutputAttachments;

    /// <summary>
    ///     maxFragmentDualSrcAttachments is the maximum number of output attachments which can be written to by the
    ///     fragment shader stage when blending is enabled and one of the dual source blend modes is in use. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#framebuffer-dsb and dualSrcBlend.
    /// </summary>
    public uint maxFragmentDualSrcAttachments;

    /// <summary>
    ///     maxFragmentCombinedOutputResources is the total number of storage buffers, storage images, and output Location
    ///     decorated color attachments (described in Fragment Output Interface) which can be used in the fragment shader
    ///     stage.
    /// </summary>
    public uint maxFragmentCombinedOutputResources;

    /// <summary>
    ///     maxComputeSharedMemorySizeis the maximum total storage size, in bytes, available for variables declared with
    ///     the Workgroup storage class in shader modules (or with the shared storage qualifier in GLSL) in the compute shader
    ///     stage. When variables declared with the Workgroup storage class are explicitly laid out (hence they are also
    ///     decorated with Block), the amount of storage consumed is the size of the largest Block variable, not counting any
    ///     padding at the end. The amount of storage consumed by the non-Block variables declared with the Workgroup storage
    ///     class is implementation-dependent. However, the amount of storage consumed may not exceed the largest block size
    ///     that would be obtained if all active non-Block variables declared with Workgroup storage class were assigned
    ///     offsets in an arbitrary order by successively taking the smallest valid offset according to the Standard Storage
    ///     Buffer Layout rules. (This is equivalent to using the GLSL std430 layout rules.)
    /// </summary>
    public uint maxComputeSharedMemorySize;

    /// <summary>
    ///     maxComputeWorkGroupCount[3] is the maximum number of local workgroups that can be dispatched by a single
    ///     dispatching command. These three values represent the maximum number of local workgroups for the X, Y, and Z
    ///     dimensions, respectively. The workgroup count parameters to the dispatching commands must be less than or equal to
    ///     the corresponding limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#dispatch.
    /// </summary>
    public VkArray3<uint> maxComputeWorkGroupCount;

    /// <summary>
    ///     maxComputeWorkGroupInvocations is the maximum total number of     compute shader invocations in a single
    ///     local workgroup.     The product of the X, Y, and Z sizes, as specified by the LocalSizeor LocalSizeId    execution
    ///     mode in shader modules or by the object decorated by the     WorkgroupSize decoration, must be less than or equal
    ///     to this     limit.
    /// </summary>
    public uint maxComputeWorkGroupInvocations;

    /// <summary>
    ///     maxComputeWorkGroupSize[3] is     the maximum size of a local compute workgroup, per dimension.     These
    ///     three values represent the maximum local workgroup size in the X,     Y, and Z dimensions, respectively.     The x,
    ///     y, and z sizes, as specified by the     LocalSizeor LocalSizeId    execution mode or by the object decorated by the
    ///     WorkgroupSize    decoration in shader modules, must be less than or equal to the     corresponding limit.
    /// </summary>
    public VkArray3<uint> maxComputeWorkGroupSize;

    /// <summary>
    ///     subPixelPrecisionBits is the number of bits of subpixel precision in framebuffer coordinates xf and yf. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast.
    /// </summary>
    public uint subPixelPrecisionBits;

    /// <summary>
    ///     subTexelPrecisionBits is the number of bits of precision in the division along an axis of an image used for
    ///     minification and magnification filters. 2subTexelPrecisionBits is the actual number of divisions along each axis of
    ///     the image represented. Sub-texel values calculated during image sampling will snap to these locations when
    ///     generating the filtered results.
    /// </summary>
    public uint subTexelPrecisionBits;

    /// <summary>
    ///     mipmapPrecisionBits is the number of bits of division that the LOD calculation for mipmap fetching get
    ///     snapped to when determining the contribution from each mip level to the mip filtered results. 2mipmapPrecisionBits
    ///     is the actual number of divisions.
    /// </summary>
    public uint mipmapPrecisionBits;

    /// <summary>
    ///     maxDrawIndexedIndexValue is the maximum index value that can be used for indexed draw calls when using 32-bit
    ///     indices. This excludes the primitive restart index value of 0xFFFFFFFF. See fullDrawIndexUint32.
    /// </summary>
    public uint maxDrawIndexedIndexValue;

    /// <summary>
    ///     maxDrawIndirectCount is the maximum draw count that is supported for indirect drawing calls. See
    ///     multiDrawIndirect.
    /// </summary>
    public uint maxDrawIndirectCount;

    /// <summary>
    ///     maxSamplerLodBias is the maximum absolute sampler LOD bias. The sum of the mipLodBias member of the
    ///     VkSamplerCreateInfostructure and the Bias operand of image sampling operations in shader modules (or 0 if no Bias
    ///     operand is provided to an image sampling operation) are clamped to the range
    ///     [-maxSamplerLodBias,+maxSamplerLodBias]. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-mipLodBias.
    /// </summary>
    public float maxSamplerLodBias;

    /// <summary>
    ///     maxSamplerAnisotropy is the maximum degree of sampler anisotropy. The maximum degree of anisotropic filtering
    ///     used for an image sampling operation is the minimum of the maxAnisotropy member of the VkSamplerCreateInfo
    ///     structure and this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-maxAnisotropy.
    /// </summary>
    public float maxSamplerAnisotropy;

    /// <summary>
    ///     maxViewports is the maximum number of active viewports. The viewportCount member of the
    ///     VkPipelineViewportStateCreateInfo structure that is provided at pipeline creation must be less than or equal to
    ///     this limit.
    /// </summary>
    public uint maxViewports;

    /// <summary>
    ///     maxViewportDimensions[2] are the maximum viewport dimensions in the X (width) and Y (height) dimensions,
    ///     respectively. The maximum viewport dimensions must be greater than or equal to the largest image which can be
    ///     created and used as a framebuffer attachment. See Controlling the Viewport.
    /// </summary>
    public VkArray2<uint> maxViewportDimensions;

    /// <summary>
    ///     viewportBoundsRange[2] is the [minimum, maximum] range that the corners of a viewport must be contained in.
    ///     This range must be at least [-2 × size, 2 × size - 1], where size = max(maxViewportDimensions[0],
    ///     maxViewportDimensions[1]). See Controlling the Viewport.NoteThe intent of the viewportBoundsRange limit is to allow
    ///     a maximum sized viewport to be arbitrarily shifted relative to the output target as long as at least some portion
    ///     intersects. This would give a bounds limit of [-size +  1, 2 × size - 1] which would allow all possible
    ///     non-empty-set intersections of the output target and the viewport. Since these numbers are typically powers of two,
    ///     picking the signed number range using the smallest possible number of bits ends up with the specified range.
    /// </summary>
    public VkArray2<float> viewportBoundsRange;

    /// <summary>
    ///     viewportSubPixelBits is the number of bits of subpixel precision for viewport bounds. The subpixel precision
    ///     that floating-point viewport bounds are interpreted at is given by this limit.
    /// </summary>
    public uint viewportSubPixelBits;

    /// <summary>
    ///     minMemoryMapAlignment is the minimum required alignment, in bytes, of host visible memory allocations within
    ///     the host address space. When mapping a memory allocation with vkMapMemory, subtracting offset bytes from the
    ///     returned pointer will always produce an integer multiple of this limit. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#memory-device-hostaccess. The value
    ///     must be a power of two.
    /// </summary>
    public nuint minMemoryMapAlignment;

    /// <summary>
    ///     minTexelBufferOffsetAlignment is the minimum required alignment, in bytes, for the offset member of the
    ///     VkBufferViewCreateInfo structure for texel buffers. The value must be a power of two. If texelBufferAlignment is
    ///     enabled, this limit is equivalent to the maximum of the uniformTexelBufferOffsetAlignmentBytes and
    ///     storageTexelBufferOffsetAlignmentBytes members of VkPhysicalDeviceTexelBufferAlignmentProperties, but smaller
    ///     alignment is optionally allowed by storageTexelBufferOffsetSingleTexelAlignment and
    ///     uniformTexelBufferOffsetSingleTexelAlignment. If texelBufferAlignment is not enabled,
    ///     VkBufferViewCreateInfo::offset must be a multiple of this value.
    /// </summary>
    public VkDeviceSize minTexelBufferOffsetAlignment;

    /// <summary>
    ///     minUniformBufferOffsetAlignment is the minimum requiredalignment, in bytes, for the offset member of the
    ///     VkDescriptorBufferInfo structure for uniform buffers. When a descriptor of type VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER
    ///     or VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC is updated, the offset must be an integer multiple of this limit.
    ///     Similarly, dynamic offsets for uniform buffers must be multiples of this limit. The value must be a power of two.
    /// </summary>
    public VkDeviceSize minUniformBufferOffsetAlignment;

    /// <summary>
    ///     minStorageBufferOffsetAlignment is the minimum requiredalignment, in bytes, for the offset member of the
    ///     VkDescriptorBufferInfo structure for storage buffers. When a descriptor of type VK_DESCRIPTOR_TYPE_STORAGE_BUFFER
    ///     or VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC is updated, the offset must be an integer multiple of this limit.
    ///     Similarly, dynamic offsets for storage buffers must be multiples of this limit. The value must be a power of two.
    /// </summary>
    public VkDeviceSize minStorageBufferOffsetAlignment;

    /// <summary>
    ///     minTexelOffset is the minimum offset value for the ConstOffset image operand of any of the OpImageSample* or
    ///     OpImageFetch* image instructions.
    /// </summary>
    public int minTexelOffset;

    /// <summary>
    ///     maxTexelOffset is the maximum offset value for the ConstOffset image operand of any of the OpImageSample* or
    ///     OpImageFetch* image instructions.
    /// </summary>
    public uint maxTexelOffset;

    /// <summary>
    ///     minTexelGatherOffset is the minimum offset value for the Offset, ConstOffset, or ConstOffsets image operands
    ///     of any of the OpImage*Gather image instructions.
    /// </summary>
    public int minTexelGatherOffset;

    /// <summary>
    ///     maxTexelGatherOffset is the maximum offset value for the Offset, ConstOffset, or ConstOffsets image operands
    ///     of any of the OpImage*Gather image instructions.
    /// </summary>
    public uint maxTexelGatherOffset;

    /// <summary>
    ///     minInterpolationOffset is the base minimum (inclusive) negative offset value for the Offsetoperand of the
    ///     InterpolateAtOffset extended instruction.
    /// </summary>
    public float minInterpolationOffset;

    /// <summary>
    ///     maxInterpolationOffset is the base maximum (inclusive) positive offset value for the Offsetoperand of the
    ///     InterpolateAtOffset extended instruction.
    /// </summary>
    public float maxInterpolationOffset;

    /// <summary>
    ///     subPixelInterpolationOffsetBits is the number of fractional bits that the x and y offsets to the
    ///     InterpolateAtOffsetextended instruction may be rounded to as fixed-point values.
    /// </summary>
    public uint subPixelInterpolationOffsetBits;

    /// <summary>
    ///     maxFramebufferWidth is the maximum width for a framebuffer. The width member of the VkFramebufferCreateInfo
    ///     structure must be less than or equal to this limit.
    /// </summary>
    public uint maxFramebufferWidth;

    /// <summary>
    ///     maxFramebufferHeight is the maximum height for a framebuffer. The height member of the
    ///     VkFramebufferCreateInfo structure must be less than or equal to this limit.
    /// </summary>
    public uint maxFramebufferHeight;

    /// <summary>
    ///     maxFramebufferLayers is the maximum layer count for a layered framebuffer. The layers member of the
    ///     VkFramebufferCreateInfo structure must be less than or equal to this limit.
    /// </summary>
    public uint maxFramebufferLayers;

    /// <summary>
    ///     framebufferColorSampleCounts is a bitmask1 of VkSampleCountFlagBits indicating the color sample counts that
    ///     are supported for all framebuffer color attachments with floating- or fixed-point formats. For color attachments
    ///     with integer formats, see framebufferIntegerColorSampleCounts.
    /// </summary>
    public VkSampleCountFlags framebufferColorSampleCounts;

    /// <summary>
    ///     framebufferDepthSampleCounts is a bitmask1 of VkSampleCountFlagBits indicating the supported depth sample
    ///     counts for all framebuffer depth/stencil attachments, when the format includes a depth component.
    /// </summary>
    public VkSampleCountFlags framebufferDepthSampleCounts;

    /// <summary>
    ///     framebufferStencilSampleCounts is a bitmask1 of VkSampleCountFlagBits indicating the supported stencil sample
    ///     counts for all framebuffer depth/stencil attachments, when the format includes a stencil component.
    /// </summary>
    public VkSampleCountFlags framebufferStencilSampleCounts;

    /// <summary>
    ///     framebufferNoAttachmentsSampleCounts is a bitmask1 of VkSampleCountFlagBits indicating the supported sample
    ///     counts for a subpass which uses no attachments.
    /// </summary>
    public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;

    /// <summary>
    ///     maxColorAttachments is the maximum number of color attachments that can be used by a subpass in a render
    ///     pass. The colorAttachmentCount member of the VkSubpassDescriptionor VkSubpassDescription2structure must be less
    ///     than or equal to this limit.
    /// </summary>
    public uint maxColorAttachments;

    /// <summary>
    ///     sampledImageColorSampleCounts is a bitmask1 of VkSampleCountFlagBits indicating the sample counts supported
    ///     for all 2D images created with VK_IMAGE_TILING_OPTIMAL, usagecontaining VK_IMAGE_USAGE_SAMPLED_BIT, and a
    ///     non-integer color format.
    /// </summary>
    public VkSampleCountFlags sampledImageColorSampleCounts;

    /// <summary>
    ///     sampledImageIntegerSampleCounts is a bitmask1 of VkSampleCountFlagBits indicating the sample counts supported
    ///     for all 2D images created with VK_IMAGE_TILING_OPTIMAL, usagecontaining VK_IMAGE_USAGE_SAMPLED_BIT, and an integer
    ///     color format.
    /// </summary>
    public VkSampleCountFlags sampledImageIntegerSampleCounts;

    /// <summary>
    ///     sampledImageDepthSampleCounts is a bitmask1 of VkSampleCountFlagBits indicating the sample counts supported
    ///     for all 2D images created with VK_IMAGE_TILING_OPTIMAL, usagecontaining VK_IMAGE_USAGE_SAMPLED_BIT, and a depth
    ///     format.
    /// </summary>
    public VkSampleCountFlags sampledImageDepthSampleCounts;

    /// <summary>
    ///     sampledImageStencilSampleCounts is a bitmask1 of VkSampleCountFlagBits indicating the sample counts supported
    ///     for all 2D images created with VK_IMAGE_TILING_OPTIMAL, usagecontaining VK_IMAGE_USAGE_SAMPLED_BIT, and a stencil
    ///     format.
    /// </summary>
    public VkSampleCountFlags sampledImageStencilSampleCounts;

    /// <summary>
    ///     storageImageSampleCounts is a bitmask1 of VkSampleCountFlagBits indicating the sample counts supported for
    ///     all 2D images created with VK_IMAGE_TILING_OPTIMAL, and usage containing VK_IMAGE_USAGE_STORAGE_BIT.
    /// </summary>
    public VkSampleCountFlags storageImageSampleCounts;

    /// <summary>
    ///     maxSampleMaskWords is the maximum number of array elements of a variable decorated with the SampleMask
    ///     built-in decoration.
    /// </summary>
    public uint maxSampleMaskWords;

    /// <summary>
    ///     timestampComputeAndGraphicsspecifies support for timestamps on all graphics and compute queues. If this limit
    ///     is set to VK_TRUE, all queues that advertise the VK_QUEUE_GRAPHICS_BIT or VK_QUEUE_COMPUTE_BIT in the
    ///     VkQueueFamilyProperties::queueFlags support VkQueueFamilyProperties::timestampValidBits of at least 36. See
    ///     Timestamp Queries.
    /// </summary>
    public VkBool32 timestampComputeAndGraphics;

    /// <summary>
    ///     timestampPeriod is the number of nanoseconds required for a timestamp query to be incremented by 1. See
    ///     Timestamp Queries.
    /// </summary>
    public float timestampPeriod;

    /// <summary>
    ///     maxClipDistances is the maximum number of clip distances that can be used in a single shader stage. The size
    ///     of any array declared with the ClipDistance built-in decoration in a shader module must be less than or equal to
    ///     this limit.
    /// </summary>
    public uint maxClipDistances;

    /// <summary>
    ///     maxCullDistances is the maximum number of cull distances that can be used in a single shader stage. The size
    ///     of any array declared with the CullDistance built-in decoration in a shader module must be less than or equal to
    ///     this limit.
    /// </summary>
    public uint maxCullDistances;

    /// <summary>
    ///     maxCombinedClipAndCullDistances is the maximum combined number of clip and cull distances that can be used in
    ///     a single shader stage. The sum of the sizes of any pair of arrays declared with the ClipDistance and CullDistance
    ///     built-in decoration used by a single shader stage in a shader module must be less than or equal to this limit.
    /// </summary>
    public uint maxCombinedClipAndCullDistances;

    /// <summary>
    ///     discreteQueuePriorities is the number of discrete priorities that can be assigned to a queue based on the
    ///     value of each member of VkDeviceQueueCreateInfo::pQueuePriorities. This must be at least 2, and levels must be
    ///     spread evenly over the range, with at least one level at 1.0, and another at 0.0. See
    ///     https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#devsandqueues-priority.
    /// </summary>
    public uint discreteQueuePriorities;

    /// <summary>
    ///     pointSizeRange[2] is the range [minimum,maximum] of supported sizes for points. Values written to variables
    ///     decorated with the PointSize built-in decoration are clamped to this range.
    /// </summary>
    public VkArray2<float> pointSizeRange;

    /// <summary>
    ///     lineWidthRange[2] is the range [minimum,maximum] of supported widths for lines. Values specified by the
    ///     lineWidth member of the VkPipelineRasterizationStateCreateInfo or the lineWidthparameter to vkCmdSetLineWidth are
    ///     clamped to this range.
    /// </summary>
    public VkArray2<float> lineWidthRange;

    /// <summary>
    ///     pointSizeGranularity is the granularity of supported point sizes. Not all point sizes in the range defined by
    ///     pointSizeRange are supported. This limit specifies the granularity (or increment) between successive supported
    ///     point sizes.
    /// </summary>
    public float pointSizeGranularity;

    /// <summary>
    ///     lineWidthGranularity is the granularity of supported line widths. Not all line widths in the range defined by
    ///     lineWidthRange are supported. This limit specifies the granularity (or increment) between successive supported line
    ///     widths.
    /// </summary>
    public float lineWidthGranularity;

    /// <summary>
    ///     strictLines specifies whether lines are rasterized according to the preferred method of rasterization. If set
    ///     to VK_FALSE, lines may be rasterized under a relaxed set of rules. If set to VK_TRUE, lines are rasterized as per
    ///     the strict definition. See Basic Line Segment Rasterization.
    /// </summary>
    public VkBool32 strictLines;

    /// <summary>
    ///     standardSampleLocationsspecifies whether rasterization uses the standard sample locations as documented in
    ///     Multisampling. If set to VK_TRUE, the implementation uses the documented sample locations. If set to VK_FALSE, the
    ///     implementation may use different sample locations.
    /// </summary>
    public VkBool32 standardSampleLocations;

    /// <summary>
    ///     optimalBufferCopyOffsetAlignment is the optimal buffer offset alignment in bytes for vkCmdCopyBufferToImage2,
    ///     vkCmdCopyBufferToImage, vkCmdCopyImageToBuffer2, and vkCmdCopyImageToBuffer. The per texel alignment requirements
    ///     are enforced, but applications should use the optimal alignment for optimal performance and power use. The value
    ///     must be a power of two.
    /// </summary>
    public VkDeviceSize optimalBufferCopyOffsetAlignment;

    /// <summary>
    ///     optimalBufferCopyRowPitchAlignment is the optimal buffer row pitch alignment in bytes for
    ///     vkCmdCopyBufferToImage2, vkCmdCopyBufferToImage, vkCmdCopyImageToBuffer2, and vkCmdCopyImageToBuffer. Row pitch is
    ///     the number of bytes between texels with the same X coordinate in adjacent rows (Y coordinates differ by one). The
    ///     per texel alignment requirements are enforced, but applications should use the optimal alignment for optimal
    ///     performance and power use. The value must be a power of two.
    /// </summary>
    public VkDeviceSize optimalBufferCopyRowPitchAlignment;

    /// <summary>
    ///     nonCoherentAtomSize is the size and alignment in bytes that bounds concurrent access to host-mapped device
    ///     memory. The value must be a power of two.1For all bitmasks of VkSampleCountFlagBits, the sample count limits
    ///     defined above represent the minimum supported sample counts for each image type. Individual images may support
    ///     additional sample counts, which are queried using vkGetPhysicalDeviceImageFormatProperties as described in
    ///     Supported Sample Counts.
    /// </summary>
    public VkDeviceSize nonCoherentAtomSize;
}