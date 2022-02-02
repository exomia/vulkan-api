// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary> VkMemoryGetWin32HandleInfoKHR - Structure describing a Win32 handle semaphore export operation - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryGetWin32HandleInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryGetWin32HandleInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetWin32HandleInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>memory is the memory object from which the handle will be exported.</summary>
    public VkDeviceMemory memory;
    /// <summary>handleType is a VkExternalMemoryHandleTypeFlagBits value specifying the type of handle requested.</summary>
    public VkExternalMemoryHandleTypeFlagBits handleType;
}
