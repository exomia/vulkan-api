#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        advancedBlendCoherentOperations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            advancedBlendMaxColorAttachments;
        public       VkBool32        advancedBlendIndependentBlend;
        public       VkBool32        advancedBlendNonPremultipliedSrcColor;
        public       VkBool32        advancedBlendNonPremultipliedDstColor;
        public       VkBool32        advancedBlendCorrelatedOverlap;
        public       VkBool32        advancedBlendAllOperations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public const VkStructureType   STYPE = VkStructureType.PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT;
        public       VkStructureType   sType;
        public       void*             pNext;
        public       VkBool32          srcPremultiplied;
        public       VkBool32          dstPremultiplied;
        public       VkBlendOverlapEXT blendOverlap;
    }
}
