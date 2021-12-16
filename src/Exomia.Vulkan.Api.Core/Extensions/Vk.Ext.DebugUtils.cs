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
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkRequires(Vk.REQUIRES_VULKAN_10)]
[VkExtGenerator]
public static unsafe partial class VkExtDebugUtils
{
    public const int    VK_EXT_DEBUG_UTILS                = 1;
    public const int    VK_EXT_DEBUG_UTILS_SPEC_VERSION   = 2;
    public const string VK_EXT_DEBUG_UTILS_EXTENSION_NAME = "VK_EXT_debug_utils";

    public static readonly delegate*<
        VkDevice,                       /* device */
        VkDebugUtilsObjectNameInfoEXT*, /* pNameInfo */
        VkResult> vkSetDebugUtilsObjectNameEXT = null;

    public static readonly delegate*<
        VkDevice,                      /* device */
        VkDebugUtilsObjectTagInfoEXT*, /* pTagInfo */
        VkResult> vkSetDebugUtilsObjectTagEXT = null;

    public static readonly delegate*<
        VkQueue,               /* queue */
        VkDebugUtilsLabelEXT*, /* pLabelInfo */
        void> vkQueueBeginDebugUtilsLabelEXT = null;

    public static readonly delegate*<
        VkQueue, /* queue */
        void> vkQueueEndDebugUtilsLabelEXT = null;

    public static readonly delegate*<
        VkQueue,               /* queue */
        VkDebugUtilsLabelEXT*, /* pLabelInfo */
        void> vkQueueInsertDebugUtilsLabelEXT = null;

    public static readonly delegate*<
        VkCommandBuffer,       /* commandBuffer */
        VkDebugUtilsLabelEXT*, /* pLabelInfo */
        void> vkCmdBeginDebugUtilsLabelEXT = null;

    public static readonly delegate*<
        VkCommandBuffer, /* commandBuffer */
        void> vkCmdEndDebugUtilsLabelEXT = null;

    public static readonly delegate*<
        VkCommandBuffer,       /* commandBuffer */
        VkDebugUtilsLabelEXT*, /* pLabelInfo */
        void> vkCmdInsertDebugUtilsLabelEXT = null;

    public static readonly delegate*<
        VkInstance,                          /* instance */
        VkDebugUtilsMessengerCreateInfoEXT*, /* pCreateInfo */
        VkAllocationCallbacks*,              /* pAllocator */
        VkDebugUtilsMessengerEXT*,           /* pMessenger */
        VkResult> vkCreateDebugUtilsMessengerEXT = null;

    public static readonly delegate*<
        VkInstance,               /* instance */
        VkDebugUtilsMessengerEXT, /* messenger */
        VkAllocationCallbacks*,   /* pAllocator */
        void> vkDestroyDebugUtilsMessengerEXT = null;

    public static readonly delegate*<
        VkInstance,                            /* instance */
        VkDebugUtilsMessageSeverityFlagsEXT,   /* messageSeverity */
        VkDebugUtilsMessageTypeFlagsEXT,       /* messageTypes */
        VkDebugUtilsMessengerCallbackDataEXT*, /* pCallbackData */
        void> vkSubmitDebugUtilsMessageEXT = null;

    public static partial void Load(VkInstance vkInstance);
}

[Flags]
public enum VkDebugUtilsMessageSeverityFlagsEXT
{
    VERBOSE_BIT_EXT        = 0x00000001,
    INFO_BIT_EXT           = 0x00000010,
    WARNING_BIT_EXT        = 0x00000100,
    ERROR_BIT_EXT          = 0x00001000,
    FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
}

[Flags]
public enum VkDebugUtilsMessageTypeFlagsEXT
{
    GENERAL_BIT_EXT        = 0x00000001,
    VALIDATION_BIT_EXT     = 0x00000002,
    PERFORMANCE_BIT_EXT    = 0x00000004,
    FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF
}

[Flags]
public enum VkDebugUtilsMessengerCallbackDataFlagsEXT : uint
{
    /// <summary>
    ///     Reserved for future use
    /// </summary>
    Reserved = 0
}

[Flags]
public enum VkDebugUtilsMessengerCreateFlagsEXT : uint
{
    /// <summary>
    ///     Reserved for future use
    /// </summary>
    Reserved = 0
}

public readonly unsafe struct VkDebugUtilsMessengerEXT
{
    public static readonly VkDebugUtilsMessengerEXT Null = (VkDebugUtilsMessengerEXT)null;
#pragma warning disable 649
    private readonly void* _ptr;
#pragma warning restore 649

    public static explicit operator VkDebugUtilsMessengerEXT(void* ptr)
    {
        VkDebugUtilsMessengerEXT value;
        *(void**)&value = ptr;
        return value;
    }

    public static bool operator ==(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right)
    {
        return left._ptr == right._ptr;
    }

    public static bool operator !=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right)
    {
        return left._ptr != right._ptr;
    }

    public bool Equals(in VkDebugUtilsMessengerEXT obj)
    {
        return obj._ptr == _ptr;
    }

    public override bool Equals(object? obj)
    {
        return obj is VkDebugUtilsMessengerEXT vkDebugUtilsMessengerEXT && Equals(in vkDebugUtilsMessengerEXT);
    }

    public override int GetHashCode()
    {
        return ((IntPtr)_ptr).GetHashCode();
    }

    public static explicit operator void*(VkDebugUtilsMessengerEXT value)
    {
        return value._ptr;
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsLabelEXT
{
    public const VkStructureType STYPE = VkStructureType.DEBUG_UTILS_LABEL_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       sbyte*          pLabelName;
    public       VkColor         color;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsObjectNameInfoEXT
{
    public const VkStructureType STYPE = VkStructureType.DEBUG_UTILS_OBJECT_NAME_INFO_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkObjectType    objectType;
    public       ulong           objectHandle;
    public       sbyte*          pObjectName;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
    public const VkStructureType                STYPE = VkStructureType.DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT;
    public       VkStructureType                sType;
    public       void*                          pNext;
    public       uint                           flags; //reserved for future use
    public       sbyte*                         pMessageIdName;
    public       int                            messageIdNumber;
    public       sbyte*                         pMessage;
    public       uint                           queueLabelCount;
    public       VkDebugUtilsLabelEXT*          pQueueLabels;
    public       uint                           cmdBufLabelCount;
    public       VkDebugUtilsLabelEXT*          pCmdBufLabels;
    public       uint                           objectCount;
    public       VkDebugUtilsObjectNameInfoEXT* pObjects;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
{
    public const VkStructureType                     STYPE = VkStructureType.DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT;
    public       VkStructureType                     sType;
    public       void*                               pNext;
    public       uint                                flags; //reserved for future use
    public       VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
    public       VkDebugUtilsMessageTypeFlagsEXT     messageType;

    public delegate*<                          /*vkDebugUtilsMessengerCallbackEXT*/
        VkDebugUtilsMessageSeverityFlagsEXT,   /* messageSeverity                */
        VkDebugUtilsMessageTypeFlagsEXT,       /* messageTypes                   */
        VkDebugUtilsMessengerCallbackDataEXT*, /* pCallbackData                  */
        void*,                                 /* pUserData                      */
        VkBool32> pfnUserCallback;

    public void* pUserData;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsObjectTagInfoEXT
{
    public const VkStructureType STYPE = VkStructureType.DEBUG_UTILS_OBJECT_TAG_INFO_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkObjectType    objectType;
    public       ulong           objectHandle;
    public       ulong           tagName;
    public       nuint           tagSize;
    public       void*           pTag;
}