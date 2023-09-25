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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkDisplacementMicromapFormatNV - Format enum for displacement micromaps -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplacementMicromapFormatNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplacementMicromapFormatNV.html</a>
/// </summary>
public enum VkDisplacementMicromapFormatNV
{
    /// <summary>
    ///     VK_DISPLACEMENT_MICROMAP_FORMAT_64_TRIANGLES_64_BYTES_NV indicates that the given micromap format encodes 64
    ///     micro-triangles worth of displacements in 64 bytes as described in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#displacement-micromap-encoding">
    ///         Displacement
    ///         Micromap Encoding
    ///     </a>
    ///     .
    /// </summary>
    VK_DISPLACEMENT_MICROMAP_FORMAT_64_TRIANGLES_64_BYTES_NV = 1,

    /// <summary>
    ///     VK_DISPLACEMENT_MICROMAP_FORMAT_256_TRIANGLES_128_BYTES_NVindicates that the given micromap format encodes 256
    ///     micro-triangles worth of displacements in 128 bytes as described in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#displacement-micromap-encoding">
    ///         Displacement
    ///         Micromap Encoding
    ///     </a>
    ///     .
    /// </summary>
    VK_DISPLACEMENT_MICROMAP_FORMAT_256_TRIANGLES_128_BYTES_NV = 2,

    /// <summary>
    ///     VK_DISPLACEMENT_MICROMAP_FORMAT_1024_TRIANGLES_128_BYTES_NVindicates that the given micromap format encodes 1024
    ///     micro-triangles worth of displacements in 128 bytes as described in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#displacement-micromap-encoding">
    ///         Displacement
    ///         Micromap Encoding
    ///     </a>
    ///     .
    /// </summary>
    VK_DISPLACEMENT_MICROMAP_FORMAT_1024_TRIANGLES_128_BYTES_NV = 3
}