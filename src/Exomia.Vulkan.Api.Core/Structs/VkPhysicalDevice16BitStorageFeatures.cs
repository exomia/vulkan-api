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
///     VkPhysicalDevice16BitStorageFeatures - Structure describing features supported by VK_KHR_16bit_storage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice16BitStorageFeatures.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice16BitStorageFeatures.html
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
public unsafe struct VkPhysicalDevice16BitStorageFeatures
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     storageBuffer16BitAccess specifies whether objects in the     StorageBuffer, ShaderRecordBufferKHR,     or
    ///     PhysicalStorageBuffer    storage class with the Block decoration can have 16-bit integer     and 16-bit
    ///     floating-point members.     If this feature is not enabled, 16-bit integer or 16-bit floating-point     members
    ///     must not be used in such objects.     This also specifies whether shader modules can declare the
    ///     StorageBuffer16BitAccess capability.
    /// </summary>
    public VkBool32 storageBuffer16BitAccess;

    /// <summary>
    ///     uniformAndStorageBuffer16BitAccess specifies whether objects in the Uniform storage class with the Block
    ///     decoration can have 16-bit integer and 16-bit floating-point members. If this feature is not enabled, 16-bit
    ///     integer or 16-bit floating-point members must not be used in such objects. This also specifies whether shader
    ///     modules can declare the UniformAndStorageBuffer16BitAccess capability.
    /// </summary>
    public VkBool32 uniformAndStorageBuffer16BitAccess;

    /// <summary>
    ///     storagePushConstant16 specifies whether objects in the PushConstant storage class can have 16-bit integer and
    ///     16-bit floating-point members. If this feature is not enabled, 16-bit integer or floating-point members must not be
    ///     used in such objects. This also specifies whether shader modules can declare the StoragePushConstant16 capability.
    /// </summary>
    public VkBool32 storagePushConstant16;

    /// <summary>
    ///     storageInputOutput16 specifies whether objects in the Inputand Output storage classes can have 16-bit integer
    ///     and 16-bit floating-point members. If this feature is not enabled, 16-bit integer or 16-bit floating-point members
    ///     must not be used in such objects. This also specifies whether shader modules can declare the StorageInputOutput16
    ///     capability.
    /// </summary>
    public VkBool32 storageInputOutput16;
}