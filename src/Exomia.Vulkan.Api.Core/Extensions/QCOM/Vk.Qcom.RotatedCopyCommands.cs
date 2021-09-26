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
    public static partial class VkQcomRotatedCopyCommands
    {
        public const int    VK_QCOM_ROTATED_COPY_COMMANDS                = 1;
        public const int    VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION   = 1;
        public const string VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME = "VK_QCOM_rotated_copy_commands";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyCommandTransformInfoQCOM
    {
        public const VkStructureType            STYPE = VkStructureType.COPY_COMMAND_TRANSFORM_INFO_QCOM;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkSurfaceTransformFlagsKHR transform;
    }
}
