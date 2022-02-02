// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary> VkFenceGetWin32HandleInfoKHR - Structure describing a Win32 handle fence export operation - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFenceGetWin32HandleInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFenceGetWin32HandleInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceGetWin32HandleInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>fence is the fence from which state will be exported.</summary>
    public VkFence fence;
    /// <summary>handleType is a VkExternalFenceHandleTypeFlagBits value specifying the type of handle requested.</summary>
    public VkExternalFenceHandleTypeFlagBits handleType;
}
