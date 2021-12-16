﻿#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public struct VkPhysicalDeviceFeatures
{
    public VkBool32 robustBufferAccess;
    public VkBool32 fullDrawIndexUint32;
    public VkBool32 imageCubeArray;
    public VkBool32 independentBlend;
    public VkBool32 geometryShader;
    public VkBool32 tessellationShader;
    public VkBool32 sampleRateShading;
    public VkBool32 dualSrcBlend;
    public VkBool32 logicOp;
    public VkBool32 multiDrawIndirect;
    public VkBool32 drawIndirectFirstInstance;
    public VkBool32 depthClamp;
    public VkBool32 depthBiasClamp;
    public VkBool32 fillModeNonSolid;
    public VkBool32 depthBounds;
    public VkBool32 wideLines;
    public VkBool32 largePoints;
    public VkBool32 alphaToOne;
    public VkBool32 multiViewport;
    public VkBool32 samplerAnisotropy;
    public VkBool32 textureCompressionETC2;
    public VkBool32 textureCompressionASTC_LDR;
    public VkBool32 textureCompressionBC;
    public VkBool32 occlusionQueryPrecise;
    public VkBool32 pipelineStatisticsQuery;
    public VkBool32 vertexPipelineStoresAndAtomics;
    public VkBool32 fragmentStoresAndAtomics;
    public VkBool32 shaderTessellationAndGeometryPointSize;
    public VkBool32 shaderImageGatherExtended;
    public VkBool32 shaderStorageImageExtendedFormats;
    public VkBool32 shaderStorageImageMultisample;
    public VkBool32 shaderStorageImageReadWithoutFormat;
    public VkBool32 shaderStorageImageWriteWithoutFormat;
    public VkBool32 shaderUniformBufferArrayDynamicIndexing;
    public VkBool32 shaderSampledImageArrayDynamicIndexing;
    public VkBool32 shaderStorageBufferArrayDynamicIndexing;
    public VkBool32 shaderStorageImageArrayDynamicIndexing;
    public VkBool32 shaderClipDistance;
    public VkBool32 shaderCullDistance;
    public VkBool32 shaderFloat64;
    public VkBool32 shaderInt64;
    public VkBool32 shaderInt16;
    public VkBool32 shaderResourceResidency;
    public VkBool32 shaderResourceMinLod;
    public VkBool32 sparseBinding;
    public VkBool32 sparseResidencyBuffer;
    public VkBool32 sparseResidencyImage2D;
    public VkBool32 sparseResidencyImage3D;
    public VkBool32 sparseResidency2Samples;
    public VkBool32 sparseResidency4Samples;
    public VkBool32 sparseResidency8Samples;
    public VkBool32 sparseResidency16Samples;
    public VkBool32 sparseResidencyAliased;
    public VkBool32 variableMultisampleRate;
    public VkBool32 inheritedQueries;
}