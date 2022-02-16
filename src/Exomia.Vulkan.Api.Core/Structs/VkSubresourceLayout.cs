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
///     VkSubresourceLayout - Structure specifying subresource layout -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubresourceLayout.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubresourceLayout.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkSubresourceLayout
{
    /// <summary>offset is the byte offset from the start of the image or the plane where the image subresource begins.</summary>
    public VkDeviceSize offset;

    /// <summary>
    ///     size is the size in bytes of the image subresource. size includes any extra memory that is required based on
    ///     rowPitch.
    /// </summary>
    public VkDeviceSize size;

    /// <summary>rowPitch describes the number of bytes between each row of texels in an image.</summary>
    public VkDeviceSize rowPitch;

    /// <summary>arrayPitch describes the number of bytes between each array layer of an image.</summary>
    public VkDeviceSize arrayPitch;

    /// <summary>depthPitch describes the number of bytes between each slice of 3D image.</summary>
    public VkDeviceSize depthPitch;
}