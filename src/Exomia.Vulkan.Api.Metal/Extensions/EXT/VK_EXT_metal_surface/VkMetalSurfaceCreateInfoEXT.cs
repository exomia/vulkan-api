// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Metal;

/// <summary> VkMetalSurfaceCreateInfoEXT - Structure specifying parameters of a newly created Metal surface object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMetalSurfaceCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMetalSurfaceCreateInfoEXT.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMetalSurfaceCreateInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkMetalSurfaceCreateFlagsEXT flags;
    /// <summary>pLayer is a reference to a CAMetalLayer object representing a renderable surface.</summary>
    public CAMetalLayer* pLayer;
}
