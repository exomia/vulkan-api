// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary> VkD3D12FenceSubmitInfoKHR - Structure specifying values for Direct3D 12 fence-backed semaphores - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkD3D12FenceSubmitInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkD3D12FenceSubmitInfoKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkSubmitInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkSubmitInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkD3D12FenceSubmitInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>waitSemaphoreValuesCount is the number of semaphore wait values specified in pWaitSemaphoreValues.</summary>
    public uint waitSemaphoreValuesCount;
    /// <summary>pWaitSemaphoreValues is a pointer to an array of waitSemaphoreValuesCount values for the corresponding semaphores in VkSubmitInfo::pWaitSemaphores to wait for.</summary>
    public ulong* pWaitSemaphoreValues;
    /// <summary>signalSemaphoreValuesCount is the number of semaphore signal values specified in pSignalSemaphoreValues.</summary>
    public uint signalSemaphoreValuesCount;
    /// <summary>pSignalSemaphoreValues is a pointer to an array of signalSemaphoreValuesCount values for the corresponding semaphores in VkSubmitInfo::pSignalSemaphores to set when signaled.</summary>
    public ulong* pSignalSemaphoreValues;
}
