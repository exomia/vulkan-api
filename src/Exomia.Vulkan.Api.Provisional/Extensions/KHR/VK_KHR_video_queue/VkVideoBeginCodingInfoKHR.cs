// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoBeginCodingInfoKHR - Structure specifying parameters of decode starts - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoBeginCodingInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoBeginCodingInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoBeginCodingInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkVideoBeginCodingFlagsKHR flags;
    /// <summary>codecQualityPreset is a bitmask of VkVideoCodingQualityPresetFlagBitsKHR specifying the Video Decode or Encode quality preset.</summary>
    public VkVideoCodingQualityPresetFlagsKHR codecQualityPreset;
    /// <summary>videoSession is the video session object to be bound for the processing of the video commands.</summary>
    public VkVideoSessionKHR videoSession;
    /// <summary>videoSessionParameters is VK_NULL_HANDLE or a handle of a VkVideoSessionParametersKHR object to be used for the processing of the video commands. If VK_NULL_HANDLE, then no video session parameters apply to this command buffer context.</summary>
    public VkVideoSessionParametersKHR videoSessionParameters;
    /// <summary>referenceSlotCount is the number of reference slot entries provided in pReferenceSlots.</summary>
    public uint referenceSlotCount;
    /// <summary>pReferenceSlots is a pointer to an array of VkVideoReferenceSlotKHR structures specifying reference slots, used within the video command context between this vkCmdBeginVideoCodingKHR command and the vkCmdEndVideoCodingKHR commmand that follows. Each reference slot provides a slot index and the VkVideoPictureResourceKHR specifying the reference picture resource bound to this slot index. A slot index must not appear more than once in pReferenceSlots in a given command.</summary>
    public VkVideoReferenceSlotKHR* pReferenceSlots;
}
