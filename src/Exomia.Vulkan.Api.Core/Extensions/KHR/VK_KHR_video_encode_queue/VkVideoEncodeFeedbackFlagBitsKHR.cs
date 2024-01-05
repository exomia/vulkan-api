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
///     VkVideoEncodeFeedbackFlagBitsKHR - Bits specifying queried video encode feedback values -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeFeedbackFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeFeedbackFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeFeedbackFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR specifies that queries managed by the pool will capture
    ///     the byte offset of the bitstream data written by the video encode operation to the bitstream buffer specified in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeInfoKHR.html">VkVideoEncodeInfoKHR</a>
    ///     ::dstBuffer relative to the offset specified in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeInfoKHR.html">VkVideoEncodeInfoKHR</a>
    ///     ::dstBufferOffset. For the first video encode operation issued by any
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-commands">
    ///         video
    ///         encode command
    ///     </a>
    ///     , this value will always be zero, meaning that bitstream data is always written to the buffer
    ///     specified in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeInfoKHR.html">VkVideoEncodeInfoKHR</a>
    ///     ::dstBuffer starting from the offset specified in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeInfoKHR.html">VkVideoEncodeInfoKHR</a>
    ///     ::dstBufferOffset.
    /// </summary>
    VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR specifies that queries managed by the pool will
    ///     capture the number of bytes written by the video encode operation to the bitstream buffer specified in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeInfoKHR.html">VkVideoEncodeInfoKHR</a>
    ///     ::dstBuffer.
    /// </summary>
    VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_HAS_OVERRIDES_BIT_KHR specifies that queries managed by the pool will capture a
    ///     boolean value indicating that the data written to the bitstream buffer specified in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeInfoKHR.html">VkVideoEncodeInfoKHR</a>
    ///     ::dstBuffer contains
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-overrides">
    ///         overridden
    ///         parameters
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_HAS_OVERRIDES_BIT_KHR = 0x4
}