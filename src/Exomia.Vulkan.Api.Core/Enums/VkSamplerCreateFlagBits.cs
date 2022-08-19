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
///     VkSamplerCreateFlagBits - Bitmask specifying additional parameters of sampler -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkSamplerCreateFlagBits
{
    /// <summary>
    ///     VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSamplerCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSamplerCreateFlagBits</a>
    /// </summary>
    VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXTspecifies that the implementation may use
    ///     approximations when reconstructing a full color value for texture access from a subsampled image.
    /// </summary>
    VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_SAMPLER_CREATE_RESERVED_3_BIT_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSamplerCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSamplerCreateFlagBits</a>
    /// </summary>
    VK_SAMPLER_CREATE_RESERVED_3_BIT_AMD = 0x8,

    /// <summary>
    ///     VK_SAMPLER_CREATE_NON_SEAMLESS_CUBE_MAP_BIT_EXT specifies that
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-cubemapedge">
    ///         cube map
    ///         edge handling
    ///     </a>
    ///     is not performed.
    /// </summary>
    VK_SAMPLER_CREATE_NON_SEAMLESS_CUBE_MAP_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSamplerCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSamplerCreateFlagBits</a>
    /// </summary>
    VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM = 0x10
}