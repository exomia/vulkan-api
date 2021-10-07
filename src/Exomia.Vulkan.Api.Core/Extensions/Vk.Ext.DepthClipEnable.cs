#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtDepthClipEnable
    {
        public const int    VK_EXT_DEPTH_CLIP_ENABLE                = 1;
        public const int    VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION   = 1;
        public const string VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME = "VK_EXT_depth_clip_enable";
    }

    [Flags]
    public enum VkPipelineRasterizationDepthClipStateCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        depthClipEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public const VkStructureType                                     STYPE = VkStructureType.PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT;
        public       VkStructureType                                     sType;
        public       void*                                               pNext;
        public       VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
        public       VkBool32                                            depthClipEnable;
    }
}