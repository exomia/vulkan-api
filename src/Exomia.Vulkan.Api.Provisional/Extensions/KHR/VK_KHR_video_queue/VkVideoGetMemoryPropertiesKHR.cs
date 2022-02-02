// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoGetMemoryPropertiesKHR - Structure specifying video session required memory heap type - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoGetMemoryPropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoGetMemoryPropertiesKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoGetMemoryPropertiesKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_GET_MEMORY_PROPERTIES_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>memoryBindIndex is the memory bind index of the memory heap type described by the information returned in pMemoryRequirements.</summary>
    public uint memoryBindIndex;
    /// <summary>pMemoryRequirements is a pointer to a VkMemoryRequirements2structure in which the requested memory heap requirements for the heap with index memoryBindIndex are returned.</summary>
    public VkMemoryRequirements2* pMemoryRequirements;
}
