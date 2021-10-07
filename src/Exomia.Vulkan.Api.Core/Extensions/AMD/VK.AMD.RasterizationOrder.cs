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
namespace Exomia.Vulkan.Api.Core.Extensions.AMD
{
    [VkExtGenerator]
    public static unsafe partial class VkExtAcquireDrmDisplay
    {
        public const int    VK_EXT_ACQUIRE_DRM_DISPLAY                = 1;
        public const int    VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION   = 1;
        public const string VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME = "VK_AMD_rasterization_order";

        public static partial void Load(VkInstance vkInstance);
    }

    public enum VkRasterizationOrderAMD
    {
        STRICT_AMD   = 0,
        RELAXED_AMD  = 1,
        MAX_ENUM_AMD = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
    {
        public const VkStructureType         STYPE = VkStructureType.PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD;
        public       VkStructureType         sType;
        public       void*                   pNext;
        public       VkRasterizationOrderAMD rasterizationOrder;
    }
}