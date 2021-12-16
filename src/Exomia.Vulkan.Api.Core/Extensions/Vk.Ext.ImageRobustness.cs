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
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkExtGenerator]
public static partial class VkExtImageRobustness
{
    public const int    VK_EXT_IMAGE_ROBUSTNESS                = 1;
    public const int    VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION   = 1;
    public const string VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME = "VK_EXT_image_robustness";
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageRobustnessFeaturesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        robustImageAccess;
}