// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Xlib;

/// <summary> VkXlibSurfaceCreateInfoKHR - Structure specifying parameters of a newly created Xlib surface object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkXlibSurfaceCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkXlibSurfaceCreateInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkXlibSurfaceCreateInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkXlibSurfaceCreateFlagsKHR flags;
    /// <summary>dpy is a pointer to an Xlib Display connection to the X server.</summary>
    public Display* dpy;
    /// <summary>window is an Xlib Window to associate the surface with.</summary>
    public Window window;
}
