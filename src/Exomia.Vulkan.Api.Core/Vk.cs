#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using System;
global using System.Security;
global using System.Runtime.InteropServices;
global using System.Runtime.CompilerServices;
global using Exomia.Vulkan.Api.Core.Attributes;
global using static Exomia.Vulkan.Api.Core.Vk;
global using static Exomia.Vulkan.Api.Core.VkStructureType;

[module: SkipLocalsInit]

namespace Exomia.Vulkan.Api.Core;

/// <content> vk.cs </content>
public static partial class Vk
{
    private const string VK_IMPORT = "vulkan-1";

    /// <summary>
    ///     VK_MAX_PHYSICAL_DEVICE_NAME_SIZE - Length of a physical device name string -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_PHYSICAL_DEVICE_NAME_SIZE.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_PHYSICAL_DEVICE_NAME_SIZE.html
    ///     </a>
    /// </summary>
    public const uint VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256;

    /// <summary>
    ///     VK_UUID_SIZE - Length of a universally unique device or driver build identifier -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_UUID_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_UUID_SIZE.html</a>
    /// </summary>
    public const uint VK_UUID_SIZE = 16;

    /// <summary>
    ///     VK_LUID_SIZE_KHR - Length of a universally unique device or driver build identifier -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE_KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE_KHR.html</a>
    /// </summary>
    public const uint VK_LUID_SIZE_KHR = VK_LUID_SIZE;

    /// <summary>
    ///     VK_MAX_EXTENSION_NAME_SIZE - Maximum length of a layer of extension name string -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_EXTENSION_NAME_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_EXTENSION_NAME_SIZE.html</a>
    /// </summary>
    public const uint VK_MAX_EXTENSION_NAME_SIZE = 256;

    /// <summary>
    ///     VK_MAX_DESCRIPTION_SIZE - Length of a driver name string -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DESCRIPTION_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DESCRIPTION_SIZE.html</a>
    /// </summary>
    public const uint VK_MAX_DESCRIPTION_SIZE = 256;

    /// <summary>
    ///     VK_MAX_MEMORY_TYPES - Length of an array of memory types -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_TYPES.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_TYPES.html</a>
    /// </summary>
    public const uint VK_MAX_MEMORY_TYPES = 32;

    /// <summary>
    ///     VK_MAX_MEMORY_HEAPS - Length of an array of memory heaps -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_HEAPS.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_HEAPS.html</a>
    /// </summary>
    public const uint VK_MAX_MEMORY_HEAPS = 16;

    /// <summary> Gets a vk function. </summary>
    /// <param name="vkInstance">           The vk instance. </param>
    /// <param name="vkFunctionNameUTF8NT"> Name of the vk function in an UTF8-NT style. </param>
    /// <returns> The vk function; otherwise throws exception. </returns>
    /// <exception cref="EntryPointNotFoundException"> Thrown when an Entry Point Not Found error condition occurs. </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void* GetVkFunction(VkInstance vkInstance, string vkFunctionNameUTF8NT)
    {
        fixed (char* pVkFunctionName = vkFunctionNameUTF8NT)
        {
            void* addr = vkGetInstanceProcAddr(vkInstance, (byte*)pVkFunctionName);
            if (addr != null) { return addr; }
            throw new EntryPointNotFoundException(new string((sbyte*)pVkFunctionName));
        }
    }

    /// <summary> Gets a vk function. </summary>
    /// <param name="vkDevice">             The vk device. </param>
    /// <param name="vkFunctionNameUTF8NT"> Name of the vk function in an UTF8-NT style. </param>
    /// <returns> The vk function; otherwise throws exception. </returns>
    /// <exception cref="EntryPointNotFoundException"> Thrown when an Entry Point Not Found error condition occurs. </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void* GetVkFunction(VkDevice vkDevice, string vkFunctionNameUTF8NT)
    {
        fixed (char* pVkFunctionName = vkFunctionNameUTF8NT)
        {
            void* addr = vkGetDeviceProcAddr(vkDevice, (byte*)pVkFunctionName);
            if (addr != null) { return addr; }
            throw new EntryPointNotFoundException(new string((sbyte*)pVkFunctionName));
        }
    }
}