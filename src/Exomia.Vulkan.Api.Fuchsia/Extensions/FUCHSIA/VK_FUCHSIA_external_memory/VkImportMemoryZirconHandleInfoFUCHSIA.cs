// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary> VkImportMemoryZirconHandleInfoFUCHSIA - Structure specifying import parameters for Zircon handle to external memory - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMemoryZirconHandleInfoFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMemoryZirconHandleInfoFUCHSIA.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkMemoryAllocateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkMemoryAllocateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryZirconHandleInfoFUCHSIA {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>handleType is a VkExternalMemoryHandleTypeFlagBits value specifying the type of handle.</summary>
    public VkExternalMemoryHandleTypeFlagBits handleType;
    /// <summary>handle is a zx_handle_t (Zircon) handle to the external memory.</summary>
    public zx_handle_t handle;
}
