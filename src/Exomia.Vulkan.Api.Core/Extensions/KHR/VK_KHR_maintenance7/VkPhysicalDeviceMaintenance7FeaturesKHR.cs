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
///     VkPhysicalDeviceMaintenance7FeaturesKHR - Structure describing whether the implementation supports maintenance7
///     functionality -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance7FeaturesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance7FeaturesKHR.html
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
public unsafe struct VkPhysicalDeviceMaintenance7FeaturesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_FEATURES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maintenance7 indicates that the implementation supports the following:The
    ///     VK_RENDERING_CONTENTS_INLINE_BIT_KHR and VK_SUBPASS_CONTENTS_INLINE_AND_SECONDARY_COMMAND_BUFFERS_KHRflags can be
    ///     used to record commands in render pass instances both inline and in secondary command buffers executed with
    ///     vkCmdExecuteCommands for dynamic rendering and legacy render passes respectively.Querying information regarding the
    ///     underlying devices in environments where the Vulkan implementation is provided through layered implementations.
    ///     This is done by chaining VkPhysicalDeviceLayeredApiPropertiesListKHR to VkPhysicalDeviceProperties2.New limits
    ///     which indicate the maximum total count of dynamic uniform buffers and dynamic storage buffers that can be included
    ///     in a pipeline layout.32-bit timestamp queries must wrap on overflowA property that indicates whether a fragment
    ///     shading rate attachment can have a size that is too small to cover a specified render area.A property that
    ///     indicates support for writing to one aspect of a depth/stencil attachment without performing a read-modify-write
    ///     operation on the other aspect
    /// </summary>
    public VkBool32 maintenance7;
}