// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Wayland;

/// <summary> VkWaylandSurfaceCreateInfoKHR - Structure specifying parameters of a newly created Wayland surface object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWaylandSurfaceCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWaylandSurfaceCreateInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWaylandSurfaceCreateInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkWaylandSurfaceCreateFlagsKHR flags;
    /// <summary>display and surface are pointers to the Wayland wl_display and wl_surface to associate the surface with.</summary>
    public wl_display* display;
    /// <summary>display and surface are pointers to the Wayland wl_display and wl_surface to associate the surface with.</summary>
    public wl_surface* surface;
}
