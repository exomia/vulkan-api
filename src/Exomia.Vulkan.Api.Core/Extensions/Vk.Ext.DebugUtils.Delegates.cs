#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    public unsafe delegate VkBool32 DebugUtilsMessengerCallbackEXT(
        VkDebugUtilsMessageSeverityFlagsEXT messageSeverity,
        VkDebugUtilsMessageTypeFlagsEXT messageTypes,
        VkDebugUtilsMessengerCallbackDataEXT* pCallbackData,
        void* pUserData);

    public unsafe delegate VkResult SetDebugUtilsObjectNameEXT(
        VkDevice device,
        VkDebugUtilsObjectNameInfoEXT* pNameInfo);

    public unsafe delegate VkResult SetDebugUtilsObjectTagEXT(
        VkDevice device,
        VkDebugUtilsObjectTagInfoEXT* pTagInfo);

    public unsafe delegate void QueueBeginDebugUtilsLabelEXT(
        VkQueue queue,
        VkDebugUtilsLabelEXT* pLabelInfo);

    public delegate void QueueEndDebugUtilsLabelEXT(VkQueue queue);

    public unsafe delegate void QueueInsertDebugUtilsLabelEXT(
        VkQueue queue,
        VkDebugUtilsLabelEXT* pLabelInfo);

    public unsafe delegate void CmdBeginDebugUtilsLabelEXT(
        VkCommandBuffer commandBuffer,
        VkDebugUtilsLabelEXT* pLabelInfo);

    public delegate void CmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer);

    public unsafe delegate void CmdInsertDebugUtilsLabelEXT(
        VkCommandBuffer commandBuffer,
        VkDebugUtilsLabelEXT* pLabelInfo);

    public unsafe delegate VkResult CreateDebugUtilsMessengerEXT(
        VkInstance instance,
        VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkDebugUtilsMessengerEXT* pMessenger);

    public unsafe delegate void DestroyDebugUtilsMessengerEXT(
        VkInstance instance,
        VkDebugUtilsMessengerEXT messenger,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate void SubmitDebugUtilsMessageEXT(
        VkInstance instance,
        VkDebugUtilsMessageSeverityFlagsEXT messageSeverity,
        VkDebugUtilsMessageTypeFlagsEXT messageTypes,
        VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);
}
