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
    public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        fragmentDensityMap;
        public       VkBool32        fragmentDensityMapDynamic;
        public       VkBool32        fragmentDensityMapNonSubsampledImages;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkExtent2D      minFragmentDensityTexelSize;
        public       VkExtent2D      maxFragmentDensityTexelSize;
        public       VkBool32        fragmentDensityInvocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
    {
        public const VkStructureType       STYPE = VkStructureType.RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkAttachmentReference fragmentDensityMapAttachment;
    }
}
