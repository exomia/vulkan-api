#region License

// Copyright (c) 2018-2022, exomia
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

    /// <summary> VUID-VkCuLaunchInfoNVX-sType-sType sType must be VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX</summary>
    public VkStructureType sType;

    /// <summary> VUID-VkCuLaunchInfoNVX-pNext-pNext pNext must be NULL</summary>
    public void* pNext;

    /// <summary> VUID-VkCuLaunchInfoNVX-function-parameter function must be a valid VkCuFunctionNVX handle</summary>
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
    ///     VUID-VkCuLaunchInfoNVX-pParams-parameter If paramCount is not 0, pParams must be a valid pointer to an array
    ///     of paramCount bytes
    /// </summary>
    public nuint paramCount;

    /// <summary>
    ///     VUID-VkCuLaunchInfoNVX-pParams-parameter If paramCount is not 0, pParams must be a valid pointer to an array
    ///     of paramCount bytes
    /// </summary>
    public void** pParams;

    /// <summary>
    ///     VUID-VkCuLaunchInfoNVX-pExtras-parameter If extraCount is not 0, pExtras must be a valid pointer to an array
    ///     of extraCount bytes
    /// </summary>
    public nuint extraCount;

    /// <summary>
    ///     VUID-VkCuLaunchInfoNVX-pExtras-parameter If extraCount is not 0, pExtras must be a valid pointer to an array
    ///     of extraCount bytes
    /// </summary>
    public void** pExtras;
}