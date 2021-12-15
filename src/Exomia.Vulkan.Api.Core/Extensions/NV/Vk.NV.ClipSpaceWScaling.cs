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
    public static unsafe partial class VkNvClipSpaceWScaling
    {
        public const int    VK_NV_CLIP_SPACE_W_SCALING                = 1;
        public const int    VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION   = 1;
        public const string VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME = "VK_NV_clip_space_w_scaling";

        public static readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            uint,                  /* firstViewport */
            uint,                  /* viewportCount */
            VkViewportWScalingNV*, /* pViewportWScalings */
            void> vkCmdSetViewportWScalingNV = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewportWScalingNV
    {
        public float xcoeff;
        public float ycoeff;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
    {
        public const VkStructureType       STYPE = VkStructureType.PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkBool32              viewportWScalingEnable;
        public       uint                  viewportCount;
        public       VkViewportWScalingNV* pViewportWScalings;
    }
}