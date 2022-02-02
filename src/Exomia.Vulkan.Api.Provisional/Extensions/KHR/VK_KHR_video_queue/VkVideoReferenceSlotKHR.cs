// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoReferenceSlotKHR - Structure specifying the reference picture slot - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoReferenceSlotKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoReferenceSlotKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoReferenceSlotKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>slotIndex is the unique reference slot index used for the encode or decode operation.</summary>
    public int8_t slotIndex;
    /// <summary>pPictureResource is a pointer to a VkVideoPictureResourceKHRstructure describing the picture resource bound to this slot index.</summary>
    public VkVideoPictureResourceKHR* pPictureResource;
}
