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
///     VkPhysicalDeviceMaintenance4Features - Structure describing whether the implementation supports maintenance4 functionality -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance4Features.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance4Features.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkPhysicalDeviceFeatures2,VkDeviceCreateInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance4Features
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> maintenance4 indicates that the implementation supports the following:The application may destroy a VkPipelineLayout object immediately after using it to create another object.LocalSizeId can be used as an alternative to LocalSize to specify the local workgroup size with specialization constants.Images created with identical creation parameters will always have the same alignment requirements.The size memory requirement of a buffer or image is never greater than that of another buffer or image created with a greater or equal size.Push constants do not have to be initialized before they are dynamically accessed.The interface matching rules allow a larger output vector to match with a smaller input vector, with additional values being discarded. </summary>
    public VkBool32 maintenance4;
}