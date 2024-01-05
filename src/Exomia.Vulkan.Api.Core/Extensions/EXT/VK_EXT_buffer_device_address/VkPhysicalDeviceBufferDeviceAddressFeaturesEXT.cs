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
///     VkPhysicalDeviceBufferDeviceAddressFeaturesEXT - Structure describing buffer address features that can be supported
///     by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBufferDeviceAddressFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBufferDeviceAddressFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     bufferDeviceAddress indicates that the implementation supports accessing buffer memory in shaders as storage
    ///     buffers via an address queried from vkGetBufferDeviceAddressEXT.
    /// </summary>
    public VkBool32 bufferDeviceAddress;

    /// <summary>
    ///     bufferDeviceAddressCaptureReplay indicates that the implementation supports saving and reusing buffer
    ///     addresses, e.g. for trace capture and replay.
    /// </summary>
    public VkBool32 bufferDeviceAddressCaptureReplay;

    /// <summary>
    ///     bufferDeviceAddressMultiDevice indicates that the implementation supports the bufferDeviceAddress feature for
    ///     logical devices created with multiple physical devices. If this feature is not supported, buffer addresses must not
    ///     be queried on a logical device created with more than one physical device.
    /// </summary>
    public VkBool32 bufferDeviceAddressMultiDevice;
}