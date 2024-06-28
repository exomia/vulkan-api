#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkPhysicalDeviceLayeredApiKHR - API implemented by the layered implementation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLayeredApiKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLayeredApiKHR.html</a>
/// </summary>
public enum VkPhysicalDeviceLayeredApiKHR
{
    /// <summary>VK_PHYSICAL_DEVICE_LAYERED_API_VULKAN_KHR - the device implements the Vulkan API.</summary>
    VK_PHYSICAL_DEVICE_LAYERED_API_VULKAN_KHR = 0,

    /// <summary>VK_PHYSICAL_DEVICE_LAYERED_API_D3D12_KHR - the device implements the D3D12 API.</summary>
    VK_PHYSICAL_DEVICE_LAYERED_API_D3D12_KHR = 1,

    /// <summary>VK_PHYSICAL_DEVICE_LAYERED_API_METAL_KHR - the device implements the Metal API.</summary>
    VK_PHYSICAL_DEVICE_LAYERED_API_METAL_KHR = 2,

    /// <summary>VK_PHYSICAL_DEVICE_LAYERED_API_OPENGL_KHR - the device implements the OpenGL API.</summary>
    VK_PHYSICAL_DEVICE_LAYERED_API_OPENGL_KHR = 3,

    /// <summary>VK_PHYSICAL_DEVICE_LAYERED_API_OPENGLES_KHR - the device implements the OpenGL ES API.</summary>
    VK_PHYSICAL_DEVICE_LAYERED_API_OPENGLES_KHR = 4
}