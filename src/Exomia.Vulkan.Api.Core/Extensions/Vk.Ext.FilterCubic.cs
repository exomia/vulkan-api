#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkExtGenerator]
public static partial class VkExtFilterCubic
{
    public const int    VK_EXT_FILTER_CUBIC                = 1;
    public const int    VK_EXT_FILTER_CUBIC_SPEC_VERSION   = 3;
    public const string VK_EXT_FILTER_CUBIC_EXTENSION_NAME = "VK_EXT_filter_cubic";
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkImageViewType imageViewType;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
    public const VkStructureType STYPE = VkStructureType.FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        filterCubic;
    public       VkBool32        filterCubicMinmax;
}