// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265CtbSizeFlagBitsEXT - Supported CTB sizes for H.265 video encode - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CtbSizeFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CtbSizeFlagBitsEXT.html</a> </summary>
[Flags]
public enum VkVideoEncodeH265CtbSizeFlagBitsEXT : int {
    /// <summary>VK_VIDEO_ENCODE_H265_CTB_SIZE_8_BIT_EXT specifies that a CTB size of 8x8 is supported.</summary>
    VK_VIDEO_ENCODE_H265_CTB_SIZE_8_BIT_EXT = 0,
    /// <summary>VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_EXT specifies that a CTB size of 16x16 is supported.</summary>
    VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_EXT = 1,
    /// <summary>VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_EXT specifies that a CTB size of 32x32 is supported.</summary>
    VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_EXT = 2,
    /// <summary>VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_EXT specifies that a CTB size of 64x64 is supported.</summary>
    VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_EXT = 3
}
