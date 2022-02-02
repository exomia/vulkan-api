// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEndCodingInfoKHR - Structure specifying the end of decode encode commands sequence - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEndCodingInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEndCodingInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEndCodingInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkVideoEndCodingFlagsKHR flags;
}
