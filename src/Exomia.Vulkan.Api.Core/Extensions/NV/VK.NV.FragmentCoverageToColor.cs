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
    public static unsafe partial class VKNvFragmentCoverageToColor
    {
        public const int    VK_NV_FRAGMENT_COVERAGE_TO_COLOR                = 1;
        public const int    VK_NV_FRAGMENT_COVERAGE_TO_COLOR_SPEC_VERSION   = 1;
        public const string VK_NV_FRAGMENT_COVERAGE_TO_COLOR_EXTENSION_NAME = "VK_NV_fragment_coverage_to_color";
        
        

        public static partial void Load(VkInstance vkInstance);
    }



    [Flags]
    public enum VkPipelineCoverageToColorStateCreateFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }



    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
    {
        public const VkStructureType                             STYPE = VkStructureType.PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV;
        public       VkStructureType                             sType;
        public       void*                                       pNext;
        public       VkPipelineCoverageToColorStateCreateFlagsNV flags;
        public       VkBool32                                    coverageToColorEnable;
        public       uint                                        coverageToColorLocation;
    }




}