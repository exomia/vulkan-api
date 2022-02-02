// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH264PictureLayoutFlagBitsEXT - H.264 video decode picture layout flags - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureLayoutFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureLayoutFlagBitsEXT.html</a> </summary>
[Flags]
public enum VkVideoDecodeH264PictureLayoutFlagBitsEXT : int {
    /// <summary>VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_EXT specifies support for progressive content. This flag has the value 0.</summary>
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_EXT = 0,
    /// <summary>VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_EXTspecifies support for or use of a picture layout for interlaced content where all lines belonging to the first field are decoded to the even-numbered lines within the picture resource, and all lines belonging to the second field are decoded to the odd-numbered lines within the picture resource.</summary>
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_EXT = 0,
    /// <summary>VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_EXTspecifies support for or use of a picture layout for interlaced content where all lines belonging to the first field are grouped together in a single plane, followed by another plane containing all lines belonging to the second field.</summary>
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_EXT = 1
}
