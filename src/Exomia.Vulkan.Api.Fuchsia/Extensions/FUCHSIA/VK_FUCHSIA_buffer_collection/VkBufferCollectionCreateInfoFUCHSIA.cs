// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary> VkBufferCollectionCreateInfoFUCHSIA - Structure specifying desired parameters to create the buffer collection - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCollectionCreateInfoFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCollectionCreateInfoFUCHSIA.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionCreateInfoFUCHSIA {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA;

    /// <summary>sType is the type of this structure</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure</summary>
    public void* pNext;
    /// <summary>collectionToken is a zx_handle_t containing the Sysmem client&#8217;s buffer collection token</summary>
    public zx_handle_t collectionToken;
}
