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
    private const string VK_IMPORT = "vulkan";

    /// <summary>
    ///     VK_LUID_SIZE_KHR - Length of a universally unique device or driver build identifier -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE_KHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE_KHR.html </a>
    /// </summary>
    public const uint VK_LUID_SIZE_KHR = VK_LUID_SIZE;

    /// <summary> Gets a vk function. </summary>
    /// <param name="vkInstance"> The vk instance. </param>
    /// <param name="vkFunctionNameUtf8Nt"> Name of the vk function in an UTF8-NT style. </param>
    /// <returns> The vk function; otherwise throws exception. </returns>
    /// <exception cref="EntryPointNotFoundException"> Thrown when an Entry Point Not Found error condition occurs. </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe delegate*<void> GetVkFunction(VkInstance vkInstance, string vkFunctionNameUtf8Nt)
    {
        fixed (char* pVkFunctionName = vkFunctionNameUtf8Nt)
        {
            delegate*<void> addr = vkGetInstanceProcAddr(vkInstance, (byte*)pVkFunctionName);
            if (addr != null) { return addr; }
            throw new EntryPointNotFoundException(new string((sbyte*)pVkFunctionName));
        }
    }

    /// <summary> Gets a vk function. </summary>
    /// <param name="vkDevice"> The vk device. </param>
    /// <param name="vkFunctionNameUtf8Nt"> Name of the vk function in an UTF8-NT style. </param>
    /// <returns> The vk function; otherwise throws exception. </returns>
    /// <exception cref="EntryPointNotFoundException"> Thrown when an Entry Point Not Found error condition occurs. </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe delegate*<void> GetVkFunction(VkDevice vkDevice, string vkFunctionNameUtf8Nt)
    {
        fixed (char* pVkFunctionName = vkFunctionNameUtf8Nt)
        {
            delegate*<void> addr = vkGetDeviceProcAddr(vkDevice, (byte*)pVkFunctionName);
            if (addr != null) { return addr; }
            throw new EntryPointNotFoundException(new string((sbyte*)pVkFunctionName));
        }
    }

#pragma warning disable CA2255
    [ModuleInitializer]
#pragma warning restore CA2255

    // ReSharper disable once CognitiveComplexity
    internal static void Initialize()
    {
        NativeLibrary.SetDllImportResolver(
            typeof(Vk).Assembly, (name, assembly, searchPath) =>
            {
                if (!name.Equals(VK_IMPORT, StringComparison.InvariantCultureIgnoreCase))
                {
                    return IntPtr.Zero;
                }

                if (OperatingSystem.IsWindows())
                {
                    return NativeLibrary.Load("vulkan-1.dll", assembly, searchPath);
                }

                if (OperatingSystem.IsLinux())
                {
                    if (NativeLibrary.TryLoad("libvulkan.so.1", assembly, searchPath, out IntPtr handle))
                    {
                        return handle;
                    }
                    return NativeLibrary.Load("libvulkan.so", assembly, searchPath);
                }

                if (OperatingSystem.IsAndroid() || OperatingSystem.IsFreeBSD())
                {
                    return NativeLibrary.Load("libvulkan.so", assembly, searchPath);
                }

                if (OperatingSystem.IsIOS())
                {
                    if (NativeLibrary.TryLoad("libvulkan.dylib.1", assembly, searchPath, out IntPtr handle))
                    {
                        return handle;
                    }
                    return NativeLibrary.Load("libvulkan.dylib", assembly, searchPath);
                }

                throw new NotSupportedException(
                    $"The operating system isn't supported! {RuntimeInformation.RuntimeIdentifier}|{RuntimeInformation.FrameworkDescription}|{RuntimeInformation.OSArchitecture}{RuntimeInformation.OSDescription}|{RuntimeInformation.ProcessArchitecture}");
            });
    }
}