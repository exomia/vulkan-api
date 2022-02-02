// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH264RateControlLayerInfoEXT - Structure describing H.264 per-layer rate control parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlLayerInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlLayerInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoEncodeRateControlLayerInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoEncodeRateControlLayerInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264RateControlLayerInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>temporalLayerId specifies the H.264 temporal layer ID of the video coding layer that settings provided in this structure and its parent VkVideoEncodeRateControlLayerInfoKHR structure apply to.</summary>
    public byte temporalLayerId;
    /// <summary>useInitialRcQp indicates whether the values within initialRcQp should be used by the implementation.</summary>
    public VkBool32 useInitialRcQp;
    /// <summary>initialRcQp provides the QP values for each picture type, to be used in rate control calculations at the start of video encode operations on a newly-created video session, or immediately after a session reset. These values are ignored when VkVideoEncodeRateControlInfoKHR::rateControlMode is VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR.</summary>
    public VkVideoEncodeH264QpEXT initialRcQp;
    /// <summary>useMinQp indicates whether the values within minQp should be used by the implementation. When it is set to VK_FALSE, the implementation ignores the values in minQp and chooses suitable values.</summary>
    public VkBool32 useMinQp;
    /// <summary>minQp provides the lower bound on the QP values for each picture type, to be used in rate control calculations.</summary>
    public VkVideoEncodeH264QpEXT minQp;
    /// <summary>useMaxQp indicates whether the values within maxQp should be used by the implementation. When it is set to VK_FALSE, the implementation ignores the values in maxQp and chooses suitable values.</summary>
    public VkBool32 useMaxQp;
    /// <summary>maxQp provides the upper bound on the QP values for each picture type, to be used in rate control calculations.</summary>
    public VkVideoEncodeH264QpEXT maxQp;
    /// <summary>useMaxFrameSize indicates whether the values within maxFrameSize should be used by the implementation.</summary>
    public VkBool32 useMaxFrameSize;
    /// <summary>maxFrameSize provides the upper bound on the encoded frame size for each picture type. The implementation does not guarantee the encoded frame sizes will be within the specified limits, however these limits may be used as a guide in rate control calculations. If enabled and not set properly, the maxQp limit may prevent the implementation from respecting the maxFrameSize limit.</summary>
    public VkVideoEncodeH264FrameSizeEXT maxFrameSize;
}
