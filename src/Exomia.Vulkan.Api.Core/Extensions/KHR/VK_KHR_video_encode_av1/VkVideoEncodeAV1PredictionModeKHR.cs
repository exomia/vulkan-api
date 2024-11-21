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
///     VkVideoEncodeAV1PredictionModeKHR - AV1 encode prediction mode -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1PredictionModeKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1PredictionModeKHR.html
///     </a>
/// </summary>
public enum VkVideoEncodeAV1PredictionModeKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_INTRA_ONLY_KHR specifies the use of intra-only prediction mode, used when
    ///     encoding AV1 frames of type STD_VIDEO_AV1_FRAME_TYPE_KEY or STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_INTRA_ONLY_KHR = 0,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_SINGLE_REFERENCE_KHR specifies the use of single reference prediction mode,
    ///     used when encoding AV1 frames of type STD_VIDEO_AV1_FRAME_TYPE_INTER or STD_VIDEO_AV1_FRAME_TYPE_SWITCH with
    ///     reference_select, as defined in section 6.8.23 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#aomedia-av1">AV1 Specification</a>
    ///     , equal to 0. When using this prediction mode, the application must specify a reference picture for at least one
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-reference-names">
    ///         AV1
    ///         reference name
    ///     </a>
    ///     in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1PictureInfoKHR.html">VkVideoEncodeAV1PictureInfoKHR</a>
    ///     ::referenceNameSlotIndicesthat is supported by the implementation, as reported in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1CapabilitiesKHR.html">
    ///         VkVideoEncodeAV1CapabilitiesKHR
    ///     </a>
    ///     ::singleReferenceNameMask.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_SINGLE_REFERENCE_KHR = 1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_UNIDIRECTIONAL_COMPOUND_KHRspecifies the use of unidirectional compound
    ///     prediction mode, used when encoding AV1 frames of type STD_VIDEO_AV1_FRAME_TYPE_INTER or
    ///     STD_VIDEO_AV1_FRAME_TYPE_SWITCH with reference_select, as defined in section 6.8.23 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#aomedia-av1">AV1 Specification</a>
    ///     , equal to 1, and both
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-reference-names">
    ///         reference
    ///         names
    ///     </a>
    ///     used for prediction are from the same reference frame group, as defined in section 6.10.24 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#aomedia-av1">AV1 Specification</a>
    ///     . When using this prediction mode, the application must specify a reference picture for at least two
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-reference-names">
    ///         AV1
    ///         reference names
    ///     </a>
    ///     in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1PictureInfoKHR.html">VkVideoEncodeAV1PictureInfoKHR</a>
    ///     ::referenceNameSlotIndicesthat is supported by the implementation, as reported in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1CapabilitiesKHR.html">
    ///         VkVideoEncodeAV1CapabilitiesKHR
    ///     </a>
    ///     ::unidirectionalCompoundReferenceNameMask, where those two reference names are one of the allowed pairs of
    ///     reference names, as defined in section 5.11.25 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#aomedia-av1">AV1 Specification</a>
    ///     , listed below:<br />
    ///     LAST_FRAME and LAST2_FRAME,<br />
    ///     LAST_FRAME and LAST3_FRAME,<br />
    ///     LAST_FRAME and GOLDEN_FRAME, or<br />
    ///     BWDREF_FRAME and ALTREF_FRAME.<br />
    /// </summary>
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_UNIDIRECTIONAL_COMPOUND_KHR = 2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_BIDIRECTIONAL_COMPOUND_KHRspecifies the use of bidirectional compound
    ///     prediction mode, used when encoding AV1 frames of type STD_VIDEO_AV1_FRAME_TYPE_INTER or
    ///     STD_VIDEO_AV1_FRAME_TYPE_SWITCH with reference_select, as defined in section 6.8.23 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#aomedia-av1">AV1 Specification</a>
    ///     , equal to 1, and the two
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-reference-names">
    ///         reference
    ///         names
    ///     </a>
    ///     used for prediction are from different reference frame groups, as defined in section 6.10.24 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#aomedia-av1">AV1 Specification</a>
    ///     . When using this prediction mode, the application must specify a reference picture for at least one
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-av1-reference-names">
    ///         AV1
    ///         reference name
    ///     </a>
    ///     from each reference frame group in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1PictureInfoKHR.html">VkVideoEncodeAV1PictureInfoKHR</a>
    ///     ::referenceNameSlotIndicesthat is supported by the implementation, as reported in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1CapabilitiesKHR.html">
    ///         VkVideoEncodeAV1CapabilitiesKHR
    ///     </a>
    ///     ::bidirectionalCompoundReferenceNameMask.
    /// </summary>
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_BIDIRECTIONAL_COMPOUND_KHR = 3
}