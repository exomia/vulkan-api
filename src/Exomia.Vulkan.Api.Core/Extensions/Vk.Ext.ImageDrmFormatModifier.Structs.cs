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
    public struct VkDrmFormatModifierPropertiesEXT
    {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkFormatFeatureFlagBits drmFormatModifierTilingFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDrmFormatModifierPropertiesListEXT
    {
        public const VkStructureType STYPE = VkStructureType.DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public ulong* pDrmFormatModifiers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkSubresourceLayout* pPlaneLayouts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageDrmFormatModifierPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT;
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
    }
}
