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
    public static unsafe partial class VKNvShadingRateImage
    {
        public const int    VK_NV_SHADING_RATE_IMAGE                = 1;
        public const int    VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION   = 3;
        public const string VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME = "VK_NV_shading_rate_image";
        
        public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    VkImageView, /* imageView */
    VkImageLayout, /* imageLayout */
    void> vkCmdBindShadingRateImageNV = null;

public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    VkCoarseSampleOrderTypeNV, /* sampleOrderType */
    uint, /* customSampleOrderCount */
    VkCoarseSampleOrderCustomNV*, /* pCustomSampleOrders */
    void> vkCmdSetCoarseSampleOrderNV = null;

public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    uint, /* firstViewport */
    uint, /* viewportCount */
    VkShadingRatePaletteNV*, /* pShadingRatePalettes */
    void> vkCmdSetViewportShadingRatePaletteNV = null;



        public static partial void Load(VkInstance vkInstance);
    }


    public enum VkCoarseSampleOrderTypeNV
    {
        DEFAULT_NV      = 0,
        CUSTOM_NV       = 1,
        PIXEL_MAJOR_NV  = 2,
        SAMPLE_MAJOR_NV = 3,
        MAX_ENUM_NV     = 0x7FFFFFFF
    }


    public enum VkShadingRatePaletteEntryNV
    {
        NO_INVOCATIONS_NV               = 0,
        _16_INVOCATIONS_PER_PIXEL_NV    = 1,
        _8_INVOCATIONS_PER_PIXEL_NV     = 2,
        _4_INVOCATIONS_PER_PIXEL_NV     = 3,
        _2_INVOCATIONS_PER_PIXEL_NV     = 4,
        _1_INVOCATION_PER_PIXEL_NV      = 5,
        _1_INVOCATION_PER_2X1_PIXELS_NV = 6,
        _1_INVOCATION_PER_1X2_PIXELS_NV = 7,
        _1_INVOCATION_PER_2X2_PIXELS_NV = 8,
        _1_INVOCATION_PER_4X2_PIXELS_NV = 9,
        _1_INVOCATION_PER_2X4_PIXELS_NV = 10,
        _1_INVOCATION_PER_4X4_PIXELS_NV = 11,
        MAX_ENUM_NV                     = 0x7FFFFFFF
    }




    [StructLayout(LayoutKind.Sequential)]
    public struct VkCoarseSampleLocationNV
    {
        public uint pixelX;
        public uint pixelY;
        public uint sample;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCoarseSampleOrderCustomNV
    {
        public VkShadingRatePaletteEntryNV shadingRate;
        public uint                        sampleCount;
        public uint                        sampleLocationCount;
        public VkCoarseSampleLocationNV*   pSampleLocations;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkShadingRatePaletteNV
    {
        public uint                         shadingRatePaletteEntryCount;
        public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        shadingRateImage;
        public       VkBool32        shadingRateCoarseSampleOrder;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkExtent2D      shadingRateTexelSize;
        public       uint            shadingRatePaletteSize;
        public       uint            shadingRateMaxCoarseSamples;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
    {
        public const VkStructureType              STYPE = VkStructureType.PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV;
        public       VkStructureType              sType;
        public       void*                        pNext;
        public       VkCoarseSampleOrderTypeNV    sampleOrderType;
        public       uint                         customSampleOrderCount;
        public       VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
    {
        public const VkStructureType         STYPE = VkStructureType.PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV;
        public       VkStructureType         sType;
        public       void*                   pNext;
        public       VkBool32                shadingRateImageEnable;
        public       uint                    viewportCount;
        public       VkShadingRatePaletteNV* pShadingRatePalettes;
    }




}