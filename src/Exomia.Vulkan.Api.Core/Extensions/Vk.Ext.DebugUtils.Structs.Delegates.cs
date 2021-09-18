#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe struct VkSetDebugUtilsObjectNameEXT
    {
        public static readonly VkSetDebugUtilsObjectNameEXT Null = null;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                       /* device */
            VkDebugUtilsObjectNameInfoEXT*, /* pNameInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkSetDebugUtilsObjectNameEXT(void* ptr)
        {
            VkSetDebugUtilsObjectNameEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkSetDebugUtilsObjectTagEXT
    {
        public static readonly VkSetDebugUtilsObjectTagEXT Null = null;

        public readonly delegate*<
            VkDevice,                      /* device */
            VkDebugUtilsObjectTagInfoEXT*, /* pTagInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkSetDebugUtilsObjectTagEXT(void* ptr)
        {
            VkSetDebugUtilsObjectTagEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkQueueBeginDebugUtilsLabelEXT
    {
        public static readonly VkQueueBeginDebugUtilsLabelEXT Null = null;

        public readonly delegate*<
            VkQueue,               /* queue */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> UnsafeInvoke;

        public static implicit operator VkQueueBeginDebugUtilsLabelEXT(void* ptr)
        {
            VkQueueBeginDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkQueueEndDebugUtilsLabelEXT
    {
        public static readonly VkQueueEndDebugUtilsLabelEXT Null = null;

        public readonly delegate*<
            VkQueue, /* queue */
            void> UnsafeInvoke;

        public static implicit operator VkQueueEndDebugUtilsLabelEXT(void* ptr)
        {
            VkQueueEndDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkQueueInsertDebugUtilsLabelEXT
    {
        public static readonly VkQueueInsertDebugUtilsLabelEXT Null = null;

        public readonly delegate*<
            VkQueue,               /* queue */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> UnsafeInvoke;

        public static implicit operator VkQueueInsertDebugUtilsLabelEXT(void* ptr)
        {
            VkQueueInsertDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBeginDebugUtilsLabelEXT
    {
        public static readonly VkCmdBeginDebugUtilsLabelEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBeginDebugUtilsLabelEXT(void* ptr)
        {
            VkCmdBeginDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdEndDebugUtilsLabelEXT
    {
        public static readonly VkCmdEndDebugUtilsLabelEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> UnsafeInvoke;

        public static implicit operator VkCmdEndDebugUtilsLabelEXT(void* ptr)
        {
            VkCmdEndDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdInsertDebugUtilsLabelEXT
    {
        public static readonly VkCmdInsertDebugUtilsLabelEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdInsertDebugUtilsLabelEXT(void* ptr)
        {
            VkCmdInsertDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateDebugUtilsMessengerEXT
    {
        public static readonly VkCreateDebugUtilsMessengerEXT Null = null;

        public readonly delegate*<
            VkInstance,                          /* instance */
            VkDebugUtilsMessengerCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkDebugUtilsMessengerEXT*,           /* pMessenger */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateDebugUtilsMessengerEXT(void* ptr)
        {
            VkCreateDebugUtilsMessengerEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyDebugUtilsMessengerEXT
    {
        public static readonly VkDestroyDebugUtilsMessengerEXT Null = null;

        public readonly delegate*<
            VkInstance,               /* instance */
            VkDebugUtilsMessengerEXT, /* messenger */
            VkAllocationCallbacks*,   /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyDebugUtilsMessengerEXT(void* ptr)
        {
            VkDestroyDebugUtilsMessengerEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkSubmitDebugUtilsMessageEXT
    {
        public static readonly VkSubmitDebugUtilsMessageEXT Null = null;

        public readonly delegate*<
            VkInstance,                            /* instance */
            VkDebugUtilsMessageSeverityFlagsEXT,   /* messageSeverity */
            VkDebugUtilsMessageTypeFlagsEXT,       /* messageTypes */
            VkDebugUtilsMessengerCallbackDataEXT*, /* pCallbackData */
            void> UnsafeInvoke;

        public static implicit operator VkSubmitDebugUtilsMessageEXT(void* ptr)
        {
            VkSubmitDebugUtilsMessageEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }
}
