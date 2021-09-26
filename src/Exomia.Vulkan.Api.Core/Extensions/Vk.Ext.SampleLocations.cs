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
    public static unsafe partial class VkExtSampleLocations
    {
        public const int    VK_EXT_SAMPLE_LOCATIONS                = 1;
        public const int    VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION   = 1;
        public const string VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME = "VK_EXT_sample_locations";

        public static readonly delegate*<
            VkCommandBuffer,           /* commandBuffer */
            VkSampleLocationsInfoEXT*, /* pSampleLocationsInfo */
            void> vkCmdSetSampleLocationsEXT = null;

        public static readonly delegate*<
            VkPhysicalDevice,            /* physicalDevice */
            VkSampleCountFlagBits,       /* samples */
            VkMultisamplePropertiesEXT*, /* pMultisampleProperties */
            void> vkGetPhysicalDeviceMultisamplePropertiesEXT = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSampleLocationEXT
    {
        public float x;
        public float y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSampleLocationsInfoEXT
    {
        public const VkStructureType       STYPE = VkStructureType.SAMPLE_LOCATIONS_INFO_EXT;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkSampleCountFlagBits sampleLocationsPerPixel;
        public       VkExtent2D            sampleLocationGridSize;
        public       uint                  sampleLocationsCount;
        public       VkSampleLocationEXT*  pSampleLocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentSampleLocationsEXT
    {
        public uint                     attachmentIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassSampleLocationsEXT
    {
        public uint                     subpassIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
    {
        public const VkStructureType                 STYPE = VkStructureType.RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT;
        public       VkStructureType                 sType;
        public       void*                           pNext;
        public       uint                            attachmentInitialSampleLocationsCount;
        public       VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
        public       uint                            postSubpassSampleLocationsCount;
        public       VkSubpassSampleLocationsEXT*    pPostSubpassSampleLocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
    {
        public const VkStructureType          STYPE = VkStructureType.PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT;
        public       VkStructureType          sType;
        public       void*                    pNext;
        public       VkBool32                 sampleLocationsEnable;
        public       VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
    {
        public const VkStructureType       STYPE = VkStructureType.PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkSampleCountFlagBits sampleLocationSampleCounts;
        public       VkExtent2D            maxSampleLocationGridSize;
        public fixed float                 sampleLocationCoordinateRange[2];
        public       uint                  sampleLocationSubPixelBits;
        public       VkBool32              variableSampleLocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMultisamplePropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.MULTISAMPLE_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkExtent2D      maxSampleLocationGridSize;
    }
}