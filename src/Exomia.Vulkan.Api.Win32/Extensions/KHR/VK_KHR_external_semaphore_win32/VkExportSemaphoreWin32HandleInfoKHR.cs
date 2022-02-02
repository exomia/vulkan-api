// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary> VkExportSemaphoreWin32HandleInfoKHR - Structure specifying additional attributes of Windows handles exported from a semaphore - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportSemaphoreWin32HandleInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportSemaphoreWin32HandleInfoKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkSemaphoreCreateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkSemaphoreCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportSemaphoreWin32HandleInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>pAttributes is a pointer to a Windows SECURITY_ATTRIBUTESstructure specifying security attributes of the handle.</summary>
    public SECURITY_ATTRIBUTES* pAttributes;
    /// <summary>dwAccess is a DWORD specifying access rights of the handle.</summary>
    public DWORD dwAccess;
    /// <summary>name is a null-terminated UTF-16 string to associate with the underlying synchronization primitive referenced by NT handles exported from the created semaphore.</summary>
    public LPCWSTR name;
}
