#region License

// Copyright (c) 2018-2023, exomia
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

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkDirectDriverLoadingFlagsLUNARG flags;

    /// <summary>
    ///     pfnGetInstanceProcAddr is a PFN_vkGetInstanceProcAddrLUNARGpointer to the driver vkGetInstanceProcAddr
    ///     function.
    /// </summary>
    public delegate*<VkInstance /*instance*/, byte* /*pName*/, delegate*<void>> pfnGetInstanceProcAddr;
}