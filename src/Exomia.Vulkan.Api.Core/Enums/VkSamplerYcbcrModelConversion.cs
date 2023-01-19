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
///     VkSamplerYcbcrModelConversion - Color model component of a color space -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrModelConversion.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrModelConversion.html</a>
/// </summary>
public enum VkSamplerYcbcrModelConversion
{
    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY specifies that the input values to the conversion are
    ///     unmodified.
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY = 0,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY specifies no model conversion but the inputs are range
    ///     expanded as for Y′CBCR.
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY = 1,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709 specifies the color model conversion from Y′CBCR to R′G′B′ defined in
    ///     BT.709 and described in the &#8220;BT.709 Y′CBCR conversion&#8221; section of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#data-format">
    ///         Khronos Data Format
    ///         Specification
    ///     </a>
    ///     .
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709 = 2,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601 specifies the color model conversion from Y′CBCR to R′G′B′ defined in
    ///     BT.601 and described in the &#8220;BT.601 Y′CBCR conversion&#8221; section of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#data-format">
    ///         Khronos Data Format
    ///         Specification
    ///     </a>
    ///     .
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601 = 3,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020 specifies the color model conversion from Y′CBCR to R′G′B′ defined in
    ///     BT.2020 and described in the &#8220;BT.2020 Y′CBCR conversion&#8221; section of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#data-format">
    ///         Khronos Data Format
    ///         Specification
    ///     </a>
    ///     .
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020 = 4,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY specifies that the input values to the conversion are
    ///     unmodified.
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY specifies no model conversion but the inputs are range
    ///     expanded as for Y′CBCR.
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709 specifies the color model conversion from Y′CBCR to R′G′B′ defined in
    ///     BT.709 and described in the &#8220;BT.709 Y′CBCR conversion&#8221; section of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#data-format">
    ///         Khronos Data Format
    ///         Specification
    ///     </a>
    ///     .
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601 specifies the color model conversion from Y′CBCR to R′G′B′ defined in
    ///     BT.601 and described in the &#8220;BT.601 Y′CBCR conversion&#8221; section of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#data-format">
    ///         Khronos Data Format
    ///         Specification
    ///     </a>
    ///     .
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601,

    /// <summary>
    ///     VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020 specifies the color model conversion from Y′CBCR to R′G′B′ defined in
    ///     BT.2020 and described in the &#8220;BT.2020 Y′CBCR conversion&#8221; section of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#data-format">
    ///         Khronos Data Format
    ///         Specification
    ///     </a>
    ///     .
    /// </summary>
    VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020
}