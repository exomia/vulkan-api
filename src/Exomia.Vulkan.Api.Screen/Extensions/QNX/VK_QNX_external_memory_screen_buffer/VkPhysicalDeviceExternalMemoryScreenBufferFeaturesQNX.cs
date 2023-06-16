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
namespace Exomia.Vulkan.Api.Screen;

/// <summary>
///     VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX - Structure describing QNX Screen Buffer features that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX.html
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
public unsafe struct VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     screenBufferImport indicates whether QNX Screen buffer import functionality is supported. If
    ///     screenBufferImport is set to VK_TRUE, VkDeviceMemory supports importing _screen_buffer from applications. In this
    ///     case, the application is responsible for the resource management of the _screen_buffer.
    /// </summary>
    public VkBool32 screenBufferImport;
}