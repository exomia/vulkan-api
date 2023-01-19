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
///     VkSamplerAddressMode - Specify behavior of sampling with texture coordinates outside an image -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerAddressMode.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerAddressMode.html</a>
/// </summary>
public enum VkSamplerAddressMode
{
    /// <summary>VK_SAMPLER_ADDRESS_MODE_REPEAT specifies that the repeat wrap mode will be used.</summary>
    VK_SAMPLER_ADDRESS_MODE_REPEAT = 0,

    /// <summary>VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT specifies that the mirrored repeat wrap mode will be used.</summary>
    VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT = 1,

    /// <summary>VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE specifies that the clamp to edge wrap mode will be used.</summary>
    VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE = 2,

    /// <summary>VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER specifies that the clamp to border wrap mode will be used.</summary>
    VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER = 3,

    /// <summary>
    ///     VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE specifies that the     mirror clamp to edge wrap mode will be used.
    ///     This is only valid if
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#features-samplerMirrorClampToEdge">
    ///         <code>samplerMirrorClampToEdge</code>
    ///     </a>
    ///     is enabled, or if     the VK_KHR_sampler_mirror_clamp_to_edge extension is enabled.
    /// </summary>
    VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE = 4,

    /// <summary>
    ///     VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE specifies that the     mirror clamp to edge wrap mode will be used.
    ///     This is only valid if
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#features-samplerMirrorClampToEdge">
    ///         <code>samplerMirrorClampToEdge</code>
    ///     </a>
    ///     is enabled, or if     the VK_KHR_sampler_mirror_clamp_to_edge extension is enabled.
    /// </summary>
    VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE_KHR = VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE
}