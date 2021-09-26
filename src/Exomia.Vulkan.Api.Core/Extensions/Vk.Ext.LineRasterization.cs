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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtLineRasterization
    {
        public const int    VK_EXT_LINE_RASTERIZATION                = 1;
        public const int    VK_EXT_LINE_RASTERIZATION_SPEC_VERSION   = 1;
        public const string VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME = "VK_EXT_line_rasterization";

        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* lineStippleFactor */
            ushort,          /* lineStipplePattern */
            void> vkCmdSetLineStippleEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    public enum VkLineRasterizationModeEXT
    {
        DEFAULT_EXT            = 0,
        RECTANGULAR_EXT        = 1,
        BRESENHAM_EXT          = 2,
        RECTANGULAR_SMOOTH_EXT = 3,
        MAX_ENUM_EXT           = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        rectangularLines;
        public       VkBool32        bresenhamLines;
        public       VkBool32        smoothLines;
        public       VkBool32        stippledRectangularLines;
        public       VkBool32        stippledBresenhamLines;
        public       VkBool32        stippledSmoothLines;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            lineSubPixelPrecisionBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
    {
        public const VkStructureType            STYPE = VkStructureType.PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkLineRasterizationModeEXT lineRasterizationMode;
        public       VkBool32                   stippledLineEnable;
        public       uint                       lineStippleFactor;
        public       ushort                     lineStipplePattern;
    }
}