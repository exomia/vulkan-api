// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH264DpbSlotInfoEXT - Structure specifies H.264 encode DPB picture information - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264DpbSlotInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264DpbSlotInfoEXT.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264DpbSlotInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>slotIndex is the slot index for this picture. slotIndex must match the slotIndex in pSetupReferenceSlot of VkVideoEncodeInfoKHR in the command used to encode the corresponding picture.</summary>
    public int8_t slotIndex;
    /// <summary>pStdPictureInfo is a pointer to a StdVideoEncodeH264PictureInfo structure specifying codec standard specific syntax/information associated with this picture from the H.264 specification.</summary>
    public StdVideoEncodeH264PictureInfo* pStdPictureInfo;
}
