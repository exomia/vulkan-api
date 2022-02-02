// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Android;

/// <summary> VkMemoryGetAndroidHardwareBufferInfoANDROID - Structure describing an Android hardware buffer memory export operation - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryGetAndroidHardwareBufferInfoANDROID.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryGetAndroidHardwareBufferInfoANDROID.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>memory is the memory object from which the Android hardware buffer will be exported.</summary>
    public VkDeviceMemory memory;
}
