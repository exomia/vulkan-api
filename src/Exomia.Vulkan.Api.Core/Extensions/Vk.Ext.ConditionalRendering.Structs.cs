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
    public unsafe struct VkConditionalRenderingBeginInfoEXT
    {
        public const VkStructureType                STYPE = VkStructureType.CONDITIONAL_RENDERING_BEGIN_INFO_EXT;
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkBuffer                       buffer;
        public       VkDeviceSize                   offset;
        public       VkConditionalRenderingFlagsEXT flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        conditionalRendering;
        public       VkBool32        inheritedConditionalRendering;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        conditionalRenderingEnable;
    }
}
