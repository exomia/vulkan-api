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
namespace Exomia.Vulkan.Api.Core.Extensions.QCOM
{
    [VkExtGenerator]
    public static partial class VkQcomRenderPassTransform
    {
        public const int    VK_QCOM_RENDER_PASS_TRANSFORM                = 1;
        public const int    VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION   = 2;
        public const string VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME = "VK_QCOM_render_pass_transform";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassTransformBeginInfoQCOM
    {
        public const VkStructureType            STYPE = VkStructureType.RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkSurfaceTransformFlagsKHR transform;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
    {
        public const VkStructureType            STYPE = VkStructureType.COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkSurfaceTransformFlagsKHR transform;
        public       VkRect2D                   renderArea;
    }
}