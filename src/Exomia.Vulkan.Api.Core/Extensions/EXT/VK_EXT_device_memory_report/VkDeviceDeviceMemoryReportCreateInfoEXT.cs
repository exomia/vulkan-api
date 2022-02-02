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
///     VkDeviceDeviceMemoryReportCreateInfoEXT - Register device memory report callbacks for a Vulkan device -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceDeviceMemoryReportCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceDeviceMemoryReportCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is 0 and reserved for future use.</summary>
    public VkDeviceMemoryReportFlagsEXT flags;

    /// <summary>pfnUserCallback is the application callback function to call.</summary>
    public delegate*<VkDeviceMemoryReportCallbackDataEXT* /*pCallbackData*/, void* /*pUserData*/, void> pfnUserCallback;

    /// <summary>pUserData is user data to be passed to the callback.</summary>
    public void* pUserData;
}