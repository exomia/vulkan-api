// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoSessionCreateInfoKHR - Structure specifying parameters of a newly created video decode session - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionCreateInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>queueFamilyIndex is the queue family of the created video session.</summary>
    public uint queueFamilyIndex;
    /// <summary>flags is a bitmask of VkVideoSessionCreateFlagBitsKHRspecifying creation flags.</summary>
    public VkVideoSessionCreateFlagsKHR flags;
    /// <summary>pVideoProfile is a pointer to a VkVideoProfileKHR structure.</summary>
    public VkVideoProfileKHR* pVideoProfile;
    /// <summary>pictureFormat is the format of the image views representing decoded Output or encoded Input pictures.</summary>
    public VkFormat pictureFormat;
    /// <summary>maxCodedExtent is the maximum width and height of the coded pictures that this instance will be able to support.</summary>
    public VkExtent2D maxCodedExtent;
    /// <summary>referencePicturesFormat is the format of the DPB image views representing the Reference Pictures.</summary>
    public VkFormat referencePicturesFormat;
    /// <summary>maxReferencePicturesSlotsCount is the maximum number of DPB Slots that can be activated with associated Video Picture Resources for the created video session.</summary>
    public uint maxReferencePicturesSlotsCount;
    /// <summary>maxReferencePicturesActiveCount is the maximum number of active DPB Slots that can be used as Dpb or Reconstructed Reference Pictures within a single decode or encode operation for the created video session.</summary>
    public uint maxReferencePicturesActiveCount;
}
