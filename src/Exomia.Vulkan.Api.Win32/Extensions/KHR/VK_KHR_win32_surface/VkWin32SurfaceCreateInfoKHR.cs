// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary> VkWin32SurfaceCreateInfoKHR - Structure specifying parameters of a newly created Win32 surface object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWin32SurfaceCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWin32SurfaceCreateInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWin32SurfaceCreateInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkWin32SurfaceCreateFlagsKHR flags;
    /// <summary>hinstance is the Win32 HINSTANCE for the window to associate the surface with.</summary>
    public HINSTANCE hinstance;
    /// <summary>hwnd is the Win32 HWND for the window to associate the surface with.</summary>
    public HWND hwnd;
}
