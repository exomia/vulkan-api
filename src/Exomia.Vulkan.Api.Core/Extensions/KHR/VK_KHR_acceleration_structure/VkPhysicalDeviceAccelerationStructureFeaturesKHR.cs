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
///     VkPhysicalDeviceAccelerationStructureFeaturesKHR - Structure describing the acceleration structure features that
///     can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAccelerationStructureFeaturesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAccelerationStructureFeaturesKHR.html
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
public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     accelerationStructure indicates whether the implementation supports the acceleration structure functionality.
    ///     See Acceleration Structures.
    /// </summary>
    public VkBool32 accelerationStructure;

    /// <summary>
    ///     accelerationStructureCaptureReplay indicates whether the implementation supports saving and reusing
    ///     acceleration structure device addresses, e.g. for trace capture and replay.
    /// </summary>
    public VkBool32 accelerationStructureCaptureReplay;

    /// <summary>
    ///     accelerationStructureIndirectBuild indicates whether the implementation supports indirect acceleration
    ///     structure build commands, e.g. vkCmdBuildAccelerationStructuresIndirectKHR.
    /// </summary>
    public VkBool32 accelerationStructureIndirectBuild;

    /// <summary>
    ///     accelerationStructureHostCommands indicates whether the implementation supports host side acceleration
    ///     structure commands, e.g. vkBuildAccelerationStructuresKHR, vkCopyAccelerationStructureKHR,
    ///     vkCopyAccelerationStructureToMemoryKHR, vkCopyMemoryToAccelerationStructureKHR,
    ///     vkWriteAccelerationStructuresPropertiesKHR.
    /// </summary>
    public VkBool32 accelerationStructureHostCommands;

    /// <summary>
    ///     descriptorBindingAccelerationStructureUpdateAfterBind indicates whether the implementation supports updating
    ///     acceleration structure descriptors after a set is bound. If this feature is not enabled,
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT must not be used with VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR.
    /// </summary>
    public VkBool32 descriptorBindingAccelerationStructureUpdateAfterBind;
}