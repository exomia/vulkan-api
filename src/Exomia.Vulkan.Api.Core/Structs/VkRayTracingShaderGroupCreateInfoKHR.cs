﻿#region License

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
    public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
    {
        public const VkStructureType                STYPE = VkStructureType.RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR;
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkRayTracingShaderGroupTypeKHR type;
        public       uint                           generalShader;
        public       uint                           closestHitShader;
        public       uint                           anyHitShader;
        public       uint                           intersectionShader;
        public       void*                          pShaderGroupCaptureReplayHandle;
    }
}