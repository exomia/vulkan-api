#region License

// Copyright (c) 2018-2023, exomia
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
///     VkSparseImageMemoryRequirements - Structure specifying sparse image memory requirements -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseImageMemoryRequirements.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseImageMemoryRequirements.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkSparseImageMemoryRequirements
{
    /// <summary>formatProperties is a VkSparseImageFormatPropertiesstructure specifying properties of the image format.</summary>
    public VkSparseImageFormatProperties formatProperties;

    /// <summary>imageMipTailFirstLod is the first mip level at which image subresources are included in the mip tail region.</summary>
    public uint imageMipTailFirstLod;

    /// <summary>
    ///     imageMipTailSize is the memory size (in bytes) of the mip tail region. If formatProperties.flags contains
    ///     VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT, this is the size of the whole mip tail, otherwise this is the size of
    ///     the mip tail of a single array layer. This value is guaranteed to be a multiple of the sparse block size in bytes.
    /// </summary>
    public VkDeviceSize imageMipTailSize;

    /// <summary>
    ///     imageMipTailOffset is the opaque memory offset used with VkSparseImageOpaqueMemoryBindInfo to bind the mip
    ///     tail region(s).
    /// </summary>
    public VkDeviceSize imageMipTailOffset;

    /// <summary>
    ///     imageMipTailStride is the offset stride between each array-layer&#8217;s mip tail, if formatProperties.flags
    ///     does not contain VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT (otherwise the value is undefined).
    /// </summary>
    public VkDeviceSize imageMipTailStride;
}