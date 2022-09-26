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
///     VkCuModuleCreateInfoNVX - Stub description of VkCuModuleCreateInfoNVX -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCuModuleCreateInfoNVX.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCuModuleCreateInfoNVX.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuModuleCreateInfoNVX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX;

    /// <summary>
    ///     sType<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleCreateInfoNVX"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleCreateInfoNVX </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleCreateInfoNVX"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleCreateInfoNVX </a>
    /// </summary>
    public void* pNext;

    /// <summary>
    ///     dataSize<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleCreateInfoNVX"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleCreateInfoNVX </a>
    /// </summary>
    public nuint dataSize;

    /// <summary>
    ///     pData<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleCreateInfoNVX"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuModuleCreateInfoNVX </a>
    /// </summary>
    public void* pData;
}