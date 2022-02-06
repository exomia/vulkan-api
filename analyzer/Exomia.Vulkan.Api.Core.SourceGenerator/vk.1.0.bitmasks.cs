﻿#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using VkFormatFeatureFlags = Exomia.Vulkan.Api.Core.VkFormatFeatureFlagBits;
global using VkImageCreateFlags = Exomia.Vulkan.Api.Core.VkImageCreateFlagBits;
global using VkImageUsageFlags = Exomia.Vulkan.Api.Core.VkImageUsageFlagBits;
global using VkInstanceCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkMemoryHeapFlags = Exomia.Vulkan.Api.Core.VkMemoryHeapFlagBits;
global using VkMemoryPropertyFlags = Exomia.Vulkan.Api.Core.VkMemoryPropertyFlagBits;
global using VkQueueFlags = Exomia.Vulkan.Api.Core.VkQueueFlagBits;
global using VkSampleCountFlags = Exomia.Vulkan.Api.Core.VkSampleCountFlagBits;
global using VkDeviceCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkDeviceQueueCreateFlags = Exomia.Vulkan.Api.Core.VkDeviceQueueCreateFlagBits;
global using VkPipelineStageFlags = Exomia.Vulkan.Api.Core.VkPipelineStageFlagBits;
global using VkMemoryMapFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkImageAspectFlags = Exomia.Vulkan.Api.Core.VkImageAspectFlagBits;
global using VkSparseImageFormatFlags = Exomia.Vulkan.Api.Core.VkSparseImageFormatFlagBits;
global using VkSparseMemoryBindFlags = Exomia.Vulkan.Api.Core.VkSparseMemoryBindFlagBits;
global using VkFenceCreateFlags = Exomia.Vulkan.Api.Core.VkFenceCreateFlagBits;
global using VkSemaphoreCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkEventCreateFlags = Exomia.Vulkan.Api.Core.VkEventCreateFlagBits;
global using VkQueryPipelineStatisticFlags = Exomia.Vulkan.Api.Core.VkQueryPipelineStatisticFlagBits;
global using VkQueryPoolCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkQueryResultFlags = Exomia.Vulkan.Api.Core.VkQueryResultFlagBits;
global using VkBufferCreateFlags = Exomia.Vulkan.Api.Core.VkBufferCreateFlagBits;
global using VkBufferUsageFlags = Exomia.Vulkan.Api.Core.VkBufferUsageFlagBits;
global using VkBufferViewCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkImageViewCreateFlags = Exomia.Vulkan.Api.Core.VkImageViewCreateFlagBits;
global using VkShaderModuleCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkPipelineCacheCreateFlags = Exomia.Vulkan.Api.Core.VkPipelineCacheCreateFlagBits;
global using VkColorComponentFlags = Exomia.Vulkan.Api.Core.VkColorComponentFlagBits;
global using VkCullModeFlags = Exomia.Vulkan.Api.Core.VkCullModeFlagBits;
global using VkPipelineColorBlendStateCreateFlags = Exomia.Vulkan.Api.Core.VkPipelineColorBlendStateCreateFlagBits;
global using VkPipelineCreateFlags = Exomia.Vulkan.Api.Core.VkPipelineCreateFlagBits;
global using VkPipelineDepthStencilStateCreateFlags = Exomia.Vulkan.Api.Core.VkPipelineDepthStencilStateCreateFlagBits;
global using VkPipelineDynamicStateCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkPipelineInputAssemblyStateCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkPipelineLayoutCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkPipelineMultisampleStateCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkPipelineRasterizationStateCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkPipelineShaderStageCreateFlags = Exomia.Vulkan.Api.Core.VkPipelineShaderStageCreateFlagBits;
global using VkPipelineTessellationStateCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkPipelineVertexInputStateCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkPipelineViewportStateCreateFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkShaderStageFlags = Exomia.Vulkan.Api.Core.VkShaderStageFlagBits;
global using VkSamplerCreateFlags = Exomia.Vulkan.Api.Core.VkSamplerCreateFlagBits;
global using VkDescriptorPoolCreateFlags = Exomia.Vulkan.Api.Core.VkDescriptorPoolCreateFlagBits;
global using VkDescriptorPoolResetFlags = Exomia.Vulkan.Api.Core.FutureUse32;
global using VkDescriptorSetLayoutCreateFlags = Exomia.Vulkan.Api.Core.VkDescriptorSetLayoutCreateFlagBits;
global using VkAccessFlags = Exomia.Vulkan.Api.Core.VkAccessFlagBits;
global using VkAttachmentDescriptionFlags = Exomia.Vulkan.Api.Core.VkAttachmentDescriptionFlagBits;
global using VkDependencyFlags = Exomia.Vulkan.Api.Core.VkDependencyFlagBits;
global using VkFramebufferCreateFlags = Exomia.Vulkan.Api.Core.VkFramebufferCreateFlagBits;
global using VkRenderPassCreateFlags = Exomia.Vulkan.Api.Core.VkRenderPassCreateFlagBits;
global using VkSubpassDescriptionFlags = Exomia.Vulkan.Api.Core.VkSubpassDescriptionFlagBits;
global using VkCommandPoolCreateFlags = Exomia.Vulkan.Api.Core.VkCommandPoolCreateFlagBits;
global using VkCommandPoolResetFlags = Exomia.Vulkan.Api.Core.VkCommandPoolResetFlagBits;
global using VkCommandBufferResetFlags = Exomia.Vulkan.Api.Core.VkCommandBufferResetFlagBits;
global using VkCommandBufferUsageFlags = Exomia.Vulkan.Api.Core.VkCommandBufferUsageFlagBits;
global using VkQueryControlFlags = Exomia.Vulkan.Api.Core.VkQueryControlFlagBits;
global using VkStencilFaceFlags = Exomia.Vulkan.Api.Core.VkStencilFaceFlagBits;