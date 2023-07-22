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
///     VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV - Structure describing the device-generated compute
///     features that can: be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV.html
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
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     deviceGeneratedComputeindicates whether the implementation supports functionality to generate dispatch
    ///     commands and push constants for the compute pipeline on the device. See Device-Generated Commands.
    /// </summary>
    public VkBool32 deviceGeneratedCompute;

    /// <summary>
    ///     deviceGeneratedComputePipelines indicates whether the implementation supports functionality to generate
    ///     commands to bind compute pipelines on the device. See Device-Generated Commands.
    /// </summary>
    public VkBool32 deviceGeneratedComputePipelines;

    /// <summary>
    ///     deviceGeneratedComputeCaptureReplay indicates whether the implementation supports functionality to capture
    ///     compute pipeline address and reuse later for replay in Device-Generated Commands.
    /// </summary>
    public VkBool32 deviceGeneratedComputeCaptureReplay;
}