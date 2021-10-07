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
    public static unsafe partial class VkNvScissorExclusive
    {
        public const int    VK_NV_SCISSOR_EXCLUSIVE                = 1;
        public const int    VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION   = 1;
        public const string VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME = "VK_NV_scissor_exclusive";

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstExclusiveScissor */
            uint,            /* exclusiveScissorCount */
            VkRect2D*,       /* pExclusiveScissors */
            void> vkCmdSetExclusiveScissorNV = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        exclusiveScissor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
    {
        public const VkStructureType STYPE = VkStructureType.PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            exclusiveScissorCount;
        public       VkRect2D*       pExclusiveScissors;
    }
}