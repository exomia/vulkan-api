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
///     VkPhysicalDeviceRobustness2FeaturesEXT - Structure describing the out-of-bounds behavior for an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRobustness2FeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRobustness2FeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     robustBufferAccess2 indicates whether buffer accesses are tightly bounds-checked against the range of the
    ///     descriptor. Uniform buffers must be bounds-checked to the range of the descriptor, where the range is rounded up to
    ///     a multiple of robustUniformBufferAccessSizeAlignment. Storage buffers must be bounds-checked to the range of the
    ///     descriptor, where the range is rounded up to a multiple of robustStorageBufferAccessSizeAlignment. Out of bounds
    ///     buffer loads will return zero values, and image load, sample, and atomic operations from texel buffers will have
    ///     (0,0,1) values inserted for missing G, B, or A components based on the format.
    /// </summary>
    public VkBool32 robustBufferAccess2;

    /// <summary>
    ///     robustImageAccess2 indicates whether image accesses are tightly bounds-checked against the dimensions of the
    ///     image view. Out of bounds image load, sample, and atomic operationsfrom images will return zero values, with
    ///     (0,0,1) values inserted for missing G, B, or A components based on the format.
    /// </summary>
    public VkBool32 robustImageAccess2;

    /// <summary>
    ///     nullDescriptor indicates whether descriptors can be written with a VK_NULL_HANDLE resource or view, which are
    ///     considered valid to access and act as if the descriptor were bound to nothing.
    /// </summary>
    public VkBool32 nullDescriptor;
}