#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkResult;
global using static Exomia.Vulkan.Api.Core.VkStructureType;
global using static Exomia.Vulkan.Api.Core.VkObjectType;
global using static Exomia.Vulkan.Api.Core.VkVendorId;
global using static Exomia.Vulkan.Api.Core.VkPipelineCacheHeaderVersion;
global using static Exomia.Vulkan.Api.Core.VkFormat;
global using static Exomia.Vulkan.Api.Core.VkFormatFeatureFlagBits;
global using static Exomia.Vulkan.Api.Core.VkImageCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkImageTiling;
global using static Exomia.Vulkan.Api.Core.VkImageType;
global using static Exomia.Vulkan.Api.Core.VkImageUsageFlagBits;
global using static Exomia.Vulkan.Api.Core.VkInternalAllocationType;
global using static Exomia.Vulkan.Api.Core.VkMemoryHeapFlagBits;
global using static Exomia.Vulkan.Api.Core.VkMemoryPropertyFlagBits;
global using static Exomia.Vulkan.Api.Core.VkPhysicalDeviceType;
global using static Exomia.Vulkan.Api.Core.VkQueueFlagBits;
global using static Exomia.Vulkan.Api.Core.VkSampleCountFlagBits;
global using static Exomia.Vulkan.Api.Core.VkSystemAllocationScope;
global using static Exomia.Vulkan.Api.Core.VkPipelineStageFlagBits;
global using static Exomia.Vulkan.Api.Core.VkImageAspectFlagBits;
global using static Exomia.Vulkan.Api.Core.VkSparseImageFormatFlagBits;
global using static Exomia.Vulkan.Api.Core.VkSparseMemoryBindFlagBits;
global using static Exomia.Vulkan.Api.Core.VkFenceCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkEventCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkQueryPipelineStatisticFlagBits;
global using static Exomia.Vulkan.Api.Core.VkQueryResultFlagBits;
global using static Exomia.Vulkan.Api.Core.VkQueryType;
global using static Exomia.Vulkan.Api.Core.VkBufferCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkBufferUsageFlagBits;
global using static Exomia.Vulkan.Api.Core.VkSharingMode;
global using static Exomia.Vulkan.Api.Core.VkImageLayout;
global using static Exomia.Vulkan.Api.Core.VkComponentSwizzle;
global using static Exomia.Vulkan.Api.Core.VkImageViewCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkImageViewType;
global using static Exomia.Vulkan.Api.Core.VkBlendFactor;
global using static Exomia.Vulkan.Api.Core.VkBlendOp;
global using static Exomia.Vulkan.Api.Core.VkColorComponentFlagBits;
global using static Exomia.Vulkan.Api.Core.VkCompareOp;
global using static Exomia.Vulkan.Api.Core.VkCullModeFlagBits;
global using static Exomia.Vulkan.Api.Core.VkDynamicState;
global using static Exomia.Vulkan.Api.Core.VkFrontFace;
global using static Exomia.Vulkan.Api.Core.VkLogicOp;
global using static Exomia.Vulkan.Api.Core.VkPipelineCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkPipelineShaderStageCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkPolygonMode;
global using static Exomia.Vulkan.Api.Core.VkPrimitiveTopology;
global using static Exomia.Vulkan.Api.Core.VkShaderStageFlagBits;
global using static Exomia.Vulkan.Api.Core.VkStencilOp;
global using static Exomia.Vulkan.Api.Core.VkVertexInputRate;
global using static Exomia.Vulkan.Api.Core.VkBorderColor;
global using static Exomia.Vulkan.Api.Core.VkFilter;
global using static Exomia.Vulkan.Api.Core.VkSamplerAddressMode;
global using static Exomia.Vulkan.Api.Core.VkSamplerCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkSamplerMipmapMode;
global using static Exomia.Vulkan.Api.Core.VkDescriptorPoolCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkDescriptorSetLayoutCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkDescriptorType;
global using static Exomia.Vulkan.Api.Core.VkAccessFlagBits;
global using static Exomia.Vulkan.Api.Core.VkAttachmentDescriptionFlagBits;
global using static Exomia.Vulkan.Api.Core.VkAttachmentLoadOp;
global using static Exomia.Vulkan.Api.Core.VkAttachmentStoreOp;
global using static Exomia.Vulkan.Api.Core.VkDependencyFlagBits;
global using static Exomia.Vulkan.Api.Core.VkFramebufferCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkPipelineBindPoint;
global using static Exomia.Vulkan.Api.Core.VkRenderPassCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkSubpassDescriptionFlagBits;
global using static Exomia.Vulkan.Api.Core.VkCommandPoolCreateFlagBits;
global using static Exomia.Vulkan.Api.Core.VkCommandPoolResetFlagBits;
global using static Exomia.Vulkan.Api.Core.VkCommandBufferLevel;
global using static Exomia.Vulkan.Api.Core.VkCommandBufferResetFlagBits;
global using static Exomia.Vulkan.Api.Core.VkCommandBufferUsageFlagBits;
global using static Exomia.Vulkan.Api.Core.VkQueryControlFlagBits;
global using static Exomia.Vulkan.Api.Core.VkIndexType;
global using static Exomia.Vulkan.Api.Core.VkStencilFaceFlagBits;
global using static Exomia.Vulkan.Api.Core.VkSubpassContents;