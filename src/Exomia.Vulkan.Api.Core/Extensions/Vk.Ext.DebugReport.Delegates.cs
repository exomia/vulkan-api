#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    public unsafe delegate VkBool32 DebugReportCallbackEXT(
        VkDebugReportFlagsEXT      flags,
        VkDebugReportObjectTypeEXT objectType,
        ulong                      @object,
        nuint                      location,
        int                        messageCode,
        sbyte*                     pLayerPrefix,
        sbyte*                     pMessage,
        void*                      pUserData);

    public unsafe delegate VkResult CreateDebugReportCallbackEXT(
        VkInstance                          instance,
        VkDebugReportCallbackCreateInfoEXT* pCreateInfo,
        VkAllocationCallbacks*              pAllocator,
        VkDebugReportCallbackEXT*           pCallback);

    public unsafe delegate void DestroyDebugReportCallbackEXT(
        VkInstance               instance,
        VkDebugReportCallbackEXT callback,
        VkAllocationCallbacks*   pAllocator);

    public unsafe delegate void DebugReportMessageEXT(
        VkInstance                 instance,
        VkDebugReportFlagsEXT      flags,
        VkDebugReportObjectTypeEXT objectType,
        ulong                      @object,
        nuint                      location,
        int                        messageCode,
        sbyte*                     pLayerPrefix,
        sbyte*                     pMessage);
}