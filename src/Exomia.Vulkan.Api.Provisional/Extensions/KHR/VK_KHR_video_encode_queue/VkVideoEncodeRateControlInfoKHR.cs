// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeRateControlInfoKHR - Structure to set encode stream rate control parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlInfoKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoCodingControlInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoCodingControlInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeRateControlInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is a bitmask of VkVideoEncodeRateControlFlagBitsKHRspecifying encode rate control flags.</summary>
    public VkVideoEncodeRateControlFlagsKHR flags;
    /// <summary>rateControlMode is a VkVideoEncodeRateControlModeFlagBitsKHRvalue specifying the encode stream rate control mode.</summary>
    public VkVideoEncodeRateControlModeFlagBitsKHR rateControlMode;
    /// <summary>layerCount specifies the number of rate control layers in the video encode stream.</summary>
    public byte layerCount;
    /// <summary>pLayerConfigs is a pointer to an array of VkVideoEncodeRateControlLayerInfoKHR structures specifying the rate control configurations of layerCount rate control layers.</summary>
    public VkVideoEncodeRateControlLayerInfoKHR* pLayerConfigs;
}
