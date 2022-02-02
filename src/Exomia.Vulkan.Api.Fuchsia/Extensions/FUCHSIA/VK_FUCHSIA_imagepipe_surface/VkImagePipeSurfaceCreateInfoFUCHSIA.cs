// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary> VkImagePipeSurfaceCreateInfoFUCHSIA - Structure specifying parameters of a newly created ImagePipe surface object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImagePipeSurfaceCreateInfoFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImagePipeSurfaceCreateInfoFUCHSIA.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImagePipeSurfaceCreateInfoFUCHSIA {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkImagePipeSurfaceCreateFlagsFUCHSIA flags;
    /// <summary>imagePipeHandle is a zx_handle_t referring to the ImagePipe to associate with the surface.</summary>
    public zx_handle_t imagePipeHandle;
}
