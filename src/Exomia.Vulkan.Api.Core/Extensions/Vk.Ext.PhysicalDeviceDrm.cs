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
public static partial class VkExtPhysicalDeviceDrm
{
    public const int    VK_EXT_PHYSICAL_DEVICE_DRM                = 1;
    public const int    VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION   = 1;
    public const string VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME = "VK_EXT_physical_device_drm";
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DRM_PROPERTIES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        hasPrimary;
    public       VkBool32        hasRender;
    public       long            primaryMajor;
    public       long            primaryMinor;
    public       long            renderMajor;
    public       long            renderMinor;
}