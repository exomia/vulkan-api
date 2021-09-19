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
     public readonly unsafe struct VkCreateDebugReportCallbackEXT
    {
        public static readonly VkCreateDebugReportCallbackEXT Null = null;

        public readonly delegate*<
            VkInstance,                          /* instance */
            VkDebugReportCallbackCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkDebugReportCallbackEXT*,           /* pCallback */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateDebugReportCallbackEXT(void* ptr)
        {
            VkCreateDebugReportCallbackEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyDebugReportCallbackEXT
    {
        public static readonly VkDestroyDebugReportCallbackEXT Null = null;

        public readonly delegate*<
            VkInstance,               /* instance */
            VkDebugReportCallbackEXT, /* callback */
            VkAllocationCallbacks*,   /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyDebugReportCallbackEXT(void* ptr)
        {
            VkDestroyDebugReportCallbackEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDebugReportMessageEXT
    {
        public static readonly VkDebugReportMessageEXT Null = null;

        public readonly delegate*<
            VkInstance,                 /* instance */
            VkDebugReportFlagsEXT,      /* FlagBits */
            VkDebugReportObjectTypeEXT, /* objectType */
            ulong,                      /* @object */
            nuint,                      /* location */
            int,                        /* messageCode */
            byte*,                      /* pLayerPrefix */
            byte*,                      /* pMessage */
            void> UnsafeInvoke;

        public static implicit operator VkDebugReportMessageEXT(void* ptr)
        {
            VkDebugReportMessageEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }
}
