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
    public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        rayTracingPipeline;
        public       VkBool32        rayTracingPipelineShaderGroupHandleCaptureReplay;
        public       VkBool32        rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
        public       VkBool32        rayTracingPipelineTraceRaysIndirect;
        public       VkBool32        rayTraversalPrimitiveCulling;
    }
}