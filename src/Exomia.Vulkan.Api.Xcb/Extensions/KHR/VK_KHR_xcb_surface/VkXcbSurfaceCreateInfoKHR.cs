// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Xcb;

/// <summary> VkXcbSurfaceCreateInfoKHR - Structure specifying parameters of a newly created Xcb surface object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkXcbSurfaceCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkXcbSurfaceCreateInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkXcbSurfaceCreateInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkXcbSurfaceCreateFlagsKHR flags;
    /// <summary>connection is a pointer to an xcb_connection_t to the X server.</summary>
    public xcb_connection_t* connection;
    /// <summary>window is the xcb_window_t for the X11 window to associate the surface with.</summary>
    public xcb_window_t window;
}
