#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace Exomia.Vulkan.Api.Core.Extensions
{
    public readonly unsafe struct VkCreateValidationCacheEXT
    {
        public static readonly VkCreateValidationCacheEXT Null = null;

        public readonly delegate*<
            VkDevice,                        /* device */
            VkValidationCacheCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkValidationCacheEXT*,           /* pValidationCache */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateValidationCacheEXT(void* ptr)
        {
            VkCreateValidationCacheEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyValidationCacheEXT
    {
        public static readonly VkDestroyValidationCacheEXT Null = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkValidationCacheEXT,   /* validationCache */
            VkAllocationCallbacks*, /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyValidationCacheEXT(void* ptr)
        {
            VkDestroyValidationCacheEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkMergeValidationCachesEXT
    {
        public static readonly VkMergeValidationCachesEXT Null = null;

        public readonly delegate*<
            VkDevice,              /* device */
            VkValidationCacheEXT,  /* dstCache */
            uint,                  /* srcCacheCount */
            VkValidationCacheEXT*, /* pSrcCaches */
            VkResult> UnsafeInvoke;

        public static implicit operator VkMergeValidationCachesEXT(void* ptr)
        {
            VkMergeValidationCachesEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetValidationCacheDataEXT
    {
        public static readonly VkGetValidationCacheDataEXT Null = null;

        public readonly delegate*<
            VkDevice,             /* device */
            VkValidationCacheEXT, /* validationCache */
            nuint*,               /* pDataSize */
            void*,                /* pData */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetValidationCacheDataEXT(void* ptr)
        {
            VkGetValidationCacheDataEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

}
