#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvCooperativeMatrix;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_cooperative_matrix - device extension (nr. 250) - author 'NV' [platform '' | contact 'Jeff Bolz @jeffbolznv']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_cooperative_matrix.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_cooperative_matrix.html </a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
public static unsafe class VkNvCooperativeMatrix
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME = "VK_NV_cooperative_matrix";

    /// <summary> An UTF8 null terminated version of <see cref="VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4f43\u504f\u5245\u5441\u5649\u5f45\u414d\u5254\u5849\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetPhysicalDeviceCooperativeMatrixPropertiesNV - Returns properties describing what cooperative matrix types are supported -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixPropertiesNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixPropertiesNV.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice"> physicalDevice is the physical device. </param>
    /// <param name="pPropertyCount"> pPropertyCount is a pointer to an integer related to the number of cooperative matrix properties available or queried. </param>
    /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of VkCooperativeMatrixPropertiesNV structures. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS,VK_INCOMPLETE </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        uint* /*pPropertyCount*/,
        VkCooperativeMatrixPropertiesNV* /*pProperties*/,
        VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult>* pvkGetPhysicalDeviceCooperativeMatrixPropertiesNV = &vkGetPhysicalDeviceCooperativeMatrixPropertiesNV)
        {
            *pvkGetPhysicalDeviceCooperativeMatrixPropertiesNV = (delegate*<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4365\u6f6f\u6570\u6172\u6974\u6576\u614d\u7274\u7869\u7250\u706f\u7265\u6974\u7365\u564e\u0000");
        }
    }
}