#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Metal.VkExtMetalObjects;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Metal;

/// <summary>
///     VK_EXT_metal_objects - device extension (nr. 312) - author 'EXT' [platform 'metal' | contact 'Bill Hollings
///     @billhollings']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_metal_objects.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_metal_objects.html</a>
/// </summary>
[VkDeviceExt]
public static unsafe class VkExtMetalObjects
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_METAL_OBJECTS_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_METAL_OBJECTS_EXTENSION_NAME = "VK_EXT_metal_objects";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_METAL_OBJECTS_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_METAL_OBJECTS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_METAL_OBJECTS_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u4d5f\u5445\u4c41\u4f5f\u4a42\u4345\u5354\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkExportMetalObjectsEXT - Export Metal objects from the corresponding Vulkan objects -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkExportMetalObjectsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkExportMetalObjectsEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device that created the Vulkan objects.</param>
    /// <param name="pMetalObjectsInfo">
    ///     pMetalObjectsInfo is a pointer to a VkExportMetalObjectsInfoEXT structure whose pNext
    ///     chain contains structures, each identifying a Vulkan object and providing a pointer through which the Metal object
    ///     will be returned.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkExportMetalObjectsInfoEXT* /*pMetalObjectsInfo*/,
        void> vkExportMetalObjectsEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkExportMetalObjectsEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkExportMetalObjectsInfoEXT*, void>* pvkExportMetalObjectsEXT = &vkExportMetalObjectsEXT)
        {
            *pvkExportMetalObjectsEXT = (delegate*<VkDevice, VkExportMetalObjectsInfoEXT*, void>)GetVkFunction(device, "\u6b76\u7845\u6f70\u7472\u654d\u6174\u4f6c\u6a62\u6365\u7374\u5845\u0054");
        }
    }
}