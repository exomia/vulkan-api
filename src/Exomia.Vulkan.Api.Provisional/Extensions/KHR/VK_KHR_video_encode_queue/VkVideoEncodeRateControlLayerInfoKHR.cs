// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeRateControlLayerInfoKHR - Structure to set encode per-layer rate control parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlLayerInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlLayerInfoKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoCodingControlInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoCodingControlInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeRateControlLayerInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>averageBitrate is the average bitrate in bits/second. Valid when rate control mode is not VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR.</summary>
    public uint averageBitrate;
    /// <summary>maxBitrate is the peak bitrate in bits/second. Valid when rate control mode is VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR.</summary>
    public uint maxBitrate;
    /// <summary>frameRateNumerator is the numerator of the frame rate. Valid when rate control mode is not VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR.</summary>
    public uint frameRateNumerator;
    /// <summary>frameRateDenominator is the denominator of the frame rate. Valid when rate control mode is not VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR.</summary>
    public uint frameRateDenominator;
    /// <summary>virtualBufferSizeInMs is the leaky bucket model virtual buffer size in milliseconds, with respect to peak bitrate. Valid when rate control mode is not VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR. For example, virtual buffer size is (virtualBufferSizeInMs * maxBitrate / 1000).</summary>
    public uint virtualBufferSizeInMs;
    /// <summary>initialVirtualBufferSizeInMs is the initial occupancy in milliseconds of the virtual buffer in the leaky bucket model. Valid when the rate control mode is not VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR.</summary>
    public uint initialVirtualBufferSizeInMs;
}
