// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH264CapabilityFlagBitsEXT - Video encode H.264 capability flags - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilityFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilityFlagBitsEXT.html</a> </summary>
[Flags]
public enum VkVideoEncodeH264CapabilityFlagBitsEXT : int {
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_CABAC_BIT_EXT reports if CABAC entropy coding is supported.</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_CABAC_BIT_EXT = 0,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_CAVLC_BIT_EXT reports if CAVLC entropy coding is supported. An implementation must support at least one entropy coding mode.</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_CAVLC_BIT_EXT = 1,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_BI_PRED_IMPLICIT_BIT_EXTreports if using weighted_bipred_idc_flag from StdVideoH264PpsFlags is supported.</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_WEIGHTED_BI_PRED_IMPLICIT_BIT_EXT = 2,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_TRANSFORM_8X8_BIT_EXT reports if enabling transform_8x8_mode_flag in StdVideoH264PpsFlags is supported.</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_TRANSFORM_8X8_BIT_EXT = 3,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_CHROMA_QP_OFFSET_BIT_EXT reports if setting chroma_qp_index_offset in StdVideoH264PictureParameterSet is supported.</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_CHROMA_QP_OFFSET_BIT_EXT = 4,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_SECOND_CHROMA_QP_OFFSET_BIT_EXTreports if setting second_chroma_qp_index_offset in StdVideoH264PictureParameterSet is supported.</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_SECOND_CHROMA_QP_OFFSET_BIT_EXT = 5,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_DISABLED_BIT_EXTreports if using STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_DISABLED from StdVideoH264DisableDeblockingFilterIdc is supported.</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_DISABLED_BIT_EXT = 6,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_ENABLED_BIT_EXTreports if using STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_ENABLED from StdVideoH264DisableDeblockingFilterIdc is supported.</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_ENABLED_BIT_EXT = 7,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_PARTIAL_BIT_EXTreports if using STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_PARTIAL from StdVideoH264DisableDeblockingFilterIdc is supported. An implementation must support at least one deblocking filter mode.</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_DEBLOCKING_FILTER_PARTIAL_BIT_EXT = 8,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_MULTIPLE_SLICE_PER_FRAME_BIT_EXT</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_MULTIPLE_SLICE_PER_FRAME_BIT_EXT = 9,
    /// <summary>VK_VIDEO_ENCODE_H264_CAPABILITY_EVENLY_DISTRIBUTED_SLICE_SIZE_BIT_EXT</summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_EVENLY_DISTRIBUTED_SLICE_SIZE_BIT_EXT = 10
}
