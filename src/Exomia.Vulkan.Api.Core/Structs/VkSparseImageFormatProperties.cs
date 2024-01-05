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
///     VkSparseImageFormatProperties - Structure specifying sparse image format properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseImageFormatProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseImageFormatProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkSparseImageFormatProperties
{
    /// <summary>aspectMask is a bitmask VkImageAspectFlagBits specifying which aspects of the image the properties apply to.</summary>
    public VkImageAspectFlags aspectMask;

    /// <summary>
    ///     imageGranularity is the width, height, and depth of the sparse image block in texels or compressed texel
    ///     blocks.
    /// </summary>
    public VkExtent3D imageGranularity;

    /// <summary>flags is a bitmask of VkSparseImageFormatFlagBits specifying additional information about the sparse resource.</summary>
    public VkSparseImageFormatFlags flags;
}