// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary> VkImportMemoryBufferCollectionFUCHSIA - Structure to specify the Sysmem buffer to import - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMemoryBufferCollectionFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMemoryBufferCollectionFUCHSIA.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkMemoryAllocateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkMemoryAllocateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryBufferCollectionFUCHSIA {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA;

    /// <summary>sType is the type of this structure</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure</summary>
    public void* pNext;
    /// <summary>collection is the VkBufferCollectionFUCHSIA handle</summary>
    public VkBufferCollectionFUCHSIA collection;
    /// <summary>index the index of the buffer to import from collection</summary>
    public uint index;
}
