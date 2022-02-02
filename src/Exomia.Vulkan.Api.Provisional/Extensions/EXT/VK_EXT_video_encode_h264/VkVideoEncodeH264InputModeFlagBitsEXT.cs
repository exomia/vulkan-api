// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH264InputModeFlagBitsEXT - Video encode H.264 input modes - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264InputModeFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264InputModeFlagBitsEXT.html</a> </summary>
[Flags]
public enum VkVideoEncodeH264InputModeFlagBitsEXT : int {
    /// <summary>VK_VIDEO_ENCODE_H264_INPUT_MODE_FRAME_BIT_EXT indicates that a single command buffer must at least encode an entire frame. Any non-VCL NALUs must be encoded using the same command buffer as the frame if VK_VIDEO_ENCODE_H264_INPUT_MODE_NON_VCL_BIT_EXT is not supported.</summary>
    VK_VIDEO_ENCODE_H264_INPUT_MODE_FRAME_BIT_EXT = 0,
    /// <summary>VK_VIDEO_ENCODE_H264_INPUT_MODE_SLICE_BIT_EXT indicates that a single command buffer must at least encode a single slice. Any non-VCL NALUs must be encoded using the same command buffer as the first slice of the frame if VK_VIDEO_ENCODE_H264_INPUT_MODE_NON_VCL_BIT_EXT is not supported.</summary>
    VK_VIDEO_ENCODE_H264_INPUT_MODE_SLICE_BIT_EXT = 1,
    /// <summary>VK_VIDEO_ENCODE_H264_INPUT_MODE_NON_VCL_BIT_EXT indicates that a single command buffer may encode a non-VCL NALU by itself.</summary>
    VK_VIDEO_ENCODE_H264_INPUT_MODE_NON_VCL_BIT_EXT = 2
}
