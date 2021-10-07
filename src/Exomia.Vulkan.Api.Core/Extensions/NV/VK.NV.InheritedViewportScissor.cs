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
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [VkExtGenerator]
    public static partial class VKNvInheritedViewportScissor
    {
        public const int    VK_NV_INHERITED_VIEWPORT_SCISSOR                = 1;
        public const int    VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION   = 1;
        public const string VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME = "VK_NV_inherited_viewport_scissor";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
    {
        public const VkStructureType STYPE = VkStructureType.COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        viewportScissor2D;
        public       uint            viewportDepthCount;
        public       VkViewport*     pViewportDepths;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        inheritedViewportScissor2D;
    }
}