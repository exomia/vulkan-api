#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Vi.VkNnViSurface;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Vi;

/// <summary>
///     VK_NN_vi_surface - instance extension (nr. 63) - author 'NN' [platform 'vi' | contact 'Mathias Heyer
///     gitlab:@mheyer']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NN_vi_surface.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NN_vi_surface.html</a>
/// </summary>
[VkRequires("VK_KHR_surface")]
public static unsafe class VkNnViSurface
{
    /// <summary> The spec version. </summary>
    public const uint VK_NN_VI_SURFACE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NN_VI_SURFACE_EXTENSION_NAME = "VK_NN_vi_surface";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NN_VI_SURFACE_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NN_VI_SURFACE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NN_VI_SURFACE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f4e\u4956\u535f\u5255\u4146\u4543\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCreateViSurfaceNN - Create a slink:VkSurfaceKHR object for a VI layer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateViSurfaceNN.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateViSurfaceNN.html</a>
    /// </summary>
    /// <param name="instance">instance is the instance with which to associate the surface.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkViSurfaceCreateInfoNNstructure containing parameters
    ///     affecting the creation of the surface object.
    /// </param>
    /// <param name="pAllocator">
    ///     pAllocator is the allocator used for host memory allocated for the surface object when there
    ///     is no more specific allocator available (see Memory Allocation).
    /// </param>
    /// <param name="pSurface">pSurface is a pointer to a VkSurfaceKHR handle in which the created surface object is returned.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkInstance /*instance*/,
        VkViSurfaceCreateInfoNN* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkSurfaceKHR* /*pSurface*/,
        VkResult> vkCreateViSurfaceNN = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateViSurfaceNN</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkInstance, VkViSurfaceCreateInfoNN*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>* pvkCreateViSurfaceNN = &vkCreateViSurfaceNN)
        {
            *pvkCreateViSurfaceNN =
                (delegate*<VkInstance, VkViSurfaceCreateInfoNN*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)GetVkFunction(
                    instance, "\u6b76\u7243\u6165\u6574\u6956\u7553\u6672\u6361\u4e65\u004e");
        }
    }
}