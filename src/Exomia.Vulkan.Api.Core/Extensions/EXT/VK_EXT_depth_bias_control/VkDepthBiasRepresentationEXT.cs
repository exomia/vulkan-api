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
///     VkDepthBiasRepresentationEXT - Specify the depth bias representation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDepthBiasRepresentationEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDepthBiasRepresentationEXT.html</a>
/// </summary>
public enum VkDepthBiasRepresentationEXT
{
    /// <summary>
    ///     VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORMAT_EXTspecifies that the depth bias representation is a
    ///     factor of the format&#8217;s r as described in
    ///     <a class="bare"
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-depthbias-computation">
    ///         https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-depthbias-computation
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORMAT_EXT = 0,

    /// <summary>
    ///     VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORCE_UNORM_EXTspecifies that the depth bias representation
    ///     is a factor of a constant r defined by the bit-size or mantissa of the format as described in
    ///     <a class="bare"
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-depthbias-computation">
    ///         https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-depthbias-computation
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORCE_UNORM_EXT = 1,

    /// <summary>
    ///     VK_DEPTH_BIAS_REPRESENTATION_FLOAT_EXT specifies that the depth bias representation is a factor of constant r
    ///     equal to 1.
    /// </summary>
    VK_DEPTH_BIAS_REPRESENTATION_FLOAT_EXT = 2
}