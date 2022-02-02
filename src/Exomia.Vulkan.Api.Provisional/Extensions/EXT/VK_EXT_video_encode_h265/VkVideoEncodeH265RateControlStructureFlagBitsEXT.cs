// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265RateControlStructureFlagBitsEXT - Video encode H.265 rate control structure flags - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlStructureFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlStructureFlagBitsEXT.html</a> </summary>
[Flags]
public enum VkVideoEncodeH265RateControlStructureFlagBitsEXT : int {
    /// <summary>VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_UNKNOWN_EXT is 0, and specifies a reference structure unknown at the time of stream rate control configuration.</summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_UNKNOWN_EXT = 0,
    /// <summary>VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_FLAT_BIT_EXT specifies a flat reference structure.</summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_FLAT_BIT_EXT = 0,
    /// <summary>VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_DYADIC_BIT_EXTspecifies a dyadic reference structure.</summary>
    VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_DYADIC_BIT_EXT = 1
}
