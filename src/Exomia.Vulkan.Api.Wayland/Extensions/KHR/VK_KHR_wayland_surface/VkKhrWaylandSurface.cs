global using static Exomia.Vulkan.Api.Wayland.VkKhrWaylandSurface;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Wayland;

/// <summary>
///    VK_KHR_wayland_surface - instance extension (nr. 7) - author 'KHR' [platform 'wayland' | contact 'Jesse Hall @critsec,Ian Elliott @ianelliottus']<br/>
///    <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_wayland_surface.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_wayland_surface.html</a>
/// </summary>
[VkRequires("VK_KHR_surface")]
public static unsafe partial class VkKhrWaylandSurface
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_WAYLAND_SURFACE_SPEC_VERSION = 6;
    /// <summary> The extension name. </summary>
    public const string VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME = "VK_KHR_wayland_surface";
    /// <summary> An UTF8 null terminated version of <see cref="VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br/>
    ///     <br/>
    ///     fixed(char* ptr = VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME_UTF8_NT) {<br/>
    ///         sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u575f\u5941\u414c\u444e\u535f\u5255\u4146\u4543\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary> vkCreateWaylandSurfaceKHR - Create a slink:VkSurfaceKHR object for a Wayland window - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateWaylandSurfaceKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateWaylandSurfaceKHR.html</a> </summary>
    /// <param name="instance">instance is the instance to associate the surface with.</param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to a VkWaylandSurfaceCreateInfoKHRstructure containing parameters affecting the creation of the surface object.</param>
    /// <param name="pAllocator">pAllocator is the allocator used for host memory allocated for the surface object when there is no more specific allocator available (see Memory Allocation).</param>
    /// <param name="pSurface">pSurface is a pointer to a VkSurfaceKHR handle in which the created surface object is returned.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkInstance /*instance*/, 
        VkWaylandSurfaceCreateInfoKHR* /*pCreateInfo*/, 
        VkAllocationCallbacks* /*pAllocator*/, 
        VkSurfaceKHR* /*pSurface*/, 
        VkResult> vkCreateWaylandSurfaceKHR = null;

    /// <summary> vkGetPhysicalDeviceWaylandPresentationSupportKHR - Query physical device for presentation to Wayland - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceWaylandPresentationSupportKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceWaylandPresentationSupportKHR.html</a> </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device.</param>
    /// <param name="queueFamilyIndex">queueFamilyIndex is the queue family index.</param>
    /// <param name="display">display is a pointer to the wl_display associated with a Wayland compositor.</param>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/, 
        uint /*queueFamilyIndex*/, 
        wl_display* /*display*/, 
        VkBool32> vkGetPhysicalDeviceWaylandPresentationSupportKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance) {
        fixed(delegate*<VkInstance, VkWaylandSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>* pvkCreateWaylandSurfaceKHR = &vkCreateWaylandSurfaceKHR) 
        {
            *pvkCreateWaylandSurfaceKHR = (delegate*<VkInstance, VkWaylandSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(instance, "\u6b76\u7243\u6165\u6574\u6157\u6c79\u6e61\u5364\u7275\u6166\u6563\u484b\u0052");
        }
        fixed(delegate*<VkPhysicalDevice, uint, wl_display*, VkBool32>* pvkGetPhysicalDeviceWaylandPresentationSupportKHR = &vkGetPhysicalDeviceWaylandPresentationSupportKHR) 
        {
            *pvkGetPhysicalDeviceWaylandPresentationSupportKHR = (delegate*<VkPhysicalDevice, uint, wl_display*, VkBool32>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5765\u7961\u616c\u646e\u7250\u7365\u6e65\u6174\u6974\u6e6f\u7553\u7070\u726f\u4b74\u5248\u0000");
        }
    }
}
