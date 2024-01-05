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
///     VkIndirectCommandsStreamNV - Structure specifying input streams for generated command tokens -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsStreamNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsStreamNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkIndirectCommandsStreamNV
{
    /// <summary>
    ///     buffer specifies the VkBuffer storing the functional arguments for each sequence. These arguments can be
    ///     written by the device.
    /// </summary>
    public VkBuffer buffer;

    /// <summary>offset specified an offset into buffer where the arguments start.</summary>
    public VkDeviceSize offset;
}