#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkCuLaunchInfoNVX - Stub description of VkCuLaunchInfoNVX -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCuLaunchInfoNVX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCuLaunchInfoNVX.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuLaunchInfoNVX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX;

    /// <summary>
    ///     sType<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public void* pNext;

    /// <summary>
    ///     function<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public VkCuFunctionNVX function;

    /// <summary>
    ///     gridDimX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public uint gridDimX;

    /// <summary>
    ///     gridDimY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public uint gridDimY;

    /// <summary>
    ///     gridDimZ<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public uint gridDimZ;

    /// <summary>
    ///     blockDimX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public uint blockDimX;

    /// <summary>
    ///     blockDimY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public uint blockDimY;

    /// <summary>
    ///     blockDimZ<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public uint blockDimZ;

    /// <summary>
    ///     sharedMemBytes<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public uint sharedMemBytes;

    /// <summary>
    ///     paramCount<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public nuint paramCount;

    /// <summary>
    ///     pParams<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public void** pParams;

    /// <summary>
    ///     extraCount<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public nuint extraCount;

    /// <summary>
    ///     pExtras<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuLaunchInfoNVX</a>
    /// </summary>
    public void** pExtras;
}