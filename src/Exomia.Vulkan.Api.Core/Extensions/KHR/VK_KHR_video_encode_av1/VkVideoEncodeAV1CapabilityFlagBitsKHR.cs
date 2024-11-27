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
///     VkVideoEncodeAV1CapabilityFlagBitsKHR - AV1 encode capability flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1CapabilityFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1CapabilityFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeAV1CapabilityFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_CAPABILITY_PER_RATE_CONTROL_GROUP_MIN_MAX_Q_INDEX_BIT_KHRindicates support for specifying
    ///     different quantizer index values in the members of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1QIndexKHR.html">VkVideoEncodeAV1QIndexKHR</a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_AV1_CAPABILITY_PER_RATE_CONTROL_GROUP_MIN_MAX_Q_INDEX_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_CAPABILITY_GENERATE_OBU_EXTENSION_HEADER_BIT_KHRindicates support for generating OBU
    ///     extension headers, as defined in section 5.3.3 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#aomedia-av1">AV1 Specification</a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_AV1_CAPABILITY_GENERATE_OBU_EXTENSION_HEADER_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_CAPABILITY_PRIMARY_REFERENCE_CDF_ONLY_BIT_KHRindicates support for using the primary reference
    ///     frame indicated by the value of StdVideoEncodeAV1PictureInfo::primary_ref_frame in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-picture-info">
    ///         AV1
    ///         picture information
    ///     </a>
    ///     only for CDF data reference, as defined in section 6.8.2 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#aomedia-av1">AV1 Specification</a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_AV1_CAPABILITY_PRIMARY_REFERENCE_CDF_ONLY_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_CAPABILITY_FRAME_SIZE_OVERRIDE_BIT_KHRindicates support for encoding a picture with a frame
    ///     size different from the maximum frame size defined in the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-active-sequence-header">
    ///         active
    ///         AV1 sequence header
    ///     </a>
    ///     . If this capability is not supported, then frame_size_override_flagmust not be set in
    ///     the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-picture-info">
    ///         AV1
    ///         picture information
    ///     </a>
    ///     of the encoded frame and the coded extent of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-input-picture">
    ///         encode
    ///         input picture
    ///     </a>
    ///     must match the maximum coded extent allowed by the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-active-sequence-header">
    ///         active
    ///         AV1 sequence header
    ///     </a>
    ///     , i.e. (max_frame_width_minus_1 +  1, max_frame_height_minus_1 +  1).
    /// </summary>
    VK_VIDEO_ENCODE_AV1_CAPABILITY_FRAME_SIZE_OVERRIDE_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_CAPABILITY_MOTION_VECTOR_SCALING_BIT_KHRindicates support for motion vector scaling, as defined
    ///     in section 7.11.3.3 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#aomedia-av1">AV1 Specification</a>
    ///     . If this capability is not supported, then the coded extent of all
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#active-reference-pictures">
    ///         active
    ///         reference pictures
    ///     </a>
    ///     must match the coded extent of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-input-picture">
    ///         encode
    ///         input picture
    ///     </a>
    ///     . This capability may only be supported by a video profile when
    ///     VK_VIDEO_ENCODE_AV1_CAPABILITY_FRAME_SIZE_OVERRIDE_BIT_KHR is also supported.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_CAPABILITY_MOTION_VECTOR_SCALING_BIT_KHR = 0x10
}