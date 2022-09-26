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
///     VkCuFunctionCreateInfoNVX - Stub description of VkCuFunctionCreateInfoNVX -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCuFunctionCreateInfoNVX.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCuFunctionCreateInfoNVX.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuFunctionCreateInfoNVX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX;

    /// <summary>
    ///     sType<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuFunctionCreateInfoNVX"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuFunctionCreateInfoNVX </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuFunctionCreateInfoNVX"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuFunctionCreateInfoNVX </a>
    /// </summary>
    public void* pNext;

    /// <summary>
    ///     module<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuFunctionCreateInfoNVX"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuFunctionCreateInfoNVX </a>
    /// </summary>
    public VkCuModuleNVX module;

    /// <summary>
    ///     pName<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuFunctionCreateInfoNVX"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCuFunctionCreateInfoNVX </a>
    /// </summary>
    public byte* pName;
}