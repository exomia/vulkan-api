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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtHeadlessSurface
    {
        public const int    VK_EXT_HEADLESS_SURFACE                = 1;
        public const int    VK_EXT_HEADLESS_SURFACE_SPEC_VERSION   = 1;
        public const string VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME = "VK_EXT_headless_surface";
        
        public static delegate*<
            VkInstance,                      /* instance */
            VkHeadlessSurfaceCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkSurfaceKHR*,                   /* pSurface */
            VkResult> vkCreateHeadlessSurfaceEXT;

        public static partial void Load(VkInstance vkInstance);
    }

    [Flags]
    public enum VkHeadlessSurfaceCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkHeadlessSurfaceCreateInfoEXT
    {
        public const VkStructureType                 STYPE = VkStructureType.HEADLESS_SURFACE_CREATE_INFO_EXT;
        public       VkStructureType                 sType;
        public       void*                           pNext;
        public       VkHeadlessSurfaceCreateFlagsEXT flags;
    }
}
