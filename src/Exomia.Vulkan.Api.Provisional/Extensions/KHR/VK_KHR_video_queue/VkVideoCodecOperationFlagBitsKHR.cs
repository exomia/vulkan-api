// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoCodecOperationFlagBitsKHR - Video codec operation types - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodecOperationFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodecOperationFlagBitsKHR.html</a> </summary>
[Flags]
public enum VkVideoCodecOperationFlagBitsKHR : int {
    /// <summary>VK_VIDEO_CODEC_OPERATION_INVALID_BIT_KHR - No video operations are supported for this queue family.</summary>
    VK_VIDEO_CODEC_OPERATION_INVALID_BIT_KHR = 0,
    /// <summary>VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_EXT - H.264 video encode operations are supported by this queue family.</summary>
    VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_EXT = 16,
    /// <summary>VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_EXT<br/><a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoCodecOperationFlagBitsKHR">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoCodecOperationFlagBitsKHR</a></summary>
    VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_EXT = 17,
    /// <summary>VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_EXT - H.264 video decode operations are supported by this queue family.</summary>
    VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_EXT = 0,
    /// <summary>VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_EXT - H.265 video decode operations are supported by this queue family.</summary>
    VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_EXT = 1
}
