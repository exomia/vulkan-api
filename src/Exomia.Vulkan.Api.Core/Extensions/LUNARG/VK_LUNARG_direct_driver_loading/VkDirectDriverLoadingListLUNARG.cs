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
///     VkDirectDriverLoadingListLUNARG - Structure specifying additional drivers to load -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDirectDriverLoadingListLUNARG.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDirectDriverLoadingListLUNARG.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkInstanceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkInstanceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDirectDriverLoadingListLUNARG
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>mode controls the mode in which to load the provided drivers.</summary>
    public VkDirectDriverLoadingModeLUNARG mode;

    /// <summary>driverCount is the number of driver manifest paths.</summary>
    public uint driverCount;

    /// <summary>pDrivers is a pointer to an array of driverCountVkDirectDriverLoadingInfoLUNARG structures.</summary>
    public VkDirectDriverLoadingInfoLUNARG* pDrivers;
}