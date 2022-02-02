// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoBindMemoryKHR - Structure specifying device memory heap entry for video session object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoBindMemoryKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoBindMemoryKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoBindMemoryKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_BIND_MEMORY_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>memoryBindIndex is the index of the device memory heap returned in VkVideoGetMemoryPropertiesKHR::memoryBindIndex from vkGetVideoSessionMemoryRequirementsKHR.</summary>
    public uint memoryBindIndex;
    /// <summary>memory is the allocated device memory to be bound to the video session&#8217;s heap with index memoryBindIndex.</summary>
    public VkDeviceMemory memory;
    /// <summary>memoryOffset is the start offset of the region of memorywhich is to be bound.</summary>
    public VkDeviceSize memoryOffset;
    /// <summary>memorySize is the size in bytes of the region of memory, starting from memoryOffset bytes, to be bound.</summary>
    public VkDeviceSize memorySize;
}
