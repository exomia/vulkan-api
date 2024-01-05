#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrBindMemory2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_bind_memory2 - device extension (nr. 158) - author 'KHR' [platform '' | contact 'Tobias Hector @tobski']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_bind_memory2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_bind_memory2.html</a>
/// </summary>
[VkDeviceExt]
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_bind_memory2.html#_deprecation_state")]
public static unsafe class VkKhrBindMemory2
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_BIND_MEMORY_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_BIND_MEMORY_2_EXTENSION_NAME = "VK_KHR_bind_memory2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_BIND_MEMORY_2_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_BIND_MEMORY_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_BIND_MEMORY_2_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u425f\u4e49\u5f44\u454d\u4f4d\u5952\u325f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// vkBindBufferMemory2KHR alias for vkBindBufferMemory2
    /// <summary>
    ///     vkBindBufferMemory2 - Bind device memory to buffer objects -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        uint /*bindInfoCount*/,
        VkBindBufferMemoryInfo* /*pBindInfos*/,
        VkResult> vkBindBufferMemory2KHR = null;

    /// vkBindImageMemory2KHR alias for vkBindImageMemory2
    /// <summary>
    ///     vkBindImageMemory2 - Bind device memory to image objects -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        uint /*bindInfoCount*/,
        VkBindImageMemoryInfo* /*pBindInfos*/,
        VkResult> vkBindImageMemory2KHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkBindBufferMemory2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkBindImageMemory2KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult>* pvkBindBufferMemory2KHR = &vkBindBufferMemory2KHR)
        {
            *pvkBindBufferMemory2KHR = (delegate*<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult>)GetVkFunction(device, "\u6b76\u6942\u646e\u7542\u6666\u7265\u654d\u6f6d\u7972\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkDevice, uint, VkBindImageMemoryInfo*, VkResult>* pvkBindImageMemory2KHR = &vkBindImageMemory2KHR)
        {
            *pvkBindImageMemory2KHR = (delegate*<VkDevice, uint, VkBindImageMemoryInfo*, VkResult>)GetVkFunction(device, "\u6b76\u6942\u646e\u6d49\u6761\u4d65\u6d65\u726f\u3279\u484b\u0052");
        }
    }
}