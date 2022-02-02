global using static Exomia.Vulkan.Api.Directfb.VkExtDirectfbSurface;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Directfb;

/// <summary>
///    VK_EXT_directfb_surface - instance extension (nr. 347) - author 'EXT' [platform 'directfb' | contact 'Nicolas Caramelli @caramelli']<br/>
///    <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_directfb_surface.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_directfb_surface.html</a>
/// </summary>
[VkRequires("VK_KHR_surface")]
public static unsafe partial class VkExtDirectfbSurface
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DIRECTFB_SURFACE_SPEC_VERSION = 1;
    /// <summary> The extension name. </summary>
    public const string VK_EXT_DIRECTFB_SURFACE_EXTENSION_NAME = "VK_EXT_directfb_surface";
    /// <summary> An UTF8 null terminated version of <see cref="VK_EXT_DIRECTFB_SURFACE_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br/>
    ///     <br/>
    ///     fixed(char* ptr = VK_EXT_DIRECTFB_SURFACE_EXTENSION_NAME_UTF8_NT) {<br/>
    ///         sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DIRECTFB_SURFACE_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u445f\u5249\u4345\u4654\u5f42\u5553\u4652\u4341\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary> vkCreateDirectFBSurfaceEXT - Create a slink:VkSurfaceKHR object for a DirectFB surface - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDirectFBSurfaceEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDirectFBSurfaceEXT.html</a> </summary>
    /// <param name="instance">instance is the instance to associate the surface with.</param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to a VkDirectFBSurfaceCreateInfoEXTstructure containing parameters affecting the creation of the surface object.</param>
    /// <param name="pAllocator">pAllocator is the allocator used for host memory allocated for the surface object when there is no more specific allocator available (see Memory Allocation).</param>
    /// <param name="pSurface">pSurface is a pointer to a VkSurfaceKHR handle in which the created surface object is returned.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkInstance /*instance*/, 
        VkDirectFBSurfaceCreateInfoEXT* /*pCreateInfo*/, 
        VkAllocationCallbacks* /*pAllocator*/, 
        VkSurfaceKHR* /*pSurface*/, 
        VkResult> vkCreateDirectFBSurfaceEXT = null;

    /// <summary> vkGetPhysicalDeviceDirectFBPresentationSupportEXT - Query physical device for presentation with DirectFB - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDirectFBPresentationSupportEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDirectFBPresentationSupportEXT.html</a> </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device.</param>
    /// <param name="queueFamilyIndex">queueFamilyIndex is the queue family index.</param>
    /// <param name="dfb">dfb is a pointer to the IDirectFB main interface of DirectFB.</param>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/, 
        uint /*queueFamilyIndex*/, 
        IDirectFB* /*dfb*/, 
        VkBool32> vkGetPhysicalDeviceDirectFBPresentationSupportEXT = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance) {
        fixed(delegate*<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>* pvkCreateDirectFBSurfaceEXT = &vkCreateDirectFBSurfaceEXT) 
        {
            *pvkCreateDirectFBSurfaceEXT = (delegate*<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(instance, "\u6b76\u7243\u6165\u6574\u6944\u6572\u7463\u4246\u7553\u6672\u6361\u4565\u5458\u0000");
        }
        fixed(delegate*<VkPhysicalDevice, uint, IDirectFB*, VkBool32>* pvkGetPhysicalDeviceDirectFBPresentationSupportEXT = &vkGetPhysicalDeviceDirectFBPresentationSupportEXT) 
        {
            *pvkGetPhysicalDeviceDirectFBPresentationSupportEXT = (delegate*<VkPhysicalDevice, uint, IDirectFB*, VkBool32>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4465\u7269\u6365\u4674\u5042\u6572\u6573\u746e\u7461\u6f69\u536e\u7075\u6f70\u7472\u5845\u0054");
        }
    }
}
