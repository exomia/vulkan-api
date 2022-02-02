// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoCapabilitiesKHR - Structure specifying parameters of video capabilities - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilitiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilitiesKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>returnedonly</term><description>true</description></item>
    /// </list></remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoCapabilitiesKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>capabilityFlags is a bitmask of VkVideoCapabilityFlagBitsKHRspecifying capability flags.</summary>
    public VkVideoCapabilityFlagsKHR capabilityFlags;
    /// <summary>minBitstreamBufferOffsetAlignment is the minimum alignment for the input or output bitstream buffer offset.</summary>
    public VkDeviceSize minBitstreamBufferOffsetAlignment;
    /// <summary>minBitstreamBufferSizeAlignment is the minimum alignment for the input or output bitstream buffer size</summary>
    public VkDeviceSize minBitstreamBufferSizeAlignment;
    /// <summary>videoPictureExtentGranularity is the minimum size alignment of the extent with the required padding for the decoded or encoded video images.</summary>
    public VkExtent2D videoPictureExtentGranularity;
    /// <summary>minExtent is the minimum width and height of the decoded or encoded video.</summary>
    public VkExtent2D minExtent;
    /// <summary>maxExtent is the maximum width and height of the decoded or encoded video.</summary>
    public VkExtent2D maxExtent;
    /// <summary>maxReferencePicturesSlotsCount is the maximum number of DPB Slots supported by the implementation for a single video session instance.</summary>
    public uint maxReferencePicturesSlotsCount;
    /// <summary>maxReferencePicturesActiveCount is the maximum slots that can be used as Reference Pictures with a single decode or encode operation.</summary>
    public uint maxReferencePicturesActiveCount;
}
