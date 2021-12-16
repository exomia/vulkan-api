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
public static partial class VkExtCustomBorderColor
{
    public const int    VK_EXT_CUSTOM_BORDER_COLOR                = 1;
    public const int    VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION   = 12;
    public const string VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME = "VK_EXT_custom_border_color";
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
{
    public const VkStructureType   STYPE = VkStructureType.SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT;
    public       VkStructureType   sType;
    public       void*             pNext;
    public       VkClearColorValue customBorderColor;
    public       VkFormat          format;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       uint            maxCustomBorderColorSamplers;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        customBorderColors;
    public       VkBool32        customBorderColorWithoutFormat;
}