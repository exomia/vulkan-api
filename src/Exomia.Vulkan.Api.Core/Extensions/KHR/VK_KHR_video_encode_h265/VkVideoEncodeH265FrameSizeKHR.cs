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
///     VkVideoEncodeH265FrameSizeKHR - Structure describing frame size values per H.265 picture type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265FrameSizeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265FrameSizeKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkVideoEncodeH265FrameSizeKHR
{
    /// <summary>frameISize is the size in bytes to be used for I frames.</summary>
    public uint frameISize;

    /// <summary>framePSize is the size in bytes to be used for P frames.</summary>
    public uint framePSize;

    /// <summary>frameBSize is the size in bytes to be used for B frames.</summary>
    public uint frameBSize;
}