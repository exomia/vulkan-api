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
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        subgroupSizeControl;
        public       VkBool32        computeFullSubgroups;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
    {
        public const VkStructureType       STYPE = VkStructureType.PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       uint                  minSubgroupSize;
        public       uint                  maxSubgroupSize;
        public       uint                  maxComputeWorkgroupSubgroups;
        public       VkShaderStageFlagBits requiredSubgroupSizeStages;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            requiredSubgroupSize;
    }
}
