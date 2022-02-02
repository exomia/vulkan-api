// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary> VkImportMemoryWin32HandleInfoNV - Import Win32 memory created on the same physical device - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMemoryWin32HandleInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMemoryWin32HandleInfoNV.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkMemoryAllocateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkMemoryAllocateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryWin32HandleInfoNV {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>handleType is 0 or a VkExternalMemoryHandleTypeFlagBitsNVvalue specifying the type of memory handle in handle.</summary>
    public VkExternalMemoryHandleTypeFlagsNV handleType;
    /// <summary>handle is a Windows HANDLE referring to the memory.</summary>
    public HANDLE handle;
}
