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
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtPipelineCreationCacheControl
    {
        public const int    VK_EXT_PIPELINE_CREATION_CACHE_CONTROL                = 1;
        public const int    VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION   = 3;
        public const string VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME = "VK_EXT_pipeline_creation_cache_control";
    }

    [Flags]
    public enum VkPipelineCacheCreateFlagBits
    {
        EXTERNALLY_SYNCHRONIZED_BIT_EXT = 0x00000001,
        FLAG_BITS_MAX_ENUM              = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        pipelineCreationCacheControl;
    }
}
