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
///     VkExportSemaphoreCreateInfo - Structure specifying handle types that can be exported from a semaphore -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportSemaphoreCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportSemaphoreCreateInfo.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSemaphoreCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSemaphoreCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportSemaphoreCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     handleTypes is a bitmask of VkExternalSemaphoreHandleTypeFlagBits specifying one or more semaphore handle
    ///     types the application can export from the resulting semaphore. The application can request multiple handle types
    ///     for the same semaphore.
    /// </summary>
    public VkExternalSemaphoreHandleTypeFlags handleTypes;
}