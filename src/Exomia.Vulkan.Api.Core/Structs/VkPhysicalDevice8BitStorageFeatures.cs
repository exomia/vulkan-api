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
///     VkPhysicalDevice8BitStorageFeatures - Structure describing features supported by VK_KHR_8bit_storage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice8BitStorageFeatures.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice8BitStorageFeatures.html
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
public unsafe struct VkPhysicalDevice8BitStorageFeatures
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     storageBuffer8BitAccess indicates whether objects in the     StorageBuffer, ShaderRecordBufferKHR,     or
    ///     PhysicalStorageBuffer    storage class with the Block decoration can have 8-bit integer     members.     If this
    ///     feature is not enabled, 8-bit integer members must not be used     in such objects.     This also indicates whether
    ///     shader modules can declare the     StorageBuffer8BitAccess capability.
    /// </summary>
    public VkBool32 storageBuffer8BitAccess;

    /// <summary>
    ///     uniformAndStorageBuffer8BitAccess indicates whether objects in the Uniform storage class with the Block
    ///     decoration can have 8-bit integer members. If this feature is not enabled, 8-bit integer members must not be used
    ///     in such objects. This also indicates whether shader modules can declare the UniformAndStorageBuffer8BitAccess
    ///     capability.
    /// </summary>
    public VkBool32 uniformAndStorageBuffer8BitAccess;

    /// <summary>
    ///     storagePushConstant8 indicates whether objects in the PushConstant storage class can have 8-bit integer
    ///     members. If this feature is not enabled, 8-bit integer members must not be used in such objects. This also
    ///     indicates whether shader modules can declare the StoragePushConstant8 capability.
    /// </summary>
    public VkBool32 storagePushConstant8;
}