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
        public const string VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME = "VK_AMD_pipeline_compiler_control";

        public static partial void Load(VkInstance vkInstance);
    }

    [Flags]
    public enum VkPipelineCompilerControlFlagsAMD
    {
        MAX_ENUM_AMD = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPipelineCompilerControlFlagsAMD
    {
        MAX_ENUM_AMD = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCompilerControlCreateInfoAMD
    {
        public const VkStructureType                   STYPE = VkStructureType.PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD;
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       VkPipelineCompilerControlFlagsAMD compilerControlFlags;
    }
}