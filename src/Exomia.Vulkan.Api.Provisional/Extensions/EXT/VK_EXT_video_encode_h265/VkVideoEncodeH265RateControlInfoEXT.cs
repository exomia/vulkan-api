// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265RateControlInfoEXT - Structure describing H.265 stream rate control parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoEncodeRateControlInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoEncodeRateControlInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265RateControlInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>gopFrameCount is the number of frames contained within the group of pictures (GOP), starting from an intra frame and until the next intra frame. If it is set to 0, the implementation chooses a suitable value. If it is set to UINT32_MAX, the GOP length is treated as infinite.</summary>
    public uint gopFrameCount;
    /// <summary>idrPeriod is the interval, in terms of number of frames, between two IDR frames. If it is set to 0, the implementation chooses a suitable value. If it is set to UINT32_MAX, the IDR period is treated as infinite.</summary>
    public uint idrPeriod;
    /// <summary>consecutiveBFrameCount is the number of consecutive B-frames between I- and/or P-frames within the GOP.</summary>
    public uint consecutiveBFrameCount;
    /// <summary>rateControlStructure is a VkVideoEncodeH265RateControlStructureFlagBitsEXT value specifying the expected encode stream reference structure, to aid in rate control calculations.</summary>
    public VkVideoEncodeH265RateControlStructureFlagBitsEXT rateControlStructure;
    /// <summary>subLayerCount specifies the number of sub layers enabled in the stream.</summary>
    public byte subLayerCount;
}
