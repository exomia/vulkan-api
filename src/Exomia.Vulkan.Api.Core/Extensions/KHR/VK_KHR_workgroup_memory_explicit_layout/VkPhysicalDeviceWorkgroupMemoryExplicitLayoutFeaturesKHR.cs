#region License

// Copyright (c) 2018-2024, exomia
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
///     VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR - Structure describing the workgroup storage explicit
///     layout features that can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     workgroupMemoryExplicitLayout indicates whether the implementation supports the SPIR-V
    ///     WorkgroupMemoryExplicitLayoutKHR capability.
    /// </summary>
    public VkBool32 workgroupMemoryExplicitLayout;

    /// <summary>
    ///     workgroupMemoryExplicitLayoutScalarBlockLayout indicates whether the implementation supports scalar alignment
    ///     for laying out Workgroup Blocks.
    /// </summary>
    public VkBool32 workgroupMemoryExplicitLayoutScalarBlockLayout;

    /// <summary>
    ///     workgroupMemoryExplicitLayout8BitAccess indicates whether objects in the Workgroup storage class with the
    ///     Block decoration canhave 8-bit integer members. If this feature is not enabled, 8-bit integer members must not be
    ///     used in such objects. This also indicates whether shader modules can declare the
    ///     WorkgroupMemoryExplicitLayout8BitAccessKHR capability.
    /// </summary>
    public VkBool32 workgroupMemoryExplicitLayout8BitAccess;

    /// <summary>
    ///     workgroupMemoryExplicitLayout16BitAccess indicates whether objects in the Workgroup storage class with the
    ///     Block decoration canhave 16-bit integer and 16-bit floating-point members. If this feature is not enabled, 16-bit
    ///     integer or 16-bit floating-point members must not be used in such objects. This also indicates whether shader
    ///     modules can declare the WorkgroupMemoryExplicitLayout16BitAccessKHR capability.
    /// </summary>
    public VkBool32 workgroupMemoryExplicitLayout16BitAccess;
}