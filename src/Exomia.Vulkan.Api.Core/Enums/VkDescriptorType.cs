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
///     VkDescriptorType - Specifies the type of a descriptor in a descriptor set -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorType.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorType.html </a>
/// </summary>
public enum VkDescriptorType
{
    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_SAMPLER specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampler"> sampler descriptor </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_SAMPLER = 0,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER specifies a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-combinedimagesampler">
    ///         combined image sampler descriptor
    ///     </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER = 1,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampledimage"> sampled image descriptor </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE = 2,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_STORAGE_IMAGE specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage"> storage image descriptor </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_STORAGE_IMAGE = 3,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER specifies a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformtexelbuffer">
    ///         uniform texel buffer descriptor
    ///     </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER = 4,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER specifies a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer">
    ///         storage texel buffer descriptor
    ///     </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER = 5,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbuffer"> uniform buffer descriptor </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER = 6,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_STORAGE_BUFFER specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebuffer"> storage buffer descriptor </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_STORAGE_BUFFER = 7,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC specifies a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-uniformbufferdynamic">
    ///         dynamic uniform buffer descriptor
    ///     </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC = 8,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC specifies a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagebufferdynamic">
    ///         dynamic storage buffer descriptor
    ///     </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC = 9,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT specifies an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-inputattachment"> input attachment descriptor </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT = 10,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK specifies an
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-inlineuniformblock">
    ///         inline uniform block
    ///     </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK = 1000138000,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDescriptorType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDescriptorType </a>
    /// </summary>
    VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR = 1000150000,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDescriptorType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDescriptorType </a>
    /// </summary>
    VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV = 1000165000,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_SAMPLE_WEIGHT_IMAGE_QCOM specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-weightimage"> sampled weight image descriptor </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_SAMPLE_WEIGHT_IMAGE_QCOM = 1000440000,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_BLOCK_MATCH_IMAGE_QCOM specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-blockmatch"> block matching image descriptor </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_BLOCK_MATCH_IMAGE_QCOM = 1000440001,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_MUTABLE_EXT specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-mutable"> descriptor of mutable type </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_MUTABLE_EXT = 1000351000,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK specifies an
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-inlineuniformblock">
    ///         inline uniform block
    ///     </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT = VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK,

    /// <summary>
    ///     VK_DESCRIPTOR_TYPE_MUTABLE_EXT specifies a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-mutable"> descriptor of mutable type </a>
    ///     .
    /// </summary>
    VK_DESCRIPTOR_TYPE_MUTABLE_VALVE = VK_DESCRIPTOR_TYPE_MUTABLE_EXT
}