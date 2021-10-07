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
namespace Exomia.Vulkan.Api.Core.Extensions.AMD
{
    [VkExtGenerator]
    public static unsafe partial class VKAmdShaderInfo
    {
        public const int    VK_AMD_SHADER_INFO                = 1;
        public const int    VK_AMD_SHADER_INFO_SPEC_VERSION   = 1;
        public const string VK_AMD_SHADER_INFO_EXTENSION_NAME = "VK_AMD_shader_info";

        public static readonly delegate*<
            VkDevice,              /* device */
            VkPipeline,            /* pipeline */
            VkShaderStageFlagBits, /* shaderStage */
            VkShaderInfoTypeAMD,   /* infoType */
            nuint*,                /* pInfoSize */
            void*,                 /* pInfo */
            VkResult> vkGetShaderInfoAMD = null;

        public static partial void Load(VkDevice vkDevice);
    }

    public enum VkShaderInfoTypeAMD
    {
        STATISTICS_AMD  = 0,
        BINARY_AMD      = 1,
        DISASSEMBLY_AMD = 2,
        MAX_ENUM_AMD    = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkShaderResourceUsageAMD
    {
        public uint  numUsedVgprs;
        public uint  numUsedSgprs;
        public uint  ldsSizePerLocalWorkGroup;
        public nuint ldsUsageSizeInBytes;
        public nuint scratchMemUsageInBytes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkShaderStatisticsInfoAMD
    {
        public       VkShaderStageFlagBits    shaderStageMask;
        public       VkShaderResourceUsageAMD resourceUsage;
        public       uint                     numPhysicalVgprs;
        public       uint                     numPhysicalSgprs;
        public       uint                     numAvailableVgprs;
        public       uint                     numAvailableSgprs;
        public fixed uint                     computeWorkGroupSize[3];
    }
}