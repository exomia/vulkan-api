// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265OutputModeFlagBitsEXT - Video encode H.265 output modes - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265OutputModeFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265OutputModeFlagBitsEXT.html</a> </summary>
[Flags]
public enum VkVideoEncodeH265OutputModeFlagBitsEXT : int {
    /// <summary>VK_VIDEO_ENCODE_H265_OUTPUT_MODE_FRAME_BIT_EXT indicates that calls to generate all NALUs of a frame must be included within a single begin/end pair. Any non-VCL NALUs must be encoded within the same begin/end pair if VK_VIDEO_ENCODE_H265_OUTPUT_MODE_NON_VCL_BIT_EXT is not supported.</summary>
    VK_VIDEO_ENCODE_H265_OUTPUT_MODE_FRAME_BIT_EXT = 0,
    /// <summary>VK_VIDEO_ENCODE_H265_OUTPUT_MODE_SLICE_BIT_EXT indicates that each begin/end pair must encode at least one slice. Any non-VCL NALUs must be encoded within the same begin/end pair as the first slice of the frame if VK_VIDEO_ENCODE_H265_OUTPUT_MODE_NON_VCL_BIT_EXT is not supported.</summary>
    VK_VIDEO_ENCODE_H265_OUTPUT_MODE_SLICE_BIT_EXT = 1,
    /// <summary>VK_VIDEO_ENCODE_H265_OUTPUT_MODE_NON_VCL_BIT_EXT indicates that each begin/end pair may encode only a non-VCL NALU by itself. An implementation must support at least one of VK_VIDEO_ENCODE_H265_OUTPUT_MODE_FRAME_BIT_EXT or VK_VIDEO_ENCODE_H265_OUTPUT_MODE_SLICE_BIT_EXT.</summary>
    VK_VIDEO_ENCODE_H265_OUTPUT_MODE_NON_VCL_BIT_EXT = 2
}
