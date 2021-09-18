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
namespace Exomia.Vulkan.Api.Core.Extensions
{

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsLabelEXT
    {
        public const VkStructureType STYPE = VkStructureType.DEBUG_UTILS_LABEL_EXT;
        public VkStructureType sType;
        public void* pNext;
        public sbyte* pLabelName;
        public VkColor color;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsObjectNameInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.DEBUG_UTILS_OBJECT_NAME_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public sbyte* pObjectName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public const VkStructureType STYPE = VkStructureType.DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint flags; //reserved for future use
        public sbyte* pMessageIdName;
        public int messageIdNumber;
        public sbyte* pMessage;
        public uint queueLabelCount;
        public VkDebugUtilsLabelEXT* pQueueLabels;
        public uint cmdBufLabelCount;
        public VkDebugUtilsLabelEXT* pCmdBufLabels;
        public uint objectCount;
        public VkDebugUtilsObjectNameInfoEXT* pObjects;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint flags; //reserved for future use
        public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
        public VkDebugUtilsMessageTypeFlagsEXT messageType;

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
        public VkStructureType sType;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public ulong tagName;
        public nuint tagSize;
        public void* pTag;
    }
}
