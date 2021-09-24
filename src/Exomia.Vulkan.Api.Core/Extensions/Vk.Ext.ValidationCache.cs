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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtValidationCache
    {
        public const int    VK_EXT_VALIDATION_CACHE                = 1;
        public const int    VK_EXT_VALIDATION_CACHE_SPEC_VERSION   = 1;
        public const string VK_EXT_VALIDATION_CACHE_EXTENSION_NAME = "VK_EXT_validation_cache";

        public static delegate*<
            VkDevice,                        /* device */
            VkValidationCacheCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkValidationCacheEXT*,           /* pValidationCache */
            VkResult> vkCreateValidationCacheEXT;

        public static delegate*<
            VkDevice,               /* device */
            VkValidationCacheEXT,   /* validationCache */
            VkAllocationCallbacks*, /* pAllocator */
            void> vkDestroyValidationCacheEXT;

        public static delegate*<
            VkDevice,              /* device */
            VkValidationCacheEXT,  /* dstCache */
            uint,                  /* srcCacheCount */
            VkValidationCacheEXT*, /* pSrcCaches */
            VkResult> vkMergeValidationCachesEXT;

        public static delegate*<
            VkDevice,             /* device */
            VkValidationCacheEXT, /* validationCache */
            nuint*,               /* pDataSize */
            void*,                /* pData */
            VkResult> vkGetValidationCacheDataEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    public enum VkValidationCacheHeaderVersionEXT
    {
        ONE_EXT      = 1,
        MAX_ENUM_EXT = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkValidationCacheCreateInfoEXT
    {
        public const VkStructureType                 STYPE = VkStructureType.VALIDATION_CACHE_CREATE_INFO_EXT;
        public       VkStructureType                 sType;
        public       void*                           pNext;
        public       VkValidationCacheCreateFlagsEXT flags;
        public       nuint                           initialDataSize;
        public       void*                           pInitialData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
    {
        public const VkStructureType      STYPE = VkStructureType.SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT;
        public       VkStructureType      sType;
        public       void*                pNext;
        public       VkValidationCacheEXT validationCache;
    }

    public readonly unsafe struct VkValidationCacheEXT
    {
        public static readonly VkValidationCacheEXT Null = (VkValidationCacheEXT)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkValidationCacheEXT(void* ptr)
        {
            VkValidationCacheEXT value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkValidationCacheEXT left, VkValidationCacheEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkValidationCacheEXT left, VkValidationCacheEXT right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkValidationCacheEXT obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkValidationCacheEXT vkValidationCacheEXT && Equals(in vkValidationCacheEXT);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkValidationCacheEXT value)
        {
            return value._ptr;
        }
    }
}