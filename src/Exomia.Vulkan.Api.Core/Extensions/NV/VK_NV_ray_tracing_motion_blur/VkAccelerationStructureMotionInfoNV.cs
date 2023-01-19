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
///     VkAccelerationStructureMotionInfoNV - Structure specifying the parameters of a newly created acceleration structure
///     object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInfoNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkAccelerationStructureCreateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkAccelerationStructureCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureMotionInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxInstances is the maximum number of instances that may be used in the motion top-level acceleration
    ///     structure.
    /// </summary>
    public uint maxInstances;

    /// <summary>flags is 0 and reserved for future use.</summary>
    public VkAccelerationStructureMotionInfoFlagsNV flags;
}