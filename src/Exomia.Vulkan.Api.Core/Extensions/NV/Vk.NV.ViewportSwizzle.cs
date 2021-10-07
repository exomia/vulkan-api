#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [VkExtGenerator]
    public static partial class VKNvViewportSwizzle
    {
        public const int    VK_NV_VIEWPORT_SWIZZLE                = 1;
        public const int    VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION   = 1;
        public const string VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME = "VK_NV_viewport_swizzle";
    }

    public enum VkViewportCoordinateSwizzleNV
    {
        POSITIVE_X_NV = 0,
        NEGATIVE_X_NV = 1,
        POSITIVE_Y_NV = 2,
        NEGATIVE_Y_NV = 3,
        POSITIVE_Z_NV = 4,
        NEGATIVE_Z_NV = 5,
        POSITIVE_W_NV = 6,
        NEGATIVE_W_NV = 7,
        MAX_ENUM_NV   = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPipelineViewportSwizzleStateCreateFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewportSwizzleNV
    {
        public VkViewportCoordinateSwizzleNV x;
        public VkViewportCoordinateSwizzleNV y;
        public VkViewportCoordinateSwizzleNV z;
        public VkViewportCoordinateSwizzleNV w;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
    {
        public const VkStructureType                             STYPE = VkStructureType.PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV;
        public       VkStructureType                             sType;
        public       void*                                       pNext;
        public       VkPipelineViewportSwizzleStateCreateFlagsNV flags;
        public       uint                                        viewportCount;
        public       VkViewportSwizzleNV*                        pViewportSwizzles;
    }
}