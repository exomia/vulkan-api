// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoPictureResourceKHR - Structure specifying the picture resources - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoPictureResourceKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoPictureResourceKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoPictureResourceKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>codedOffset is the offset to be used for the picture resource.</summary>
    public VkOffset2D codedOffset;
    /// <summary>codedExtent is the extent to be used for the picture resource.</summary>
    public VkExtent2D codedExtent;
    /// <summary>baseArrayLayer is the first array layer to be accessed for the Decode or Encode Operations.</summary>
    public uint baseArrayLayer;
    /// <summary>imageViewBinding is a VkImageView image view representing this picture resource.</summary>
    public VkImageView imageViewBinding;
}
