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
///     VkPhysicalDeviceRobustness2PropertiesEXT - Structure describing robust buffer access properties supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRobustness2PropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRobustness2PropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     robustStorageBufferAccessSizeAlignment is the number of bytes that the range of a storage buffer descriptor is
    ///     rounded up to when used for bounds-checking when the robustBufferAccess2 feature is enabled. This value must be
    ///     either 1 or 4.
    /// </summary>
    public VkDeviceSize robustStorageBufferAccessSizeAlignment;

    /// <summary>
    ///     robustUniformBufferAccessSizeAlignment is the number of bytes that the range of a uniform buffer descriptor is
    ///     rounded up to when used for bounds-checking when the robustBufferAccess2 feature is enabled. This value must be a
    ///     power of two in the range [1, 256].
    /// </summary>
    public VkDeviceSize robustUniformBufferAccessSizeAlignment;
}