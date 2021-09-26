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
    public static unsafe partial class VkExtColorWriteEnable
    {
        public const int    VK_EXT_COLOR_WRITE_ENABLE                = 1;
        public const int    VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION   = 1;
        public const string VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME = "VK_EXT_color_write_enable";

        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* attachmentCount */
            VkBool32*,       /* pColorWriteEnables */
            void> vkCmdSetColorWriteEnableEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        colorWriteEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineColorWriteCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.PIPELINE_COLOR_WRITE_CREATE_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            attachmentCount;
        public       VkBool32*       pColorWriteEnables;
    }
}