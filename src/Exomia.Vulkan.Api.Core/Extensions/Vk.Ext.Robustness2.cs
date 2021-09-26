#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtRobustness2
    {
        public const int    VK_EXT_ROBUSTNESS2                 = 1;
        public const int    VK_EXT_ROBUSTNESS_2_SPEC_VERSION   = 1;
        public const string VK_EXT_ROBUSTNESS_2_EXTENSION_NAME = "VK_EXT_robustness2";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        robustBufferAccess2;
        public       VkBool32        robustImageAccess2;
        public       VkBool32        nullDescriptor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkDeviceSize    robustStorageBufferAccessSizeAlignment;
        public       VkDeviceSize    robustUniformBufferAccessSizeAlignment;
    }
}
