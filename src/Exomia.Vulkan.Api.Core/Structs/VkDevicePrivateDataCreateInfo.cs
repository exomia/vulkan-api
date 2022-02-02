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
///     VkDevicePrivateDataCreateInfo - Reserve private data slots -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDevicePrivateDataCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDevicePrivateDataCreateInfo.html</a>
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
public unsafe struct VkDevicePrivateDataCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>privateDataSlotRequestCount is the amount of slots to reserve.</summary>
    public uint privateDataSlotRequestCount;
}