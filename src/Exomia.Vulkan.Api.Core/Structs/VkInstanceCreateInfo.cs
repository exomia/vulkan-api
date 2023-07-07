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
///     VkInstanceCreateInfo - Structure specifying parameters of a newly created instance -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkInstanceCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkInstanceCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkInstanceCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkInstanceCreateFlagBits indicating the behavior of the instance.</summary>
    public VkInstanceCreateFlags flags;

    /// <summary>
    ///     pApplicationInfo is NULL or a pointer to a VkApplicationInfo structure. If not NULL, this information helps
    ///     implementations recognize behavior inherent to classes of applications. VkApplicationInfo is defined in detail
    ///     below.
    /// </summary>
    public VkApplicationInfo* pApplicationInfo;

    /// <summary>enabledLayerCount is the number of global layers to enable.</summary>
    public uint enabledLayerCount;

    /// <summary>
    ///     ppEnabledLayerNames is a pointer to an array of enabledLayerCount null-terminated UTF-8 strings containing the
    ///     names of layers to enable for the created instance. The layers are loaded in the order they are listed in this
    ///     array, with the first array element being the closest to the application, and the last array element being the
    ///     closest to the driver. See the
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#extendingvulkan-layers section for
    ///     further details.
    /// </summary>
    public byte** ppEnabledLayerNames;

    /// <summary>enabledExtensionCount is the number of global extensions to enable.</summary>
    public uint enabledExtensionCount;

    /// <summary>
    ///     ppEnabledExtensionNames is a pointer to an array of enabledExtensionCount null-terminated UTF-8 strings
    ///     containing the names of extensions to enable.
    /// </summary>
    public byte** ppEnabledExtensionNames;
}