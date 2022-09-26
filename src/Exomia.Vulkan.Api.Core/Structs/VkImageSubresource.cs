#region License

// Copyright (c) 2018-2022, exomia
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
///     VkImageSubresource - Structure specifying an image subresource -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageSubresource.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageSubresource.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkImageSubresource
{
    /// <summary> aspectMask is a VkImageAspectFlags value selecting the image aspect. </summary>
    public VkImageAspectFlags aspectMask;

    /// <summary> mipLevel selects the mipmap level. </summary>
    public uint mipLevel;

    /// <summary> arrayLayer selects the array layer. </summary>
    public uint arrayLayer;
}