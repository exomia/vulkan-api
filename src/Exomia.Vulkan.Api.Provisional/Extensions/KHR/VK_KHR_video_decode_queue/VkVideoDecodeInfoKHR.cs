// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeInfoKHR - Structure specifying parameters of decoding a frame - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure. All the codec specific structures related to each frame(picture parameters, quantization matrix, etc.) must be chained here and pass to decode session with the function call vkCmdDecodeVideoKHR.</summary>
    public void* pNext;
    /// <summary>flags is a bitmask of VkVideoDecodeFlagBitsKHR specifying decode flags, reserved for future versions of this specification.</summary>
    public VkVideoDecodeFlagsKHR flags;
    /// <summary>codedOffset is the coded offset of the decode operations. The purpose of this field is interpreted based on the codec extension. When decoding content in H.264 field mode, the codedOffsetspecifies the line or picture field&#8217;s offset within the image.</summary>
    public VkOffset2D codedOffset;
    /// <summary>codedExtent is the coded size of the decode operations.</summary>
    public VkExtent2D codedExtent;
    /// <summary>srcBuffer is the source buffer that holds the encoded bitstream.</summary>
    public VkBuffer srcBuffer;
    /// <summary>srcBufferOffset is the buffer offset where the valid encoded bitstream starts in srcBuffer. It must meet the alignment requirement minBitstreamBufferOffsetAlignment within VkVideoCapabilitiesKHR queried with the vkGetPhysicalDeviceVideoCapabilitiesKHR function.</summary>
    public VkDeviceSize srcBufferOffset;
    /// <summary>srcBufferRange is the size of the srcBuffer with valid encoded bitstream, starting from srcBufferOffset. It must meet the alignment requirement minBitstreamBufferSizeAlignment within VkVideoCapabilitiesKHR queried with the vkGetPhysicalDeviceVideoCapabilitiesKHR function.</summary>
    public VkDeviceSize srcBufferRange;
    /// <summary>dstPictureResource is the destination Decoded Output Picture Resource.</summary>
    public VkVideoPictureResourceKHR dstPictureResource;
    /// <summary>pSetupReferenceSlot is NULL or a pointer to a VkVideoReferenceSlotKHR structure used for generating a DPB reference slot and Picture Resource. pSetupReferenceSlot-&gt;slotIndex specifies the slot index number to use as a target for producing the DPB data. slotIndex must reference a valid entry as specified in VkVideoBeginCodingInfoKHR via the pReferenceSlots within the vkCmdBeginVideoCodingKHR command that established the Vulkan Video Decode Context for this command.</summary>
    public VkVideoReferenceSlotKHR* pSetupReferenceSlot;
    /// <summary>referenceSlotCount is the number of the DPB Reference Pictures that will be used when this decoding operation is executing.</summary>
    public uint referenceSlotCount;
    /// <summary>pReferenceSlots is a pointer to an array of VkVideoReferenceSlotKHR structures specifying the DPB Reference pictures that will be used when this decoding operation is executing.</summary>
    public VkVideoReferenceSlotKHR* pReferenceSlots;
}
