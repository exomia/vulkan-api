#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Ggp.VkGgpStreamDescriptorSurface;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Ggp;

/// <summary>
///     VK_GGP_stream_descriptor_surface - instance extension (nr. 50) - author 'GGP' [platform 'ggp' | contact
///     'Jean-Francois Roy @jfroy']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GGP_stream_descriptor_surface.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GGP_stream_descriptor_surface.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_surface")]
public static unsafe class VkGgpStreamDescriptorSurface
{
    /// <summary> The spec version. </summary>
    public const uint VK_GGP_STREAM_DESCRIPTOR_SURFACE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME = "VK_GGP_stream_descriptor_surface";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u475f\u5047\u535f\u5254\u4145\u5f4d\u4544\u4353\u4952\u5450\u524f\u535f\u5255\u4146\u4543\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCreateStreamDescriptorSurfaceGGP - Create a slink:VkSurfaceKHR object for a Google Games Platform stream -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateStreamDescriptorSurfaceGGP.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateStreamDescriptorSurfaceGGP.html
    ///     </a>
    /// </summary>
    /// <param name="instance">instance is the instance to associate with the surface.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkStreamDescriptorSurfaceCreateInfoGGP structure containing
    ///     parameters that affect the creation of the surface object.
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
        VkStreamDescriptorSurfaceCreateInfoGGP* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkSurfaceKHR* /*pSurface*/,
        VkResult> vkCreateStreamDescriptorSurfaceGGP = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>* pvkCreateStreamDescriptorSurfaceGGP =
                   &vkCreateStreamDescriptorSurfaceGGP)
        {
            *pvkCreateStreamDescriptorSurfaceGGP = (delegate*<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u7243\u6165\u6574\u7453\u6572\u6d61\u6544\u6373\u6972\u7470\u726f\u7553\u6672\u6361\u4765\u5047\u0000");
        }
    }
}