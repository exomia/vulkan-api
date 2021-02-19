#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;

// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core
{
    [Flags]
    public enum VkMemoryMapFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkDescriptorPoolResetFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkCommandPoolTrimFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkInstanceCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkDeviceCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkSemaphoreCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkQueryPoolCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkBufferViewCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineVertexInputStateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineInputAssemblyStateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineTessellationStateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineViewportStateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineRasterizationStateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineMultisampleStateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineDepthStencilStateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineColorBlendStateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineDynamicStateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineLayoutCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkDescriptorUpdateTemplateCreateFlags : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkDisplayModeCreateFlagsKHR : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkDisplaySurfaceCreateFlagsKHR : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineRasterizationStateStreamCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineViewportSwizzleStateCreateFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineDiscardRectangleStateCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineRasterizationConservativeStateCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineRasterizationDepthClipStateCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkDebugUtilsMessengerCallbackDataFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkDebugUtilsMessengerCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineCoverageToColorStateCreateFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineCoverageModulationStateCreateFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkValidationCacheCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkBuildAccelerationStructureFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkPipelineCoverageReductionStateCreateFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkHeadlessSurfaceCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [Flags]
    public enum VkDeviceMemoryReportFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }
}