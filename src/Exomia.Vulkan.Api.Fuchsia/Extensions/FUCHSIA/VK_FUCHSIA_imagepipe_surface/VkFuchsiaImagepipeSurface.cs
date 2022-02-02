global using static Exomia.Vulkan.Api.Fuchsia.VkFuchsiaImagepipeSurface;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///    VK_FUCHSIA_imagepipe_surface - instance extension (nr. 215) - author 'FUCHSIA' [platform 'fuchsia' | contact 'Craig Stout @cdotstout']<br/>
///    <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_imagepipe_surface.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_imagepipe_surface.html</a>
/// </summary>
[VkRequires("VK_KHR_surface")]
public static unsafe partial class VkFuchsiaImagepipeSurface
{
    /// <summary> The spec version. </summary>
    public const uint VK_FUCHSIA_IMAGEPIPE_SURFACE_SPEC_VERSION = 1;
    /// <summary> The extension name. </summary>
    public const string VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME = "VK_FUCHSIA_imagepipe_surface";
    /// <summary> An UTF8 null terminated version of <see cref="VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br/>
    ///     <br/>
    ///     fixed(char* ptr = VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME_UTF8_NT) {<br/>
    ///         sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME_UTF8_NT = "\u4b56\u465f\u4355\u5348\u4149\u495f\u414d\u4547\u4950\u4550\u535f\u5255\u4146\u4543\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary> vkCreateImagePipeSurfaceFUCHSIA - Create a slink:VkSurfaceKHR object for a Fuchsia ImagePipe - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateImagePipeSurfaceFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateImagePipeSurfaceFUCHSIA.html</a> </summary>
    /// <param name="instance">instance is the instance to associate with the surface.</param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to a VkImagePipeSurfaceCreateInfoFUCHSIA structure containing parameters affecting the creation of the surface object.</param>
    /// <param name="pAllocator">pAllocator is the allocator used for host memory allocated for the surface object when there is no more specific allocator available (see Memory Allocation).</param>
    /// <param name="pSurface">pSurface is a pointer to a VkSurfaceKHR handle in which the created surface object is returned.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkInstance /*instance*/, 
        VkImagePipeSurfaceCreateInfoFUCHSIA* /*pCreateInfo*/, 
        VkAllocationCallbacks* /*pAllocator*/, 
        VkSurfaceKHR* /*pSurface*/, 
        VkResult> vkCreateImagePipeSurfaceFUCHSIA = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance) {
        fixed(delegate*<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>* pvkCreateImagePipeSurfaceFUCHSIA = &vkCreateImagePipeSurfaceFUCHSIA) 
        {
            *pvkCreateImagePipeSurfaceFUCHSIA = (delegate*<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(instance, "\u6b76\u7243\u6165\u6574\u6d49\u6761\u5065\u7069\u5365\u7275\u6166\u6563\u5546\u4843\u4953\u0041");
        }
    }
}
