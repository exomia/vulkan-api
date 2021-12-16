﻿#region License

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
public unsafe struct VkLayerProperties
{
    public fixed sbyte     layerName[(int)Vk.VK_MAX_EXTENSION_NAME_SIZE];
    public       VkVersion specVersion;
    public       uint      implementationVersion;
    public fixed sbyte     description[(int)Vk.VK_MAX_DESCRIPTION_SIZE];
}