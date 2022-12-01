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
///     VkDirectDriverLoadingInfoLUNARG - Structure specifying the information required to load an additional driver
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDirectDriverLoadingInfoLUNARG.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDirectDriverLoadingInfoLUNARG.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDirectDriverLoadingInfoLUNARG
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingInfoLUNARG">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingInfoLUNARG
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>
    ///     pNext<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingInfoLUNARG">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingInfoLUNARG
    ///     </a>
    /// </summary>
    public void* pNext;

    /// <summary>
    ///     flags<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingInfoLUNARG">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingInfoLUNARG
    ///     </a>
    /// </summary>
    public VkDirectDriverLoadingFlagsLUNARG flags;

    /// <summary>
    ///     pfnGetInstanceProcAddr<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingInfoLUNARG">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingInfoLUNARG
    ///     </a>
    /// </summary>
    public delegate*<VkInstance /*instance*/, byte* /*pName*/, PFN_vkVoidFunction> pfnGetInstanceProcAddr;
}