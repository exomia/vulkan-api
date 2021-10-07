#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public const VkStructureType       STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkExtent2D            minFragmentShadingRateAttachmentTexelSize;
        public       VkExtent2D            maxFragmentShadingRateAttachmentTexelSize;
        public       uint                  maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
        public       VkBool32              primitiveFragmentShadingRateWithMultipleViewports;
        public       VkBool32              layeredShadingRateAttachments;
        public       VkBool32              fragmentShadingRateNonTrivialCombinerOps;
        public       VkExtent2D            maxFragmentSize;
        public       uint                  maxFragmentSizeAspectRatio;
        public       uint                  maxFragmentShadingRateCoverageSamples;
        public       VkSampleCountFlagBits maxFragmentShadingRateRasterizationSamples;
        public       VkBool32              fragmentShadingRateWithShaderDepthStencilWrites;
        public       VkBool32              fragmentShadingRateWithSampleMask;
        public       VkBool32              fragmentShadingRateWithShaderSampleMask;
        public       VkBool32              fragmentShadingRateWithConservativeRasterization;
        public       VkBool32              fragmentShadingRateWithFragmentShaderInterlock;
        public       VkBool32              fragmentShadingRateWithCustomSampleLocations;
        public       VkBool32              fragmentShadingRateStrictMultiplyCombiner;
    }
}