#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan11Features
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_VULKAN_1_1_FEATURES;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        storageBuffer16BitAccess;
    public       VkBool32        uniformAndStorageBuffer16BitAccess;
    public       VkBool32        storagePushConstant16;
    public       VkBool32        storageInputOutput16;
    public       VkBool32        multiview;
    public       VkBool32        multiviewGeometryShader;
    public       VkBool32        multiviewTessellationShader;
    public       VkBool32        variablePointersStorageBuffer;
    public       VkBool32        variablePointers;
    public       VkBool32        protectedMemory;
    public       VkBool32        samplerYcbcrConversion;
    public       VkBool32        shaderDrawParameters;
}