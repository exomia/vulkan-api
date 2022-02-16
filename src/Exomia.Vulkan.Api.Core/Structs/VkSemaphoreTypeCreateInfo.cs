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
///     VkSemaphoreTypeCreateInfo - Structure specifying the type of a newly created semaphore -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreTypeCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreTypeCreateInfo.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkSemaphoreCreateInfo,VkPhysicalDeviceExternalSemaphoreInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSemaphoreCreateInfo,VkPhysicalDeviceExternalSemaphoreInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreTypeCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>semaphoreType is a VkSemaphoreType value specifying the type of the semaphore.</summary>
    public VkSemaphoreType semaphoreType;

    /// <summary>initialValue is the initial payload value if semaphoreTypeis VK_SEMAPHORE_TYPE_TIMELINE.</summary>
    public ulong initialValue;
}