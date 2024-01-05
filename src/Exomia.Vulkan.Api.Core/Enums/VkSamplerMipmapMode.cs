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
///     VkSamplerMipmapMode - Specify mipmap mode used for texture lookups -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerMipmapMode.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerMipmapMode.html</a>
/// </summary>
public enum VkSamplerMipmapMode
{
    /// <summary>VK_SAMPLER_MIPMAP_MODE_NEAREST specifies nearest filtering.</summary>
    VK_SAMPLER_MIPMAP_MODE_NEAREST = 0,

    /// <summary>VK_SAMPLER_MIPMAP_MODE_LINEAR specifies linear filtering.</summary>
    VK_SAMPLER_MIPMAP_MODE_LINEAR = 1
}