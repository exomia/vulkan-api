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
    ///     through buffer device addresses are not bounds-checked.If the
    ///     VkPhysicalDeviceCooperativeMatrixFeaturesNV::cooperativeMatrixRobustBufferAccessfeature is not enabled, then
    ///     accesses using OpCooperativeMatrixLoadNV and OpCooperativeMatrixStoreNVmay not be bounds-checked.If the
    ///     VkPhysicalDeviceCooperativeMatrixFeaturesKHR::cooperativeMatrixRobustBufferAccessfeature is not enabled, then
    ///     accesses using OpCooperativeMatrixLoadKHR and OpCooperativeMatrixStoreKHRmay not be bounds-checked.NoteIf a SPIR-V
    ///     OpLoad instruction loads a structure and the tail end of the structure is out of bounds, then all members of the
    ///     structure are considered out of bounds even if the members at the end are not statically used.
    /// </summary>
    public VkBool32 robustBufferAccess;

    /// <summary>
    ///     fullDrawIndexUint32<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 fullDrawIndexUint32;

    /// <summary>
    ///     imageCubeArray<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 imageCubeArray;

    /// <summary>
    ///     independentBlend<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 independentBlend;

    /// <summary>
    ///     geometryShader<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 geometryShader;

    /// <summary>
    ///     tessellationShader<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 tessellationShader;

    /// <summary>
    ///     sampleRateShading<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sampleRateShading;

    /// <summary>
    ///     dualSrcBlend<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 dualSrcBlend;

    /// <summary>
    ///     logicOp<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 logicOp;

    /// <summary>
    ///     multiDrawIndirect<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 multiDrawIndirect;

    /// <summary>
    ///     drawIndirectFirstInstance<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 drawIndirectFirstInstance;

    /// <summary>
    ///     depthClamp<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 depthClamp;

    /// <summary>
    ///     depthBiasClamp<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 depthBiasClamp;

    /// <summary>
    ///     fillModeNonSolid<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 fillModeNonSolid;

    /// <summary>
    ///     depthBounds<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 depthBounds;

    /// <summary>
    ///     wideLines<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 wideLines;

    /// <summary>
    ///     largePoints<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 largePoints;

    /// <summary>
    ///     alphaToOne<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 alphaToOne;

    /// <summary>
    ///     multiViewport<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 multiViewport;

    /// <summary>
    ///     samplerAnisotropy<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 samplerAnisotropy;

    /// <summary>
    ///     textureCompressionETC2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 textureCompressionETC2;

    /// <summary>
    ///     textureCompressionASTC_LDR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 textureCompressionASTC_LDR;

    /// <summary>
    ///     textureCompressionBC<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 textureCompressionBC;

    /// <summary>
    ///     occlusionQueryPrecise<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 occlusionQueryPrecise;

    /// <summary>
    ///     pipelineStatisticsQuery<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 pipelineStatisticsQuery;

    /// <summary>
    ///     vertexPipelineStoresAndAtomics<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 vertexPipelineStoresAndAtomics;

    /// <summary>
    ///     fragmentStoresAndAtomics<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 fragmentStoresAndAtomics;

    /// <summary>
    ///     shaderTessellationAndGeometryPointSize<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderTessellationAndGeometryPointSize;

    /// <summary>
    ///     shaderImageGatherExtended<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderImageGatherExtended;

    /// <summary>
    ///     shaderStorageImageExtendedFormats<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderStorageImageExtendedFormats;

    /// <summary>
    ///     shaderStorageImageMultisample<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderStorageImageMultisample;

    /// <summary>
    ///     shaderStorageImageReadWithoutFormat<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderStorageImageReadWithoutFormat;

    /// <summary>
    ///     shaderStorageImageWriteWithoutFormat<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderStorageImageWriteWithoutFormat;

    /// <summary>
    ///     shaderUniformBufferArrayDynamicIndexing<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderUniformBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderSampledImageArrayDynamicIndexing<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderSampledImageArrayDynamicIndexing;

    /// <summary>
    ///     shaderStorageBufferArrayDynamicIndexing<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderStorageBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderStorageImageArrayDynamicIndexing<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderStorageImageArrayDynamicIndexing;

    /// <summary>
    ///     shaderClipDistance<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderClipDistance;

    /// <summary>
    ///     shaderCullDistance<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderCullDistance;

    /// <summary>
    ///     shaderFloat64<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderFloat64;

    /// <summary>
    ///     shaderInt64<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderInt64;

    /// <summary>
    ///     shaderInt16<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderInt16;

    /// <summary>
    ///     shaderResourceResidency<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderResourceResidency;

    /// <summary>
    ///     shaderResourceMinLod<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 shaderResourceMinLod;

    /// <summary>
    ///     sparseBinding<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sparseBinding;

    /// <summary>
    ///     sparseResidencyBuffer<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sparseResidencyBuffer;

    /// <summary>
    ///     sparseResidencyImage2D<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sparseResidencyImage2D;

    /// <summary>
    ///     sparseResidencyImage3D<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sparseResidencyImage3D;

    /// <summary>
    ///     sparseResidency2Samples<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sparseResidency2Samples;

    /// <summary>
    ///     sparseResidency4Samples<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sparseResidency4Samples;

    /// <summary>
    ///     sparseResidency8Samples<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sparseResidency8Samples;

    /// <summary>
    ///     sparseResidency16Samples<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sparseResidency16Samples;

    /// <summary>
    ///     sparseResidencyAliased<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 sparseResidencyAliased;

    /// <summary>
    ///     variableMultisampleRate<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 variableMultisampleRate;

    /// <summary>
    ///     inheritedQueries<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceFeatures</a>
    /// </summary>
    public VkBool32 inheritedQueries;
}